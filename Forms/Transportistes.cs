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
    public partial class Transportistes : TitleForm
    {
        public TitleForm Open { get; set; } = null;

        public Transportistes()
        {
            InitializeComponent();
            LoadTransportistes();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Open != null)
            {
                Open.Show();
            }
        }

        public DataGridView GetDataGridViewT()
        {
            return dataGridViewT;
        }

        public async void LoadTransportistes()
        {
            List<Transportista> list = await dbAPI.getTransportisteslist(GestioSessins.token);
            if (list == null)
            {
                using (Message message1 = new Message("No hi ha Transportistes", "error"))
                {
                    message1.ShowDialog();
                }

                dataGridViewT.DataSource = null;
                dataGridViewT.Refresh();
                return;
            }
            List<TransportistaVisual> listvs = new List<TransportistaVisual>();
            foreach (Transportista transportista in list)
            {
                TransportistaVisual vs = new TransportistaVisual
                {
                    Id = transportista.id,
                    Email = transportista.usuariEmail,
                    Llicencia = transportista.llicencia,
                    Marca = transportista.vehicle.marca,
                    Model = transportista.vehicle.model,
                    Matricula = transportista.vehicle.matricula,
                    Color = transportista.vehicle.color,
                    Tipus = transportista.vehicle.tipus
                };
                listvs.Add(vs);
            }

            dataGridViewT.DataSource = listvs;
            dataGridViewT.Refresh();
        }

        private void dataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
