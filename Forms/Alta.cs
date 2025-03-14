using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
            string tcontrasenya = contrasenya_t.Text.Trim();
            string fcontrasenya = r_contrasenya.Text.Trim();
            string tobservacions = observacions_t.Text;
            var trol = rol.Items;
            bool esEmpresa = si_t.Checked;
            Message message = new Message("", "");


            if (string.IsNullOrWhiteSpace(tnom) || string.IsNullOrWhiteSpace(tcognom_p) ||
                string.IsNullOrWhiteSpace(tdni) || string.IsNullOrWhiteSpace(ttelefon) ||
                string.IsNullOrWhiteSpace(tt_via) || string.IsNullOrWhiteSpace(tnum) ||
                string.IsNullOrWhiteSpace(tnom_via) || string.IsNullOrWhiteSpace(tpoblacio) ||
                string.IsNullOrWhiteSpace(tprovincia) || string.IsNullOrWhiteSpace(tcp) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(tcontrasenya) ||
                string.IsNullOrWhiteSpace(fcontrasenya))
            {
                Message message1 = new Message("Revisa els camps són obligatoris", "error");
                message.ShowDialog();
                //MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tnom, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                Message message1 = new Message("El nom només pot tenir lletres.", "error");
                message.ShowDialog();
                //MessageBox.Show("El nombre solo puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tcognom_p, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$"))
            {
                Message message1 = new Message("El cognom només pot tenir lletres", "error");
                message.ShowDialog();
                //MessageBox.Show("El apellido solo puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsDniNieValido(tdni))
            {
                Message message1 = new Message("Format de DNI/NIE inválid. Ha de tenir entre 9 y 10 caràcters.", "error");
                message1.ShowDialog();
                //MessageBox.Show("Formato de DNI/NIE inválido. Debe tener entre 9 y 10 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(ttelefon, "^[0-9]{9,15}$"))
            {
                Message message1 = new Message("El telèfono ha de tenir només números i tenir entre 9 y 15 dígits", "error");
                message1.ShowDialog();
                //MessageBox.Show("El teléfono debe contener solo números y tener entre 9 y 15 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tcp, "^[0-9]{5}$"))
            {
                Message message1 = new Message("Format de Códi Postal invàlid", "error");
                message1.ShowDialog();
                //MessageBox.Show("Formato de Códi Postal inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(temail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidFormat)
            {
                Message message1 = new Message("Format Email invàlid ", "error");
                message1.ShowDialog();
               // MessageBox.Show("Formato de correo electrónico inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidarContrasenya(tcontrasenya))
            {
                Message message1 = new Message("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "error");
                message1.ShowDialog();
                //MessageBox.Show("La contrasenya ha de tenir almenys 8 caràcters, una lletra majúscula, un número i un caràcter especial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tcontrasenya != fcontrasenya)
            {
                Message message1 = new Message("Les contrasenyes no coincideixen", "error");
                message1.ShowDialog();
                //MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (esEmpresa)
            {
                AltaEmpresa formEmpresa = new AltaEmpresa();
                formEmpresa.Show();
            }
            if (rol.SelectedItem.ToString() == "Transportista")
            {
                AltaVehicle formVehicle = new AltaVehicle();
                formVehicle.Show();
            }

            var user = new
            {
                nom = tnom,
                pcognom = tcognom_p,
                scognom = tcognom_s,
                dni = tdni,
                telefon = ttelefon,
                tvia = tt_via,
                nom_via = tnom_via,
                num = tnum,
                porta = tporta,
                planta = tplanta,
                poblacio = tpoblacio,
                provincia = tprovincia,
                cp = tcp,
                email = temail,
                contrasenya = tcontrasenya
            };
            Message msg = new Message("Usuari registrat correctament", "info");
            msg.ShowDialog();
            //MessageBox.Show("Usuari registrat correctament", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private bool EsDniNieValido(string doc)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            if (!Regex.IsMatch(doc, @"^([XYZ]|[XYZ][A-Z])?\d{7,8}[A-Za-z]$")) return false;
            string numeroStr = doc.Substring(0, doc.Length - 1);
            char letraIngresada = char.ToUpper(doc[doc.Length - 1]);
            if (numeroStr[0] == 'X') numeroStr = "0" + numeroStr.Substring(1);
            else if (numeroStr[0] == 'Y') numeroStr = "1" + numeroStr.Substring(1);
            else if (numeroStr[0] == 'Z') numeroStr = "2" + numeroStr.Substring(1);
            int numero = int.Parse(numeroStr);
            char letraCalculada = letras[numero % 23];
            return letraCalculada == letraIngresada;
        }
        public static bool ValidarContrasenya(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya)) return false;
            return Regex.IsMatch(contrasenya, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
