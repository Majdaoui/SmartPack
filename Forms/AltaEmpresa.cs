using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPack
{
    /// <summary>
    /// Classe AltaEmpresa
    /// </summary>
    public partial class AltaEmpresa : TitleForm
    {
        public int Option { get; set; } = 0;

        /// <summary>
        /// Constructor de la classe AltaEmpresa
        /// </summary>
        public AltaEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }


        /// <summary>
        /// Mètode que dibuixa la barra superio en el formulari
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        /// <summary>
        /// Mètode que s'executa en fer clic al botó de guardar
        /// Guarda les dades de l'empresa
        /// Si alguna dada no és correcta, mostra un missatge d'error
        /// Si totes les dades són correctes, mostra un missatge d'informació i redirigeix a l'usuari a l'AreaUsuari
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void guardar_e_Click(object sender, System.EventArgs e)
        {
            // Obtenir i netejar les dades dels camps del formulari
            string tcif = cif_e.Text;
            string tnom_e = nom_e.Text;
            string temail = email_e.Text;
            string ttef = tef_e.Text;
            string t_tvia = t_via_e.Text;
            string tnom_via = nom_via_e.Text;
            string t_cp = cp_e.Text;
            string tpoble = poblacio_e.Text;
            string tprovincia = provincia_e.Text;

            // Comprovar que els camps obligatoris no estiguin buits
            // Si ho estan, mostra un missatge d'error
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (string.IsNullOrWhiteSpace(tcif) || string.IsNullOrWhiteSpace(tnom_e) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(ttef) ||
                string.IsNullOrWhiteSpace(t_tvia) || string.IsNullOrWhiteSpace(tnom_via) ||
                string.IsNullOrWhiteSpace(t_cp) || string.IsNullOrWhiteSpace(tpoble) ||
                string.IsNullOrWhiteSpace(tprovincia))
            {
                using (Message messatgel = new Message("Revisa els camps són obligatoris ", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }

            // Comprovar que el CIF siguin correctes
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!Regex.IsMatch(tcif, "^[a-zA-Z0-9]+$"))
            {
                using (Message messatgel = new Message("El CIF/NIF només pot tenir lletres i números. ", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }

            // Comprovar que el CIF/NIEF siguin vàlids ha de tener 9 dígits
            // Si alguna dada no és correcta, mostra un missatge d'error
            else if (!ValidarIdentificacion(tcif))
            {
                using (Message messatgel = new Message("El CIF/NIEF no és vàlid, el seu format no és correcte. ", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }

            // Comprovar que el telèfon sigui vàlid ha de tener entre 9 i 15 dígits
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!ValidarTelefon(ttef))
            {
                using (Message messatgel = new Message("El telèfon ha de tenir entres 9 i 15 dígits.", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }
            // Comprovar que el codi postal sigui vàlid ha de tener 5 dígits
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!ValidarCodiPostal(t_cp))
            {
                using (Message messatgel = new Message("El códi postal ha de tenir 5 dígits.", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }
            // Comprovar que l'email sigui vàlid comprova que tingui un format vàlid com ha minim ha de tenir un @ i un punt
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!ValidarEmail(temail))
            {
                using (Message messatgel = new Message("El email no és vàlid ", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }
            // Guardar les dades de l'empresa
            // Mostrar un missatge d'informació
            // Redirigir a l'usuari a l'AreaUsuari
            // Si alguna dada no és correcta, mostra un missatge d'error
            var empresa = new
            {
                email = temail,
                nif = tcif,
                nom = tnom_e,
                telefon = ttef,
                adreça = t_tvia + ", " + tnom_via + ", " + t_cp + ", " + tpoble + ", " + tprovincia
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
                string response = await dbAPI.CreateEmpresa(empresa, GestioSessins.token);
                if (!string.IsNullOrEmpty(GestioSessins.empresaId) && GestioSessins.empresaId != "0")
                {
                    Console.WriteLine("Response Body: " + GestioSessins.empresaId);
                    object assignar = new
                    {
                        usuariId = GestioSessins.usuariId,
                        empresaId = GestioSessins.empresaId,
                    };
                    string message = await dbAPI.assignarUsuari(assignar, GestioSessins.token);
                    if (message.Contains("correctament"))
                    {
                        Console.WriteLine("Empresa Message: " + message);
                        using (Message messatgel = new Message("empresa registrada correctament", "info"))
                        {
                            messatgel.ShowDialog();
                        }

                        if (Option == 0)
                        {
                            Sessio sessio = new Sessio();
                            sessio.Show();
                            this.Close();
                        }
                        else if (Option == 1)
                        {
                            Administracio administracio = new Administracio();
                            administracio.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No: " + message);
                    }
                }
            }
        }


        /// <summary>
        /// Mètode que valida el NIF, DNI o NIE
        /// Mètode que verifica l'entrada d'uari si el format es correcta
        /// Si no te un format correcte dona un messatge d'error
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static bool ValidarIdentificacion(string doc)
        {
            if (string.IsNullOrEmpty(doc)) return false;

            doc = doc.ToUpper().Trim();

            // DNI: 8 digits + lletra
            if (Regex.IsMatch(doc, @"^\d{8}[A-Z]$"))
            {
                return true;
            }

            // NIE: X, Y o Z + 7 digits + lletra
            if (Regex.IsMatch(doc, @"^[XYZ]\d{7}[A-Z]$"))
            {
                return true;
            }

            // NIF empresa: Lletra (A-H, J-N, P-S, U-W) + 7 digits + control (lletra o número)
            if (Regex.IsMatch(doc, @"^[A-HJ-NP-SUVW]\d{7}[A-Z0-9]$"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Mètode que valida el codi postal
        /// </summary>
        /// <param name="codiPostal"></param>
        /// <returns></returns>
        public static bool ValidarCodiPostal(string codiPostal)
        {
            var regexCodiPostal = new Regex(@"^\d{5}$");
            return regexCodiPostal.IsMatch(codiPostal);
        }


        /// <summary>
        /// Mètode que valida el telèfon
        /// </summary>
        /// <param name="telefon"></param>
        /// <returns></returns>
        public static bool ValidarTelefon(string telefon)
        {
            var regexTelefon = new Regex(@"^\d{9,15}$");
            return regexTelefon.IsMatch(telefon);
        }

        /// <summary>
        /// Mètode que validar l'email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidarEmail(string email)
        {
            var regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return regexEmail.IsMatch(email);
        }

        private void bAuto_Click(object sender, EventArgs e)
        {
            cif_e.Text = "A12345678";
            nom_e.Text = "Luna";
            email_e.Text = "luna@luna.com";
            tef_e.Text = "603207702";
            t_via_e.Text = "Carrer";
            nom_via_e.Text = "Dom Bosco";
            cp_e.Text = "08224";
            poblacio_e.Text = "Terrassa";
            provincia_e.Text = "Barcelona";
            porta_e.Text = "2";
            planta_e.Text = "2";
            num_e.Text = "146";
        }
    }
}
