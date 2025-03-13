using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SmartPack
{
    public partial class AltaVehicle: TitleForm
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
            if(string.IsNullOrWhiteSpace(tmatricula) || string.IsNullOrWhiteSpace(tmodel)
                || string.IsNullOrWhiteSpace(tcolor) || string.IsNullOrWhiteSpace(ttipus))
            {
                MessageBox.Show("Tots els camps són obligatoris ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tmatricula, "^[0-9]{4}[A-Z]{3}$"))
            {
                MessageBox.Show("La matrícula ha de tenir 4 números i 3 lletres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tmodel, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El model només pot tenir lletres i números ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(tcolor, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("El color només pot tenir lletres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(ttipus, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("El tipus només pot tenir lletres ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
