using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Vehicles : TitleForm
    {
        public TitleForm Open { get; set; } = null;
        public Vehicles()
        {
            InitializeComponent();
            LoadDBVehicle();
            LoadTransportistes();

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Open != null)
            {
                Open.Show();
            }
        }

        /// <summary>
        /// Carrega la llista de vehicles
        /// </summary>
        private async void LoadDBVehicle()
        {
            if (GestioSessins.role == "ROLE_ADMIN")
            {
                try
                {
                    var list = await dbAPI.getVehicleLlist(GestioSessins.token);
                    dataGridViewV.DataSource = null;
                    dataGridViewV.DataSource = list;
                    dataGridViewV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error carregant dades: {ex.Message}");
                }
            }
        }

        private async void desctivate_vehicle_Click(object sender, EventArgs e)
        {
            var id = dataGridViewV.CurrentRow.Cells[0].Value.ToString();
            var res = await dbAPI.DesactivarVehicle(id, GestioSessins.token);
            if (res != null)
            {
                Message msg = new Message("S'ha desactivat el vehicle correctament", "info");
                msg.ShowDialog();
                LoadDBVehicle();
            }
            else
            {
                Message msg = new Message("No s'ha pogut desactivar el vehicle", "error");
                msg.ShowDialog();
            }
        }

        /// <summary>
        /// Carrega les dades del vehicle seleccionat a la taula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewV.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string marca = row.Cells["marca"].Value.ToString();
                string model = row.Cells["model"].Value.ToString();
                string matricula = row.Cells["matricula"].Value.ToString();
                string color = row?.Cells["color"]?.Value?.ToString() ?? string.Empty;
                string tipus = row?.Cells["tipus"]?.Value?.ToString() ?? string.Empty;

                labelID.Text = id;
                t_marca.Text = marca;
                t_model.Text = model;
                t_matricula.Text = matricula;
                t_color.Text = color;
                t_tipus.Text = tipus;
            }
        }

        /// <summary>
        /// Actualitza el vehicle seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void update_v_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(t_marca.Text) || string.IsNullOrEmpty(t_model.Text) || string.IsNullOrEmpty(t_matricula.Text))
            {
                MessageBox.Show("Tots els camps són obligatoris.");
                return;
            }

            object vehicle_update = new
            {
                marca = t_marca.Text,
                model = t_model.Text,
                matricula = t_matricula.Text,
                color = t_color.Text,
                tipus = t_tipus.Text
            };

            string id = labelID.Text;
            var response = await dbAPI.PutVehicleUpdate(vehicle_update, id, GestioSessins.token);
            if (response != null)
            {
                Message msg = new Message("S'ha actualitzat les dades del vehicle correctament", "info");
                msg.ShowDialog();
            }
            else
            {
                Message msg = new Message("No s'ha pogut actualitzar les dades del vehicle", "error");
                msg.ShowDialog();
            }

            LoadDBVehicle();
            LoadTransportistes();
        }

        /// <summary>
        /// Carrega la llista de transportistes
        /// </summary>
        public async void LoadTransportistes()
        {
            List<Transportista> list = await dbAPI.getTransportisteslist(GestioSessins.token);
            if (list == null)
            {
                using (Message message1 = new Message("No hi ha Transportistes", "error"))
                {
                    message1.ShowDialog();
                }
                dataGridViewTT.DataSource = null;
                dataGridViewTT.Refresh();
                return;
            }
            List<TransportistaVisual> listvs = new List<TransportistaVisual>();
            foreach (Transportista transportista in list)
            {
                TransportistaVisual vs = new TransportistaVisual
                {
                    Id = transportista.id,
                    Email = transportista.usuariEmail,
                    Llicencia = transportista.llicencia,
                    Marca = transportista.vehicle.marca,
                    Model = transportista.vehicle.model,
                    Matricula = transportista.vehicle.matricula,
                    Color = transportista.vehicle.color,
                    Tipus = transportista.vehicle.tipus
                };
                listvs.Add(vs);
            }
            dataGridViewTT.DataSource = listvs;
            dataGridViewTT.Refresh();
        }

        /// <summary>
        /// Crea un vehicle nou
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bCrearVehicle_Click(object sender, EventArgs e)
        {
            // Obtenir i netejar les dades dels camps del formulari
            string tmatricula = t_matricula.Text;
            string tmodel = t_model.Text;
            string tmarca = t_marca.Text;
            string tcolor = t_color.Text;
            string ttipus = t_tipus.Text;
            // Comprovar que els camps obligatoris no estiguin buits
            // Si ho estan, mostra un missatge d'error
            if (string.IsNullOrWhiteSpace(tmatricula) || string.IsNullOrWhiteSpace(tmodel)
                || string.IsNullOrWhiteSpace(tmarca))
            {
                Message message = new Message("Revisa els camps són obligatoris.", "Error");
                message.ShowDialog();
                //MessageBox.Show("Tots els camps són obligatoris ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Comprovar que la matrícula sigui vàlida
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!GlobalAPI.EsMatriculaValida(tmatricula))
            {
                Message message = new Message("La matrícula no és vàlida. Format acceptat: '1234ABC', 'B1234AB' o 'BA1234AB'", "Error");
                message.ShowDialog();
                //MessageBox.Show("La matrícula no és vàlida. Format acceptat: '1234ABC', 'B1234AB' o 'BA1234AB'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Comprovar que el model, el color i el tipus siguin correctes només pot tenir lletres i números
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!Regex.IsMatch(tmodel, "^[a-zA-Z0-9]+$"))
            {
                Message message = new Message("El model només pot tenir lletres i números. ", "Error");
                message.ShowDialog();
                //MessageBox.Show("El model només pot tenir lletres i números ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Comprovar que el color, el color i el tipus siguin correctes només pot tenir lletres
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!Regex.IsMatch(tmarca, "^[a-zA-Z]+$"))
            {
                Message message = new Message("El color només pot tenir lletres. ", "Error");
                message.ShowDialog();
                //MessageBox.Show("El color només pot tenir lletres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var vehicle = new
            {
                marca = tmarca,
                model = tmodel,
                matricula = tmatricula,
                color = tcolor,
                tipus = ttipus

            };

            string id = await dbAPI.crearVehicle(vehicle, GestioSessins.token);
            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                Console.WriteLine("Response Body vehicle : " + id);
            }

            LoadDBVehicle();
            LoadTransportistes();
        }

        private async void bAssVehiTrans_Click(object sender, EventArgs e)
        {
            if (dataGridViewV.SelectedRows.Count > 0 && dataGridViewTT.SelectedRows.Count > 0)
            {
                string ServeiID = dataGridViewV.SelectedRows[0].Cells["ID"].Value.ToString();
                string TransID = dataGridViewTT.SelectedRows[0].Cells["ID"].Value.ToString();
                Console.WriteLine($"ServeiID: {ServeiID}, TransID: {TransID}");
                var response = await dbAPI.assignarVehicleTransportista(TransID, ServeiID, GestioSessins.token);
                Console.WriteLine($"response: {response}");
                if (response.Contains("\"OK\":") || response != "error")
                {
                    using (Message msg = new Message("Servei assignat correctament.", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error al assignar el servei.", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
                LoadDBVehicle();
                LoadTransportistes();
            }


        }
    }
}
