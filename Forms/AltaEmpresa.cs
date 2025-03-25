using SmartPack.Forms;
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
        private void guardar_e_Click(object sender, System.EventArgs e)
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
            else if (ValidarIdentificacion(tcif))
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
            var empresa = new
            {
                cif = tcif,
                nom_empresa = tnom_e,
                email = temail,
                telefon = ttef,
                tvia = t_tvia,
                carrer = tnom_via,
                cp = t_cp,
                poblacio = tpoble,
                provincia = tprovincia
            };
            Message messatge = new Message("Empresa registrada correctament", "info");
            messatge.ShowDialog();
            AreaUsuari area = new AreaUsuari();
            area.Show();
            this.Hide();

        }

        //validar el CIF/NIE o dni 
        public static bool ValidarIdentificacion(string doc)
        {
            if (string.IsNullOrEmpty(doc)) return false;
            doc = doc.ToUpper().Trim();
            return Regex.IsMatch(doc, @"^\d{8}[A-Z]$") ? ValidarNIF(doc) :
                    Regex.IsMatch(doc, @"^[XYZ]\d{7}[A-Z]$") ? ValidarNIF(TransformarNIE(doc)) :
                    Regex.IsMatch(doc, @"^[A-HJNP-SUVW]\d{7}[0-9A-J]$") ? ValidarCIF(doc) :
                    false;
        }
        //validar el NIF
        private static bool ValidarNIF(string nif)
        {
            int numero = int.Parse(nif.Substring(0, 8));
            char lletraEsperada = "TRWAGMYFPDXBNJZSQVHLCKE"[numero % 23];
            return lletraEsperada == nif[8];
        }

        //Transformar el NIE a NIF
        // comprova si la primera lletra és X, Y o Z i la transforma a 0, 1 o 2 respectivamente
        // acaba amb la lletra de control
        private static string TransformarNIE(string nie)
        {
            char primeraLletra = nie[0];
            string numero = nie.Substring(1, 7);
            return (primeraLletra == 'X' ? "0" : primeraLletra == 'Y' ? "1" : "2") + numero + nie[8];
        }

        //validar el CIF 
        //El CIF ha de tenir 9 caracters i començar per una lletra i acabar per un número
        public static bool IsValidCIF(string cif)
        {
            var regex = new Regex(@"^[A-Z]\d{8}$");
            return regex.IsMatch(cif);
        }

        //Validar el CIF que tingui 9 caracters i que no estigui buit
        private static bool ValidarCIF(string cif)
        {
            if(string.IsNullOrEmpty(cif) || cif.Length < 9)
            {
                return false;
            }
            return IsValidCIF(cif);
        }

    }
}
