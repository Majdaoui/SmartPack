using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari de consulta de serveis
    /// </summary>
    public partial class ConsultaServei : TitleForm
    {
        /// <summary>
        /// Element que conté la imatge a imprimir
        /// </summary>
        private PrintDocument printDocument = new PrintDocument();
        private Image imageToPrint;
        public TitleForm Open { get; set; } = null;

        /// <summary>
        /// Constructor del formulari consulta servei
        /// </summary>
        public ConsultaServei()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        /// <summary>
        /// Carrega el formulari i les dades del servei en el datagrid
        /// </summary>
        /// <param name="e"></param>

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (GestioSessins.role == "ROLE_USER")
            {
                bCambiarEstado.Visible = false;
                cbEstado.Visible = false;
                l_rol.Visible = false;
            }
            LoadDB();
        }

        private bool justClosed = false;

        /// <summary>
        /// Al tancar el formulari, obre el formulari de Principal
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                if(Open != null)
                {
                    Open.Show();
                }
            }
        }

        /// <summary>
        /// Carrega les dades del servei en el datagrid i les mostra
        /// Nomes si el role es ROLE_DELIVERYMAN o ROLE_ADMIN
        /// </summary>
        private async void LoadDB()
        {
            if (GestioSessins.role == "ROLE_DELIVERYMAN")
            {
                string response = await dbAPI.GetTransportistaPerUsuari(GestioSessins.id, GestioSessins.token);
                Console.WriteLine("Response Body vehicle: " + response);
                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    JsonElement root = doc.RootElement;
                    int id = root.GetProperty("id").GetInt32();
                    List<ClassServei> list = await dbAPI.getServeiTransportista(id.ToString());
                    if (list != null)
                    {
                        List<VisualServei> viewModels = list.Select(s => new VisualServei
                        {
                            ID = s.id,
                            Estat = s.estat,
                            Detalls = s.paquet?.detalls,
                            Pes = s.paquet?.pes ?? 0,
                            Mida = s.paquet?.mida,
                            Destinatari = s.paquet?.nomDestinatari,
                            Adreça = s.paquet?.adreçadestinatari,
                            Telefon = s.paquet?.telefondestinatari
                        }).ToList();
                        dataGridView1.DataSource = viewModels;
                        dataGridView1.Refresh();
                    }
                }
                ImageQR.Visible = false;
            }
            else if (GestioSessins.role == "ROLE_ADMIN")
            {
                List<ClassServei> list = await dbAPI.getServeiLlist(GestioSessins.token);
                List<VisualServei> listvs = new List<VisualServei>();
                foreach (ClassServei classServei in list)
                {
                    VisualServei vs = new VisualServei
                    {
                        ID = classServei.id,
                        Estat = classServei.estat,
                        Detalls = classServei.paquet?.detalls,
                        Pes = classServei.paquet?.pes ?? 0,
                        Mida = classServei.paquet?.mida,
                        Destinatari = classServei.paquet?.nomDestinatari,
                        Adreça = classServei.paquet?.adreçadestinatari,
                        Telefon = classServei.paquet?.telefondestinatari
                    };
                    listvs.Add(vs);
                }

                dataGridView1.DataSource = listvs;
                dataGridView1.Refresh();
            }
            
        }

        /// <summary>
        /// Canvia l'estat del servei seleccionat
        /// Nomes si el role es ROLE_DELIVERYMAN o ROLE_ADMIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string Estat = selectedRow.Cells["Estat"].Value.ToString();
                string Detalls = selectedRow.Cells["Detalls"].Value.ToString();
                Console.WriteLine($"Estat: {Estat}, Detalls: {Detalls}");
                var r = await dbAPI.canviEstatServei(ID, cbEstado.Text, GestioSessins.token);
                if (r != "0")
                {
                    using (Message message1 = new Message("Estat canviat correctament", "info"))
                    {
                        message1.ShowDialog();
                    }
                }
                else
                {
                    using (Message message1 = new Message("Error al canviar l'estat", "error"))
                    {
                        message1.ShowDialog();
                    }
                }
                LoadDB();
            }
            else
            {
                using (Message message1 = new Message("Si us plau selecciona el servei", "error"))
                {
                    message1.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Carrega l'historial del servei seleccionat
        /// Amb tots els canvis realitzats al servei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ID = row.Cells["ID"].Value.ToString();
                string Estat = row.Cells["Estat"].Value.ToString();
                string Detalls = row.Cells["Detalls"].Value.ToString();
                Console.WriteLine($"Estat: {Estat}, Detalls: {Detalls}");
                List<HistorialServei> historial = await dbAPI.getServeiHistorial(ID, GestioSessins.token);
                dataGridHistorial.DataSource = historial;
                dataGridHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridHistorial.Columns["id"].Visible = false;
                dataGridHistorial.Columns["serveId"].Visible = false;
                dataGridHistorial.Columns["tranpostistaId"].Visible = false;
                dataGridHistorial.Refresh();
            }
            ImageQR.Visible = false;
        }


        /// <summary>
        /// Genera la factura del servei seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            var novaFactura = new Factura
            {
                numFactura = GeneraNumeroFactura(),
                preu = GenerarPreu(),
                iva = 21,
                data = DateTime.Now,
                serveiId = Convert.ToInt32(selectedRow.Cells["ID"].Value),
                usuariId = Convert.ToInt32(GestioSessins.usuariId),
                pagat = true,
                metodePagament = "Transferència"
            };
            var factura = await dbAPI.generarFactura(novaFactura, novaFactura.serveiId.ToString(), GestioSessins.token);
            if (factura != null)
            {
                using (Message message1 = new Message("Factura generada correctament", "info"))
                {
                    message1.ShowDialog();
                }
            }
            else
            {
                using (Message message1 = new Message("Error al generar la factura", "error"))
                {
                    message1.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Genera un numero de factura aleatori
        /// </summary>
        /// <returns></returns>
        private string GeneraNumeroFactura()
        {
            return $"SPK-{DateTime.Now:yyyyMMdd-HHmmss}";
        }


        /// <summary>
        /// Genera un preu aleatori entre 7 i 10
        /// </summary>
        /// <returns></returns>
        private decimal GenerarPreu()
        {
            Random rnd = new Random();
            double preu = rnd.NextDouble() * (10 - 7) + 7;
            return Math.Round((decimal)preu, 2);
        }

        /// <summary>
        /// Genera el QR del servei seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bQR_Click(object sender, EventArgs e)
        {
            ImageQR.Visible = true;
            ImageQR.SizeMode = PictureBoxSizeMode.CenterImage;
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string ID = selectedRow.Cells["ID"].Value.ToString();
            string jsonResponse = await dbAPI.generarQR(ID);

            Console.WriteLine("Response Body QR: " + jsonResponse);

            if (jsonResponse != null)
            {
                var json = System.Text.Json.JsonDocument.Parse(jsonResponse);

                if (json.RootElement.TryGetProperty("paquet", out var paquetProperty) &&
                    paquetProperty.TryGetProperty("codiqr", out var qrProperty))
                {
                    string base64Image = qrProperty.GetString();
                    Console.WriteLine("Base64 image (first 100 chars): " + base64Image.Substring(0, 100));
                    try
                    {
                        byte[] imageBytes = Convert.FromBase64String(base64Image);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            using (var tempImage = Image.FromStream(ms))
                            {
                                ImageQR.Image = new Bitmap(tempImage);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en carregar la imatge del QR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No s'ha trobat el camp 'codiqr'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al generar el QR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Genera l'etiqueta del servei seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bEtiqueta_Click(object sender, EventArgs e)
        {
            ImageLabel.Visible = true;
            ImageLabel.SizeMode = PictureBoxSizeMode.CenterImage;
            ImageLabel.SizeMode = PictureBoxSizeMode.AutoSize;
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string ID = selectedRow.Cells["ID"].Value.ToString();
            Image etiquetaImage = await dbAPI.ServeiEtiqueta(ID);
            if (etiquetaImage != null)
            {
                ImageLabel.Image = etiquetaImage;
            }
            else
            {
                MessageBox.Show("Error al generar l'etiqueta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Dibuixa la imatge seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (imageToPrint != null)
            {
                int x = (e.PageBounds.Width - imageToPrint.Width) / 2;
                int y = (e.PageBounds.Height - imageToPrint.Height) / 2;

                e.Graphics.DrawImage(imageToPrint, x, y);
            }
        }


        /// <summary>
        /// Imprimeix l'etiqueta del servei seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPrint_Click(object sender, EventArgs e)
        {
            if (ImageLabel.Image != null)
            {
                imageToPrint = ImageLabel.Image;

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                MessageBox.Show("No hi ha cap imatge per imprimir.");
            }
        }
    }
}
