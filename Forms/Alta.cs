using SmartPack.Classes;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartPack
{
    public partial class Alta : TitleForm
    {
        public Alta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.DoubleBuffered = true;
            Sessio sessio = new Sessio();
            sessio.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private async void bRegistre_Click(object sender, EventArgs e)
        {

            //dbAPI.GetPassword();
            string tnom = nom.Text.Trim();
            string tcognom_p = cognom_p.Text.Trim();
            string tcognom_s = cognom_s.Text.Trim();
            string tdni = dni_c.Text.Trim();
            string ttelefon = telephon.Text.Trim();
            string tt_via = t_via.Text.Trim();
            string tnum = num.Text.Trim();
            string tporta = porta.Text;
            string tplanta = planta.Text;
            string tnom_via = nom_via.Text;
            string tpoblacio = poblacio_t.Text;
            string tprovincia = provincia_t.Text;
            string tcp = cp.Text.Trim();
            string temail = email_t.Text.Trim();
            string tpassword = contrasenya_t.Text.Trim();
            string fpassword = r_contrasenya.Text.Trim();
            string tobservacions = observacions_t.Text;
            var trol = rol_c.Text;
            bool esEmpresa = si_t.Checked;
           // Message message = new Message("", "");


            if (string.IsNullOrWhiteSpace(tnom) || string.IsNullOrWhiteSpace(tcognom_p) ||
                string.IsNullOrWhiteSpace(tdni) || string.IsNullOrWhiteSpace(ttelefon) ||
                string.IsNullOrWhiteSpace(tt_via) || string.IsNullOrWhiteSpace(tnum) ||
                string.IsNullOrWhiteSpace(tnom_via) || string.IsNullOrWhiteSpace(tpoblacio) ||
                string.IsNullOrWhiteSpace(tprovincia) || string.IsNullOrWhiteSpace(tcp) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(tpassword) ||
                string.IsNullOrWhiteSpace(fpassword))
            {
                using (Message message1 = new Message("Revisa els camps són obligatoris", "error"))
                { 
                    message1.ShowDialog(); return; 
                }
                
            }

            if (!Regex.IsMatch(tnom, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                using (Message message1 = new Message("El nom només pot tenir lletres.", "error"))
                { 
                    message1.ShowDialog(); return;
                }
                
            }

            if (!Regex.IsMatch(tcognom_p, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                using (Message message1 = new Message("El cognom només pot tenir lletres", "error"))
                { 
                    message1.ShowDialog(); return; 
                }
                
            }
            if (!EsDniNieValido(tdni))
            {
                using (Message message1 = new Message("Format de DNI/NIE inválid. Ha de tenir entre 9 y 10 caràcters.", "error"))
                { 
                    message1.ShowDialog(); return; 
                }
                
            }
            if (!Regex.IsMatch(ttelefon, "^[0-9]{9,15}$"))
            {
                using (Message message1 = new Message("El telèfono ha de tenir només números i tenir entre 9 y 15 dígits", "error"))
                { 
                    message1.ShowDialog(); return;
                }
            }
            if (!Regex.IsMatch(tcp, "^[0-9]{5}$"))
            {
                using (Message message1 = new Message("Format de Códi Postal invàlid", "error")) 
                { 
                    message1.ShowDialog(); return; 
                }
               
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                using (Message message1 = new Message("Format Email invàlid ", "error")) 
                {
                    message1.ShowDialog();
                    return;
                }
                   
            }
            if (!ValidarContrasenya(tpassword))
            {
                using (Message message1 = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
            }

            if (tpassword != fpassword)
            {
                using (Message message1 = new Message("Les contrasenyes no coincideixen", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
                
            }

            if (esEmpresa)
            {
                AltaEmpresa formEmpresa = new AltaEmpresa();
                formEmpresa.Show();

                this.Hide();
            }

            // He canviat l'estil de la crida a la classe dbAPI, perque la meva companya ho ha fet d'aquesta manera
            object user = new
            {
                nom = tnom,
                cognom = tcognom_p + " "+ tcognom_s,
                //pcognom = tcognom_p,
                //scognom = tcognom_s,
                dni = tdni,
                telefon = ttelefon,
                adreça = tt_via + " " + tnom_via + " " + tnum + " " + tporta + " " + tplanta + " " + tpoblacio + " "+ tprovincia + " " + tcp,
                /*tvia = tt_via,
                nom_via = tnom_via,
                num = tnum,
                porta = tporta,
                planta = tplanta,
                poblacio = tpoblacio,
                provincia = tprovincia,
                cp = tcp,*/
                email = temail,
                password = tpassword,
                role = trol,
                observacio = tobservacions
            };
            var consulta = new
            {
                email = temail
            };

            string email = await dbAPI.ExecuteDB(consulta, "forgot-password");

            if (!string.IsNullOrEmpty(email))
            {
                using (Message msg = new Message("Usuari ja existeix", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            else
            {
                string reg = await dbAPI.ExecuteDB(user, "registrar");
                if (!string.IsNullOrEmpty(reg))
                {
                    using (Message msg = new Message("Usuari registrat correctament", "info"))
                    {
                        msg.ShowDialog();
                    }
                    Sessio sessio = new Sessio();
                    sessio.Show();
                    this.Hide();
                }
                else
                {
                    using (Message msg = new Message("Error durant el procès de registre", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
            } 
        }
        public static bool EsDniNieValido(string doc)
        {
            if (Regex.IsMatch(doc, @"^\d{8}[A-Za-z]{1}$"))
            {
                return true;
            }

            if (Regex.IsMatch(doc, @"^[XYZ]\d{7}[A-Za-z]{1}$"))
            {
                return true;
            }
            return false;
        }


        public static bool ValidarContrasenya(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rol_c.Text == "Transportista")
            {
                AltaVehicle formVehicle = new AltaVehicle();
                formVehicle.Show();

                this.Hide();
            }
        }
    }
}
