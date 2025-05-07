using SmartPack.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartPack
{
    /// <summary>
    /// Classe AltaVehicle
    /// </summary>
    public partial class AltaVehicle : TitleForm
    {
        
        /// <summary>
        /// Constructor de la classe AltaVehicle
        /// </summary>
        public AltaVehicle()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        /// <summary>
        /// Mètode que dibuixa la barra superior en el formulari
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        
        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de guardar vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void guardar_e_Click(object sender, EventArgs e)
        {

            // Obtenir i netejar les dades dels camps del formulari
            string tmatricula = matricula_t.Text;
            string tmodel = model_t.Text;
            string tmarca = marca_t.Text;
            string tcolor = tColor.Text;
            string ttipus = tTipus.Text;
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
                tipus = ttipus,
            };

            object user = new
            {
                email = GestioSessins.email,
                password = GestioSessins.password,
            };
            bool state = await dbAPI.Login(user);
            if (GestioSessins.desactivat)
            {
                Console.WriteLine("Usuari desactivat");
            }
            else if (!string.IsNullOrEmpty(GestioSessins.token) && GestioSessins.token != "0")
            {
                Console.WriteLine("Token: " + GestioSessins.token);
                string id = await dbAPI.crearVehicle(vehicle, GestioSessins.token);
                if (!string.IsNullOrEmpty(id) && id != "0")
                {
                    Console.WriteLine("Response Body vehicle : " + id);
                    object assignar = new
                    {
                        transportistaId = GestioSessins.transportistaId,
                        vehicleId = id,
                    };
                    string message = await dbAPI.assignarVehicleTransportista(GestioSessins.transportistaId, id, GestioSessins.token);
                    Console.WriteLine("Vehicle Message 123 : " + message);
                    if (message == "OK")
                    {
                        Console.WriteLine("Vehicle Message: " + message);
                        using (Message messatgel = new Message("Vehicla creat correctament", "info"))
                        {
                            messatgel.ShowDialog();
                        }
                        Sessio sessio = new Sessio();
                        sessio.Show();
                        this.Close();
                    }
                    else
                    {
                        Console.WriteLine("Error " + message);
                    }
                }
            }
        }

        private void AltaVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
