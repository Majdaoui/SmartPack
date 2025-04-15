using SmartPack.Forms;
using System;
using System.Windows.Forms;

namespace SmartPack
{
    /// <summary>
    /// ApplicationContext that closes when the last form is closed.
    /// </summary>
    public class LastFormClosingApplicationContext : ApplicationContext
    {
        /// <summary>
        /// Initializes a new instance of the LastFormClosingApplicationContext class with the specified main form.
        /// </summary>
        /// <param name="mainForm"></param>
        public LastFormClosingApplicationContext(Form mainForm) : base(mainForm) { }

        /// <summary>
        /// Handles the MainForm's Closed event to check if there are any other open forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


    /// <summary>
    /// Main entry point for the application.
    /// </summary>
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
