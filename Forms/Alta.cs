using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void bRegistre_Click(object sender, EventArgs e)
        {
            string tnom = nom.Text.Trim();
            string tcognom_p = cognom_p.Text.Trim();
            string tcognom_s = cognom_s.Text.Trim();
            string tdni = dni.Text.Trim();
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
            string tcontrasenya = contrasenya_t.Text.Trim();
            string fcontrasenya = r_contrasenya.Text.Trim();
            string tobservacions = observacions_t.Text;
            var trol = rol.Items;
            bool esEmpresa = si_t.Checked;
          

            if (string.IsNullOrWhiteSpace(tnom) || string.IsNullOrWhiteSpace(tcognom_p) ||
                string.IsNullOrWhiteSpace(tdni) || string.IsNullOrWhiteSpace(ttelefon) ||
                string.IsNullOrWhiteSpace(tt_via) || string.IsNullOrWhiteSpace(tnum) ||
                string.IsNullOrWhiteSpace(tnom_via) || string.IsNullOrWhiteSpace(tpoblacio) ||
                string.IsNullOrWhiteSpace(tprovincia) || string.IsNullOrWhiteSpace(tcp) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(tcontrasenya) ||
                string.IsNullOrWhiteSpace(fcontrasenya))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tnom, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                MessageBox.Show("El nombre solo puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tcognom_p, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                MessageBox.Show("El apellido solo puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EsDniNieValido(tdni))
            {
                MessageBox.Show("Formato de DNI/NIE inválido. Debe tener entre 9 y 10 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(ttelefon, "^[0-9]{9,15}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números y tener entre 9 y 15 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tcp, "^[0-9]{5}$"))
            {
                MessageBox.Show("Formato de Códi Postal inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                MessageBox.Show("Formato de correo electrónico inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tcontrasenya != fcontrasenya)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (esEmpresa)
            {
                AltaEmpresa formEmpresa = new AltaEmpresa();
                formEmpresa.Show();
            }

            Console.WriteLine("Nom: " + tnom);
            Console.WriteLine("Cognoms: " + tcognom_p);
            Console.WriteLine("tdni: " + tdni);
            Console.WriteLine("ttelefon: " + ttelefon);
            Console.WriteLine("tt_via: " + tt_via);
            Console.WriteLine("tporta: " + tporta);
            Console.WriteLine("tplanta: " + tplanta);
            Console.WriteLine("tnom_via: " + tnom_via);
            Console.WriteLine("tpoblacio: " + tpoblacio);
            Console.WriteLine("tprovincia: " + tprovincia);
            Console.WriteLine("tcp: " + tcp);
            Console.WriteLine("temail: " + temail);
            Console.WriteLine("tcontrasenya: " + tcontrasenya);
            Console.WriteLine("trol: " + trol);
            Console.WriteLine("tempresa: " + esEmpresa);

        }
        private bool EsDniNieValido(string doc)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";

            if (!Regex.IsMatch(doc, @"^([XYZ]|[XYZ][A-Z])?\d{7,8}[A-Za-z]$"))
                return false;

            string numeroStr = doc.Substring(0, doc.Length - 1); 
            char letraIngresada = char.ToUpper(doc[doc.Length - 1]);

            // Convertir NIE a número válido (X → 0, Y → 1, Z → 2)
            if (numeroStr[0] == 'X') numeroStr = "0" + numeroStr.Substring(1);
            else if (numeroStr[0] == 'Y') numeroStr = "1" + numeroStr.Substring(1);
            else if (numeroStr[0] == 'Z') numeroStr = "2" + numeroStr.Substring(1);

            int numero = int.Parse(numeroStr);
            char letraCalculada = letras[numero % 23];

            return letraCalculada == letraIngresada;
        }
    }
}
