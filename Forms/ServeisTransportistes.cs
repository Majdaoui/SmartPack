using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    public partial class ServeisTransportistes : TitleForm
    {
        public TitleForm Open { get; set; } = null;
        public ServeisTransportistes()
        {
            InitializeComponent();
            LoadServei();
            LoadTransportista();
        }

        private async void LoadServei()
        {
            if (GestioSessins.role == "ROLE_ADMIN")
            {
                List<ClassServei> list = await dbAPI.getServeiLlist(GestioSessins.token);
                List<VisualServei> listvs = new List<VisualServei>();
                foreach (ClassServei classServei in list)
                {
                    VisualServei vs = new VisualServei
                    {
                        ID = classServei.id,
                        Estat = classServei.estat,
                        Detalls = classServei.paquet?.detalls,
                        Pes = classServei.paquet?.pes ?? 0,
                        Mida = classServei.paquet?.mida,
                        Destinatari = classServei.paquet?.nomDestinatari,
                        Adreça = classServei.paquet?.adreçadestinatari,
                        Telefon = classServei.paquet?.telefondestinatari,
                        TransportistaID = classServei?.transportistaId,
                        UsuariID = classServei.usuariId
                    };
                    listvs.Add(vs);
                }
                dataGridViewServei.DataSource = listvs;
                dataGridViewServei.Refresh();
            }
        }

        private async void LoadTransportista()
        {
            if (GestioSessins.role == "ROLE_ADMIN")
            {
                List<Transportista> list = await dbAPI.getTransportisteslist(GestioSessins.token);
                List<TransportistaVisual> listvt = new List<TransportistaVisual>();
                foreach (Transportista transportista in list)
                {
                    TransportistaVisual vt = new TransportistaVisual
                    {
                        
                    };
                    listvt.Add(vt);
                }
                dataGridViewServei.DataSource = listvt;
                dataGridViewServei.Refresh();
            }
        }


        private void dataGridViewServei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
