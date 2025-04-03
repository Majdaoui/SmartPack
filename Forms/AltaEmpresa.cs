using SmartPack.Classes;
using SmartPack.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPack
{
    // Formulari per a l'alta d'una empresa
    public partial class AltaEmpresa : TitleForm
    {
        // Constructor
        public AltaEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        // Mètode que s'executa en fer clic al botó de guardar
        // Guarda les dades de l'empresa
        // Si alguna dada no és correcta, mostra un missatge d'error
        // Si totes les dades són correctes, mostra un missatge d'informació i redirigeix a l'usuari a l'AreaUsuari
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
                using (Message messatgel = new Message("El CIF/NIEF només pot tenir lletres i números. ", "Error"))
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
            if (!Regex.IsMatch(ttef, "^[0-9]{9,15}$"))
            {
                using (Message messatgel = new Message("El telèfon ha de tenir entres 9 i 15 dígits.", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }
            // Comprovar que el codi postal sigui vàlid ha de tener 5 dígits
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!Regex.IsMatch(t_cp, "^[0-9]{5}$"))
            {
                using (Message messatgel = new Message("El códi postal ha de tenir 5 dígits.", "Error"))
                {
                    messatgel.ShowDialog();
                }
                return;
            }
            // Comprovar que l'email sigui vàlid comprova que tingui un format vàlid com ha minim ha de tenir un @ i un punt
            // Si alguna dada no és correcta, mostra un missatge d'error
            if (!Regex.IsMatch(temail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
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
                adreça = t_tvia +", "+ tnom_via + ", " + t_cp + ", " + tpoble + ", " + tprovincia
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
            else if (GestioSessins.token != "0")
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
                    if (message == "correctament")
                    {
                        Console.WriteLine("Empresa Message: " + message);
                    }
                    else
                    {
                        Console.WriteLine("No: " + message);
                    }
                }
            }




            /*
            string description_id = await dbAPI.CreateEmpresa(empresa, GestioSessins.token);
            if (description_id.Contains("duplicats"))
            {
                Console.WriteLine("existeix: " + description_id);
                using (Message msg = new Message("empresa ja existeix", "error"))
                {
                    this.Hide();
                    msg.ShowDialog();
                    return;
                }
            }
            else
            {
                Console.WriteLine("id: " + description_id);
                using (Message ms = new Message("Empresa registrada correctament", "info"))
                {
                    ms.ShowDialog();
                    using (Principal principal = new Principal())
                    {
                        this.Close();
                        principal.ShowDialog();
                    }
                }
            }*/
        }

        //Mètode que verifica l'entrada d'uari si el format es correcta
        //comprova si és un NIF, DNI o NIE
        // Si no te un format correcte dona un messatge d'error
        public static bool ValidarIdentificacion(string doc)
        {
            if (string.IsNullOrEmpty(doc)) return false;
            doc = doc.ToUpper().Trim();
            if (Regex.IsMatch(doc, @"^\d{8}[a-zA-Z]$"))
            {
                return true;
            }
            else if (Regex.IsMatch(doc, @"^\d{8}[a-zA-Z]$"))
            {
                return true;
            }
            // Validar NIE (format: lletra + 7 números + lletra)
            else if (Regex.IsMatch(doc, @"^[XYZ]\d{7}[a-zA-Z]$"))
            {
                return true;
            }
            return false;
        }

        private static bool ValidarDNI(string dni)
        {
            int numero = int.Parse(dni.Substring(0, 8));
            char lletraEsperada = "TRWAGMYFPDXBNJZSQVHLCKE"[numero % 23];
            return lletraEsperada == dni[8];
        }

        private static bool ValidarNIF(string nif)
        {
            return ValidarDNI(nif);
        }

        
        private static bool ValidarNIE(string nie)
        {
            var regexNIE = new Regex(@"^[XYZ]\d{7}[A-Z]$");
            return regexNIE.IsMatch(nie);
        }
    }
}
