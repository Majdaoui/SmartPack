using SmartPack.Classes;
using System;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class AreaUsuari : TitleForm
    {
        public AreaUsuari()
        {
            InitializeComponent();
        }

        private void AreaUsuari_Load(object sender, EventArgs e)
        {
            ClassUsuari usuari = new ClassUsuari();
            //usuari = dbAPI.GetUsuari();
            
            nom_usuari.Text = usuari.nom;
            cognom_p_usuari.Text = usuari.pcognom;
            dni_usuari.Text = usuari.dni;
            telefon_usuari.Text = usuari.telefon;
            email_usuari.Text = usuari.email;
            t_via_usuari.Text = usuari.tvia;
            num_usuari.Text = usuari.num;
            porta_usuari.Text = usuari.porta;
            planta_usuari.Text = usuari.planta;
            nom_via_usuari.Text = usuari.nom_via;
            poblacio_usuari.Text = usuari.poblacio;
            provincia_usuari.Text = usuari.provincia;
            cp_usuari.Text = usuari.cp;
            observacions_usuari.Text = usuari.comentaris;
            Rol_Usuari.Text = usuari.rol;
            
        }

        private void Bcanvi_contrasenya_Click(object sender, EventArgs e)
        {
            CanviContrasenya canviContrasenya = new CanviContrasenya();
            canviContrasenya.Show();

            this.Close();
        }


        private void Bsortir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void bDesactivar_Click(object sender, EventArgs e)
        {

            var consulta = new
            {
                id = GestioSessins.id
            };
            string data = await dbAPI.UserDB(consulta, "desactivate");
            if (!string.IsNullOrEmpty(data))
            {
                Message messatge = new Message("Usuari desactivat correctament", "info");
                messatge.ShowDialog();
                Application.Exit();
            }
        }
    }
}
