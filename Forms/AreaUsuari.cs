using SmartPack.Classes;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class AreaUsuari : TitleForm
    {
        

        public AreaUsuari()
        {
            InitializeComponent();
        }

        private async void test(ClassUsuari usuari)
        {
            string id = await dbAPI.getCurrentUser(GestioSessins.token);
            nom_usuari.Text = usuari.nom;
            usuari.separarCognom();
            cognom_p_usuari.Text = usuari.pcognom;
            cognom_s_usuari.Text = usuari.scognom;
            dni_usuari.Text = usuari.dni;
            telefon_usuari.Text = usuari.telefon;
            email_usuari.Text = usuari.email;
            usuari.SepararDireccio();
            t_via_usuari.Text = usuari.tvia;
            nom_via_usuari.Text = usuari.nom_via;
            num_usuari.Text = usuari.num;
            planta_usuari.Text = usuari.planta;
            porta_usuari.Text = usuari.porta;
            cp_usuari.Text = usuari.cp;
            poblacio_usuari.Text = usuari.poblacio;
            provincia_usuari.Text = usuari.provincia;
           
            observacions_usuari.Text = usuari.observacions;
            Rol_Usuari.Text = usuari.rol;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string id = await dbAPI.getCurrentUser(GestioSessins.token);
            ClassUsuari usuari = await dbAPI.GetUserByID(id);

            if (usuari != null)
            {
                test(usuari); 
            }
            else
            {
                MessageBox.Show("No se pudo cargar el usuario.");
            }
        }

        private void Bsortir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private async void bDesactivar_Click(object sender, EventArgs e)
        {

            string id = GestioSessins.id;
            if (!string.IsNullOrEmpty(id) && id != "0")
            {
                // Patch desactivate usuari by id
                string message = await dbAPI.DesactivateUsuari(id, GestioSessins.token);
                if (message == "correctament")
                {
                    Console.WriteLine("correctament: " + message);
                    using (Message messatge = new Message("Usuari desactivat correctament", "info"))
                    {
                        messatge.ShowDialog();

                    }
                    Sessio sessio = new Sessio(); 
                    sessio.Show();
                    
                }
                else
                {
                    Console.WriteLine("message: " + message);
                    using (Message messatge = new Message("Usuari desactivat", "error"))
                    {
                        messatge.ShowDialog();
                    }
                }
            }
        }

        private void Bcanvi_contrasenya_Click_1(object sender, EventArgs e)
        {
            CanviContrasenya canviContrasenya = new CanviContrasenya();
            canviContrasenya.Show();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
