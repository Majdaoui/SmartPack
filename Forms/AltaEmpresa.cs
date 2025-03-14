﻿using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class AltaEmpresa : TitleForm
    {
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

        private void guardar_e_Click(object sender, System.EventArgs e)
        {
            string tcif = cif_e.Text;
            string tnom_e = nom_e.Text;
            string temail = email_e.Text;
            string ttef = tef_e.Text;
            string t_tvia = t_via_e.Text;
            string tnom_via = nom_via_e.Text;
            string t_cp = cp_e.Text;
            string tpoble = poblacio_e.Text;
            string tprovincia = provincia_e.Text;

            if (string.IsNullOrWhiteSpace(tcif) || string.IsNullOrWhiteSpace(tnom_e) ||
                string.IsNullOrWhiteSpace(temail) || string.IsNullOrWhiteSpace(ttef) ||
                string.IsNullOrWhiteSpace(t_tvia) || string.IsNullOrWhiteSpace(tnom_via) ||
                string.IsNullOrWhiteSpace(t_cp) || string.IsNullOrWhiteSpace(tpoble) ||
                string.IsNullOrWhiteSpace(tprovincia))
            {
                Message messatgel = new Message("Revisa els camps són obligatoris ", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("Tots els camps són obligatoris ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.IsMatch(tcif, "^[a-zA-Z0-9]+$"))
            {
                Message messatgel = new Message("El CIF/NIEF només pot tenir lletres i números. ", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("El CIF/NIEF només pot tenir lletres i números ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (ValidarIdentificacion(tcif))
            {
                Message messatgel = new Message("El CIF/NIEF no és vàlid, el seu format no és correcte. ", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("El CIF/NIEF no és vàlid, el seu format no és correcte ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(ttef, "^[0-9]{9,15}$"))
            {
                Message messatgel = new Message("El telèfon ha de tenir entres 9 i 15 dígits.", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("El telèfon ha de tenir entres 9 i 15 dígits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(t_cp, "^[0-9]{5}$"))
            {
                Message messatgel = new Message("El códi postal ha de tenir 5 dígits.", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("El códi postal ha de tenir 5 dñigits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(temail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                Message messatgel = new Message("El email no és vàlid ", "Error");
                messatgel.ShowDialog();
                //MessageBox.Show("El email no és vàlid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
        }
        public static bool ValidarIdentificacion(string doc)
        {
            if (string.IsNullOrEmpty(doc)) return false;
            doc = doc.ToUpper().Trim();
            return Regex.IsMatch(doc, @"^\d{8}[A-Z]$") ? ValidarNIF(doc) :
                    Regex.IsMatch(doc, @"^[XYZ]\d{7}[A-Z]$") ? ValidarNIF(TransformarNIE(doc)) :
                    Regex.IsMatch(doc, @"^[A-HJNP-SUVW]\d{7}[0-9A-J]$") ? ValidarCIF(doc) :
                    false;
        }

        private static bool ValidarNIF(string nif)
        {
            int numero = int.Parse(nif.Substring(0, 8));
            char lletraEsperada = "TRWAGMYFPDXBNJZSQVHLCKE"[numero % 23];
            return lletraEsperada == nif[8];
        }

        private static string TransformarNIE(string nie)
        {
            char primeraLletra = nie[0];
            string numero = nie.Substring(1, 7);
            return (primeraLletra == 'X' ? "0" : primeraLletra == 'Y' ? "1" : "2") + numero + nie[8];
        }

        private static bool ValidarCIF(string cif)
        {
            int suma = 0, factor = 2;
            for (int i = 1; i < 8; i++, factor = 3 - factor)
            {
                int valor = (cif[i] - '0') * factor;
                suma += valor % 10 + valor / 10;
            }
            char control = "JABCDEFGHI"[(10 - suma % 10) % 10];
            return char.IsDigit(cif[cif.Length - 1]) ? cif[cif.Length - 1] == control : cif[cif.Length - 1] == control;
        }
    }
}
