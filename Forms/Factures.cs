using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari factures
    /// 
    /// </summary>
    public partial class Factures : TitleForm
    {
        public TitleForm Open { get; set; } = null;
        /// <summary>
        /// Constructor del formulari de factures i carrega les factures en el datagridview
        /// </summary>
        public Factures()
        {
            InitializeComponent();
            LoadFactures();
        }

        /// <summary>
        /// Al tancar el formulari, obre el formulari de principal
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Open != null)
            {
                Open.Show();
            }
        }

        /// <summary>
        /// Carrega les factures del servei i les mostra en el datagridview
        /// </summary>
        public async void LoadFactures()
        {
            List<Factura> list = null;
            if (GestioSessins.role == "ROLE_ADMIN")
            {
                list = await dbAPI.getFactures(GestioSessins.token);
            }
            else if (GestioSessins.role == "ROLE_USER")
            {
                list = await dbAPI.getFacturesPerUsari(GestioSessins.id);
            }
            
            if (GestioSessins.role == "ROLE_ADMIN" || GestioSessins.role == "ROLE_USER")
            {
                if(list != null)
                {
                    List<VisualFactura> listvs = new List<VisualFactura>();
                    foreach (Factura factura in list)
                    {
                        VisualFactura vs = new VisualFactura()
                        {
                            Id = factura.id,
                            Numero = factura.numFactura,
                            Preu = factura.preu.ToString("0.00") + " €",
                            IVA = factura.iva.ToString("0.00") + " %",
                            Total = factura.total.ToString("0.00") + " €",
                            Data = factura.data.ToShortDateString(),
                            ServeiId = factura.serveiId,
                            UsuariId = factura.usuariId,
                            UsuariDNI = factura.usuariDni,
                            NomComplet = factura.usuariNomComplet,
                            Adreça = factura.usuariAdreça,
                            EstatPagament = factura.pagat ? "Pagada" : "Pendent",
                            MetodePagament = factura.metodePagament
                        };
                        listvs.Add(vs);
                    }
                    dataGridView1.DataSource = listvs;
                    dataGridView1.Refresh();
                }
            }
        }


        /// <summary>
        /// Paga la factura seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bPagarFactura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ID = selectedRow.Cells["id"].Value.ToString();
                Console.WriteLine("GestioSessins.token: " + GestioSessins.token);
                var responseBody = await dbAPI.facturaPagar(ID, GestioSessins.token);
                if (responseBody.Contains("marcada"))
                {
                    using (Message messatge = new Message("La factura ja està marcada com a pagada", "info"))
                    {
                        messatge.ShowDialog();
                    }
                    LoadFactures();
                }
                else if (responseBody.Contains("pagada"))
                {
                    using (Message messatge = new Message("Factura pagada correctament", "info"))
                    {
                        messatge.ShowDialog();
                    }
                    LoadFactures();
                }
                else
                {
                    using (Message messatge = new Message("Error al pagar la factura", "error"))
                    {
                        messatge.ShowDialog();
                    }
                    LoadFactures();
                }
            }
        }


        /// <summary>
        /// Selecciona la fila del datagridview i agafa l'ID de la factura seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ID = row.Cells["id"].Value.ToString();
                Factura factura = new Factura
                {
                   

                };
                //Facturacio vistaFactura = new Facturacio(factura);
            }
        }

        private async void btnVeureFactura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string idFactura = selectedRow.Cells["Id"].Value.ToString();

                List<Factura> factures = await dbAPI.getFactures(GestioSessins.token);
                Factura factura = factures.FirstOrDefault(f => f.id.ToString() == idFactura);

                if (factura != null)
                {
                    Facturacio vistaFactura = new Facturacio(factura);
                    vistaFactura.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No s'ha trobat la factura.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una factura.");
            }
        }
    }
}
