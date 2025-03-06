using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack
{
    public partial class Form_alta: Form
    {
        public Form_alta()
        {
            InitializeComponent();
        }

        private void bRegistre_Click(object sender, EventArgs e)
        {
            var tnom = nom.Text;
            var tcognoms = cognoms.Text;
            var tdni = dni.Text;
            var ttelefon = telephon.Text;
            var tt_via = t_via.Text;
            var tnum = num.Text;
            var tporta = porta.Text;
            var tplanta = planta.Text;
            var tnom_via = nom_via.Text;
            var tpoblacio = poblacio.Text;
            var tprovincia = provincia.Text;
            var tcp = cp.Text;
            var temail = email.Text;
            var tcontrasenya = contrasenya.Text;
            var trol = rol.Items;
            var tempresa = si.Checked;
           
            if(tempresa == false)
            {
                tempresa = no.Checked;
            }
            Console.WriteLine("Nom: " + tnom);
            Console.WriteLine("Cognoms: " + tcognoms);
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
            Console.WriteLine("tempresa: " + tempresa);

        }
    }
}
