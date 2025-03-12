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
    }
}
