using SmartPack.Forms;
using System;
using System.Windows.Forms;

namespace SmartPack
{
    public class LastFormClosingApplicationContext : ApplicationContext
    {
        public LastFormClosingApplicationContext(Form mainForm) : base(mainForm) { }
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                var form = Application.OpenForms[i];
                if (form != MainForm)
                {
                    MainForm = form;
                    return;
                }
            }
            base.OnMainFormClosed(sender, e);
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LastFormClosingApplicationContext(new Sessio())); //Sessio
        }
    }
}
