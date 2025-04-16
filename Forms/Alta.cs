using SmartPack.Classes;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class Alta : TitleForm
    {
        /// <summary>
        /// Constructor de la classe Alta
        /// </summary>
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
        /// <summary>
        /// Mètode que s'executa quan es pinta el formulari 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        /// <summary>
        /// Mètode que s'executa en fer clic al botó de registre
        /// Aquest mètode recull les dades del formulari i les valida
        /// Si les dades són correctes, es crida a la classe dbAPI per a registrar l'usuari a la base de dades
        /// Si l'usuari ja existeix, es mostra un missatge d'error
        /// Si l'usuari s'ha registrat correctament, es mostra un missatge d'informació i es redirigeix a la pàgina de login
        /// He fet servir l'ajuda de copilot pels comentaris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
            string psecreta = Secret.Text.Trim();
            var trol = rol_c.Text;
            bool esEmpresa = si_t.Checked;
            string licencia = tbLlicencia.Text;
            // Message message = new Message("", "");

            
            // Validació de camps obligatoris
            // Si hi ha camps obligatoris buits, es mostra un missatge d'error
            if (string.IsNullOrWhiteSpace(tnom) || string.IsNullOrWhiteSpace(tcognom_p) ||
                string.IsNullOrWhiteSpace(tdni) || string.IsNullOrWhiteSpace(ttelefon) ||
                string.IsNullOrWhiteSpace(tt_via) || string.IsNullOrWhiteSpace(tnum) ||
                string.IsNullOrWhiteSpace(tnom_via) || string.IsNullOrWhiteSpace(tpoblacio) ||
                string.IsNullOrWhiteSpace(tprovincia) || string.IsNullOrWhiteSpace(tcp) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(tpassword) ||
                string.IsNullOrWhiteSpace(fpassword) || string.IsNullOrWhiteSpace(psecreta))
            {
                using (Message message1 = new Message("Revisa els camps són obligatoris", "error"))
                { 
                    message1.ShowDialog();
                    return; 
                }
            }


            if (trol == "ROLE_DELIVERYMAN")
            {
                if(string.IsNullOrWhiteSpace(licencia))
                {
                    using (Message message1 = new Message("Escriu el tipus de llicencia", "error"))
                    {
                        message1.ShowDialog(); 
                        return;
                    }
                }                
            }

            // Validació de format de nom i cognom
            // El nom i cognom només poden contenir lletres
            // Si el format no és correcte, es mostra un missatge d'error
            if (!EsNomOCognomValid(tnom))
            {
                using (Message message1 = new Message("El nom només pot tenir lletres.", "error"))
                { 
                    message1.ShowDialog(); return;
                }
            }

            if (!EsNomOCognomValid(tcognom_p))
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

            if (!EsCodiPostalValid(ttelefon))
            {
                using (Message message1 = new Message("El telèfono ha de tenir només números i tenir entre 9 y 15 dígits", "error"))
                { 
                    message1.ShowDialog(); return;
                }
            }

            // Validació de format de Codi Postal
            // El Codi Postal ha de tenir 5 dígits
            // Si el format no és correcte, es mostra un missatge d'error
            if (!EsCodiPostalValid(tcp))
            {
                using (Message message1 = new Message("Format de Códi Postal invàlid", "error")) 
                { 
                    message1.ShowDialog(); return; 
                }
            }

            // Validació de format de email
            // Si el format no és correcte, es mostra un missatge d'error
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!EsEmailValid(temail))
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
            
            // Creem un objecte amb les dades de l'usuari
            // Aquest objecte es passarà com a paràmetre a la crida a la classe dbAPI
            // La crida a la classe dbAPI retorna un string amb el resultat de la crida
            // He canviat l'estil de la crida a la classe dbAPI, perque la meva companya ho ha fet d'aquesta manera
            object user = new
            {
                email = temail,
                password = tpassword,
                role = trol,
                nom = tnom,
                cognom = tcognom_p + ", "+ tcognom_s,
                telefon = ttelefon,
                adreça = tt_via + ", " + tnom_via + ", " + tnum + ", " + tplanta + ", " + tporta + ", " + tcp + ", " + tpoblacio + ", " + tprovincia,
                observacio = tobservacions,
                secret = psecreta.ToUpper()
            };


            await createNewUser(user, trol, licencia, esEmpresa);
            
        }

        public async Task createNewUser(object user_account, string role, string licencia, bool is_empresa = false)
        {
            if (user_account == null) return;
            string description_id = await dbAPI.altaUser(user_account);
            if (description_id.Contains("duplicats"))
            {
                Console.WriteLine("existeix: " + description_id);
                using (Message msg = new Message("Usuari ja existeix", "error"))
                {
                    msg.ShowDialog();
                    return;
                }
            }
            else
            {
                Console.WriteLine("id: " + description_id);
                GestioSessins.usuariId = description_id;
                GestioSessins.email = user_account.GetType().GetProperty("email")?.GetValue(user_account).ToString();
                GestioSessins.password = user_account.GetType().GetProperty("password")?.GetValue(user_account).ToString();

                if (string.IsNullOrEmpty(GestioSessins.usuariId) || GestioSessins.usuariId != "0")
                {
                    using (Message msg = new Message("Usuari registrat correctament", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error durant el procès de registre", "error"))
                    {
                        msg.ShowDialog();
                    }
                    return;
                }

                // Mètode que gestiona la selecció de usuari com a empresa
                // Si es chequea la opció de empresa, es redirigeix al formulari d'alta d'empresa
                // i es tanca el formulari d'alta d'usuari
                // Si no es chequea la opció de empresa, no es fa res
                // Aquest mètode s'ha afegit per a la implementació de la funcionalitat de l'alta d'empresa
                if (is_empresa)
                {
                    AltaEmpresa altaEmpresa = new AltaEmpresa();
                    altaEmpresa.Show();
                    this.Close();
                    return;
                }

                if (role == "ROLE_DELIVERYMAN")
                {
                    object user = new
                    {
                        email = GestioSessins.email,
                        password = GestioSessins.password,
                    };
                    bool state = await dbAPI.Login(user);
                    if (!string.IsNullOrEmpty(GestioSessins.token) && GestioSessins.token != "0")
                    {
                        object transportista = new
                        {
                            usuariId = description_id,
                            llicencia = licencia
                        };
                        string s = await dbAPI.crearTransportista(transportista, GestioSessins.token);
                        if (!string.IsNullOrEmpty(s))
                        {
                            AltaVehicle vehicle = new AltaVehicle();
                            vehicle.Show();
                            this.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Mètode per validar el format del Codi Postal
        /// </summary>
        /// <param name="cp"></param>
        /// <returns></returns>
        public static bool EsCodiPostalValid(string cp)
        {
            return Regex.IsMatch(cp, "^[0-9]{5}$");
        }

        /// <summary>
        /// Mètode per validar el format de l'email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool EsEmailValid(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }


        /// <summary>
        /// Mètode per validar el DNI/NIE
        /// El DNI ha de tenir 8 dígits i una lletra
        /// El NIE ha de començar per una lletra (X, Y o Z) seguida de 7 dígits i una lletra
        /// He fet servir l'ajuda de copilot pels comentaris
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>

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


        /// <summary>
        /// Mètode per validar la contrasenya
        /// Mètode per validar la contrasenya segons els requisits de seguretat
        /// La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial
        /// He fet servir l'ajuda de copilot pels comentaris
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidarContrasenya(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        /// <summary>
        /// Mètode que gestiona la selecció del rol transportista
        /// Si es selecciona el rol transportista, s'obre el formulari d'alta de vehicle
        /// i es tanca el formulari d'alta d'usuari
        /// Si es selecciona un altre rol, no es fa res
        /// Aquest mètode s'ha afegit per a la implementació de la funcionalitat de l'alta de vehicle
        /// He fet servir l'ajuda de copilot pels comentaris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rol_c.Text == "ROLE_DELIVERYMAN")
            {
                labelLlicencia.Visible = true;
                tbLlicencia.Visible = true;
            }
            else
            {
                labelLlicencia.Visible = false;
                tbLlicencia.Visible = false;
            } 

        }

        /// <summary>
        /// Mètode ompleix els camps del formulari d'alta d'usuari amb dades de test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            nom.Text = "Luna";
            cognom_p.Text = "Majdaoui";
            cognom_s.Text = "El Hammoudi";
            dni_c.Text = "49459155R";
            telephon.Text = "603207702";
            t_via.Text = "Carrer";
            num.Text = "146";
            porta.Text = "";
            planta.Text = "";
            nom_via.Text = "Dom Bosco";
            poblacio_t.Text = "Terrassa";
            provincia_t.Text = "Barcelona";
            cp.Text = "08224";
            email_t.Text = "eyesight_vista@msn.com";
            contrasenya_t.Text = "Luna*1234";
            r_contrasenya.Text = "Luna*1234";
            observacions_t.Text = "Test";
            Secret.Text = "Luna";
            rol_c.Text = "ROLE_ADMIN";
        }

        /// <summary>
        /// Mètode per validar el format del telèfon
        /// </summary>
        /// <param name="telefon"></param>
        /// <returns></returns>
        public static bool EsTelefonValid(string telefon)
        {
            return Regex.IsMatch(telefon, "^[0-9]{9,15}$");
        }

        /// <summary>
        /// Metode per validar si un text és nom i cognoms vàlid.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool EsNomOCognomValid(string text)
        {
            return Regex.IsMatch(text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$");
        }
    }
}
