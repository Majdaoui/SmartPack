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
            // Es tanca qualsevol sessió oberta per assegurar que l'usuari comença de nou
            // S'ha afegit aquesta línia per a que es tanqui la sessió abans de començar el procés de registre
            Sessio sessio = new Sessio();
            sessio.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        // Mètode que s'executa en fer clic al botó de registre
        // Aquest mètode recull les dades del formulari i les valida
        // Si les dades són correctes, es crida a la classe dbAPI per a registrar l'usuari a la base de dades
        // Si l'usuari ja existeix, es mostra un missatge d'error
        // Si l'usuari s'ha registrat correctament, es mostra un missatge d'informació i es redirigeix a la pàgina de login
        //He fet servir l'ajuda de copilot pels comentaris
        private async void bRegistre_Click(object sender, EventArgs e)
        {
            // Obtenir i netejar les dades dels camps del formulari
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

            // Validació de camps obligatoris
            // Si hi ha camps obligatoris buits, es mostra un missatge d'error
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

            // Validació de format de nom i cognom
            // El nom i cognom només poden contenir lletres
            // Si el format no és correcte, es mostra un missatge d'error
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
            // Validació de format de DNI/NIE
            // El DNI ha de tenir 8 dígits i una lletra
            // El NIE ha de començar per una lletra (X, Y o Z) seguida de 7 dígits i una lletra
            // Si el format no és correcte, es mostra un missatge d'error

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

            // Validació de format de Codi Postal
            // El Codi Postal ha de tenir 5 dígits
            // Si el format no és correcte, es mostra un missatge d'error
            if (!Regex.IsMatch(tcp, "^[0-9]{5}$"))
            {
                using (Message message1 = new Message("Format de Códi Postal invàlid", "error")) 
                { 
                    message1.ShowDialog(); return; 
                }
               
            }

            // Validació de format de email
            // Si el format no és correcte, es mostra un missatge d'error
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                using (Message message1 = new Message("Format Email invàlid ", "error")) 
                {
                    message1.ShowDialog();
                    return;
                }
                   
            }

            // Validació de contrasenya
            // La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial
            // Si la contrasenya no compleix els requisits, es mostra un missatge d'error
            if (!ValidarContrasenya(tpassword))
            {
                using (Message message1 = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
            }
            // Verificació que les contrasenyes coincideixen
            // Si les contrasenyes no coincideixen, es mostra un missatge d'error
            if (tpassword != fpassword)
            {
                using (Message message1 = new Message("Les contrasenyes no coincideixen", "error"))
                {
                    message1.ShowDialog();
                    return;
                }
                
            }

            // Mètode que gestiona la selecció de usuari com a empresa
            // Si es chequea la opció de empresa, es redirigeix al formulari d'alta d'empresa
            // i es tanca el formulari d'alta d'usuari
            // Si no es chequea la opció de empresa, no es fa res
            // Aquest mètode s'ha afegit per a la implementació de la funcionalitat de l'alta d'empresa
            if (esEmpresa)
            {
                using (AltaEmpresa formEmpresa = new AltaEmpresa())
                {
                    this.Close();
                    formEmpresa.ShowDialog();
                }
            }

            
            // Creem un objecte amb les dades de l'usuari
            // Aquest objecte es passarà com a paràmetre a la crida a la classe dbAPI
            // La crida a la classe dbAPI retorna un string amb el resultat de la crida
            // He canviat l'estil de la crida a la classe dbAPI, perque la meva companya ho ha fet d'aquesta manera
            object user = new
            {
                nom = tnom,
                cognom = tcognom_p + ", "+ tcognom_s,
                //pcognom = tcognom_p,
                //scognom = tcognom_s,
                dni = tdni,
                telefon = ttelefon,
                adreça = tt_via + ", " + tnom_via + ", " + tnum + ", " + tporta + ", " + tplanta + ", " + tpoblacio + ", " + tprovincia + ", " + tcp,
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

        // Mètode per validar el DNI/NIE
        // El DNI ha de tenir 8 dígits i una lletra
        // El NIE ha de començar per una lletra (X, Y o Z) seguida de 7 dígits i una lletra
        //He fet servir l'ajuda de copilot pels comentaris
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

        // Mètode per validar la contrasenya segons els requisits de seguretat
        // La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial
        //He fet servir l'ajuda de copilot pels comentaris

        public static bool ValidarContrasenya(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        // Mètode que gestiona la selecció del rol transportista
        // Si es selecciona el rol transportista, s'obre el formulari d'alta de vehicle
        // i es tanca el formulari d'alta d'usuari
        // Si es selecciona un altre rol, no es fa res
        // Aquest mètode s'ha afegit per a la implementació de la funcionalitat de l'alta de vehicle
        //He fet servir l'ajuda de copilot pels comentaris
        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rol_c.Text == "Transportista")
            {
                using (AltaVehicle formVehicle = new AltaVehicle())
                {
                    formVehicle.ShowDialog();
                    this.Hide();
                }
                this.Show();
            }
        }
    }
}
