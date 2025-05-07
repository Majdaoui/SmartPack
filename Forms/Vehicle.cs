using SmartPack.Classes;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class Vehicle : TitleForm
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        /// Aquest mètode es crida quan es fa clic al botó "close"
        /// Tanca la finestra actual i obre la finestra AreaUsuari
        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                var areaUsuari = new AreaUsuari();
                areaUsuari.Show();
            }
        }

        /// Aquest mètode es crida quan es carrega la finestra
        /// carrega les dades del vehicle actual
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string id = await GetVehicleId();
        }

        /// Aquest mètode que retorna les dades del vehicle assignat a un usuari"
        private async Task<string> GetVehicleId()
        {
            string response = await dbAPI.GetTransportistaPerUsuari(GestioSessins.id, GestioSessins.token);
            Console.WriteLine("Response Body vehicle: " + response);

            using (JsonDocument doc = JsonDocument.Parse(response))
            {
                JsonElement root = doc.RootElement;
                int id = root.GetProperty("id").GetInt32();
                int usuariId = root.GetProperty("usuariId").GetInt32();
                string email = root.GetProperty("usuariEmail").GetString();
                string llicencia = root.GetProperty("llicencia").GetString();

                JsonElement vehicle = root.GetProperty("vehicle");
                int vehicleId = vehicle.GetProperty("id").GetInt32();
                string marca = vehicle.GetProperty("marca").GetString();
                string model = vehicle.GetProperty("model").GetString();
                string matricula = vehicle.GetProperty("matricula").GetString();
                string color = vehicle.GetProperty("color").GetString();
                string tipus = vehicle.GetProperty("tipus").GetString();

                labelID.Text = id.ToString();
                t_marca.Text = marca;
                t_model.Text = model;
                t_matricula.Text = matricula;
                t_color.Text = color;
                t_tipus.Text = tipus;

                Console.WriteLine($"Usuari ID: {usuariId}, Email: {email}");
                Console.WriteLine($"Vehicle: {marca} {model} ({matricula})");

                return vehicleId.ToString();
            }
        }

        /// Aquest mètode es crida quan es fa clic al botó "actualitzar vehicle"
        /// Actualitza les dades del vehicle actual
        /// 
        private async void update_v_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(t_marca.Text) || string.IsNullOrEmpty(t_model.Text) || string.IsNullOrEmpty(t_matricula.Text))
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
            if(response != null)
            {
                Message msg = new Message("S'ha actualitzat les dades del vehicle correctament", "info");
                msg.ShowDialog();
            }else
            {
                Message msg = new Message("No s'ha pogut actualitzar les dades del vehicle", "error");
                msg.ShowDialog();
            }
           
        }


        /// Aquest mètode es crida quan es fa clic al botó "desactivar vehicle"
        private async void desactivar_v_Click(object sender, EventArgs e)
        {
            string id = labelID.Text;
            var response = await dbAPI.DesactivarVehicle(id, GestioSessins.token);
            if (response != null)
            {
                Message msg = new Message("S'ha desactivat el vehicle correctament", "info");
                msg.ShowDialog();
                var areaUsuari = new AreaUsuari();
                areaUsuari.Show();
                this.Close();
            }
            else
            {
                Message msg = new Message("No s'ha pogut desactivar el vehicle", "error");
                msg.ShowDialog();
            }
        }
    }
}
