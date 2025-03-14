using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class AltaVehicle : TitleForm
    {
        public AltaVehicle()
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

        private void guardar_e_Click(object sender, EventArgs e)
        {
            string tmatricula = matricula_t.Text;
            string tmodel = model_t.Text;
            string tcolor = color_t.Text;
            string ttipus = tipus_t.Text;
            if (string.IsNullOrWhiteSpace(tmatricula) || string.IsNullOrWhiteSpace(tmodel)
                || string.IsNullOrWhiteSpace(tcolor) || string.IsNullOrWhiteSpace(ttipus))
            {
                Message message = new Message("Revisa els camps són obligatoris.", "Error");
                message.ShowDialog();
                //MessageBox.Show("Tots els camps són obligatoris ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EsMatriculaValida(tmatricula))
            {
                Message message = new Message("La matrícula no és vàlida. Format acceptat: '1234ABC', 'B1234AB' o 'BA1234AB'", "Error");
                message.ShowDialog();
                //MessageBox.Show("La matrícula no és vàlida. Format acceptat: '1234ABC', 'B1234AB' o 'BA1234AB'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tmodel, "^[a-zA-Z0-9]+$"))
            {
                Message message = new Message("El model només pot tenir lletres i números. ", "Error");
                message.ShowDialog();
                //MessageBox.Show("El model només pot tenir lletres i números ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(tcolor, "^[a-zA-Z]+$"))
            {
                Message message = new Message("El color només pot tenir lletres. ", "Error");
                message.ShowDialog();
                //MessageBox.Show("El color només pot tenir lletres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(ttipus, "^[a-zA-Z]+$"))
            {
                Message message = new Message("El tipus només pot tenir lletres ", "Error");
                message.ShowDialog();
                //MessageBox.Show("El tipus només pot tenir lletres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var vehicle = new
            {
                matricula = tmatricula,
                model = tmodel,
                color = tcolor,
                tipus = ttipus
            };
            Message msg = new Message("Vehicle registrat correctament", "info");
            msg.ShowDialog();
        }
        public static bool EsMatriculaValida(string tmatricula)
        {
            string matricula = tmatricula.Trim().ToUpper();
            string modernaPattern = @"^\d{4}[A-Z]{3}$";
            string antigaPattern = @"^[A-Z]{1,2}\d{4}[A-Z]{2}$";
            if (Regex.IsMatch(matricula, modernaPattern) || Regex.IsMatch(matricula, antigaPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
