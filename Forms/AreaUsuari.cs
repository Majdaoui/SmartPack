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
            nom_usuari.Text = ClassUsuari.nom;
            usuari.separarCognom();
            cognom_p_usuari.Text = ClassUsuari.pcognom;
            dni_usuari.Text = ClassUsuari.dni;
            telefon_usuari.Text = ClassUsuari.telefon;
            email_usuari.Text = ClassUsuari.email;
            usuari.SepararDireccio();
            t_via_usuari.Text = ClassUsuari.tvia;
            num_usuari.Text = ClassUsuari.num;
            porta_usuari.Text = ClassUsuari.porta;
            planta_usuari.Text = ClassUsuari.planta;
            nom_via_usuari.Text = ClassUsuari.nom_via;
            poblacio_usuari.Text = ClassUsuari.poblacio;
            provincia_usuari.Text = ClassUsuari.provincia;
            cp_usuari.Text = ClassUsuari.cp;
            observacions_usuari.Text = ClassUsuari.observacions;
            Rol_Usuari.Text = ClassUsuari.rol;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string id = await dbAPI.getCurrentUser(GestioSessins.token);
            ClassUsuari usuari = await dbAPI.GetUserByID(id);

            if (usuari != null)
            {
                test(usuari); // Pasamos el usuario al método test()
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
                    using (Sessio sessio = new Sessio())
                    {
                        sessio.ShowDialog();
                    }
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
            using (CanviContrasenya canviContrasenya = new CanviContrasenya())
            {
                this.Hide();
                canviContrasenya.ShowDialog();
            }
            this.Show();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
