using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Class ServeisFinalitzats
    /// </summary>
    public partial class ServeisFinalitzats : TitleForm
    {
        /// <summary>
        /// Constructor del formulari de serveis finalitzats
        /// </summary>
        public ServeisFinalitzats()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mètode que s'executa quan es tanca el formulari
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            var servei = new Servei();
            servei.Show();
        }

        /// <summary>
        /// Mètode que s'executa quan es carrega el formulari
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDB();
        }

        /// <summary>
        /// Carrega les dades del servei en el datagrid
        /// </summary>
        private async void LoadDB()
        {
            List<ClassServei> list = null;
            if (GestioSessins.role == "ROLE_DELIVERYMAN")
            {
                string response = await dbAPI.GetTransportistaPerUsuari(GestioSessins.id, GestioSessins.token);
                Console.WriteLine("Response Body vehicle: " + response);
                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    JsonElement root = doc.RootElement;
                    int id = root.GetProperty("id").GetInt32();
                    list = await dbAPI.getServeiTransportista(id.ToString());
                }
            }
            else if (GestioSessins.role == "ROLE_ADMIN")
            {
                list = await dbAPI.getServeiLlist(GestioSessins.token);
            }
            if (list != null)
            {
                List<VisualServei> viewModels = new List<VisualServei>();
                foreach (ClassServei servei in list)
                {
                    if (servei.estat == "ENTREGAT" || servei.estat == "NO_ENTREGAT" || servei.estat == "RETORNAT")
                    {
                        VisualServei vs = new VisualServei
                        {
                            ID = servei.id,
                            Estat = servei.estat,
                            Detalls = servei.paquet?.detalls,
                            Pes = servei.paquet?.pes ?? 0,
                            Mida = servei.paquet?.mida,
                            Destinatari = servei.paquet?.nomDestinatari,
                            Adreça = servei.paquet?.adreçadestinatari,
                            Telefon = servei.paquet?.telefondestinatari
                        };
                        viewModels.Add(vs);
                    }
                }
                dataGridView1.DataSource = viewModels;
                dataGridView1.Refresh();
            }
        }
    }
}
