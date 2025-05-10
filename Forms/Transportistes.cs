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
    /// <summary>
    /// Formulari Transportistes
    /// </summary>
    public partial class Transportistes : TitleForm
    {
        /// <summary>
        /// Propietat que representa el formulari obert.
        /// </summary>
        public TitleForm Open { get; set; } = null;

        /// <summary>
        /// Constructor del formulari Transportistes.
        /// </summary>
        public Transportistes()
        {
            InitializeComponent();
            LoadTransportistes();
        }

        /// <summary>
        /// Mètode que s'executa quan es tanca el formulari.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Open != null)
            {
                Open.Show();
            }
        }

        /// <summary>
        /// Mètode que retorna el DataGridView de transportistes.
        /// </summary>
        /// <returns></returns>
        public DataGridView GetDataGridViewT()
        {
            return dataGridViewT;
        }

        /// <summary>
        /// Mètode que carrega la llista de transportistes.
        /// </summary>
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
            dataGridViewT.Columns["IdVehicle"].Visible = false;
            dataGridViewT.Columns["Color"].Visible = false;
            dataGridViewT.Columns["Tipus"].Visible = false;
            dataGridViewT.Refresh();
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic a la cel·la del DataGridView de transportistes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewT.SelectedRows.Count > 0)
            {
                string TransID = dataGridViewT.SelectedRows[0].Cells["ID"].Value.ToString();
                Console.WriteLine("TransID: {TransID}");

                var response = await dbAPI.desactivarTransportista(TransID, GestioSessins.token);
                Console.WriteLine($"response: {response}");
                if (response.Contains("\"id\":"))
                {
                    using (Message msg = new Message("Transportista desactivat correctament.", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error durant la desactivacio.", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
                LoadTransportistes();
            }
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó de desactivar transportista.
        /// agafa la selecció del transportista seleccionat i el desactiva.
        /// Si no hi ha cap transportista seleccionat, mostra un missatge d'error.
        /// Si el transportista es desactiva correctament, mostra un missatge d'informació.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bDesactiveTrans_Click(object sender, EventArgs e)
        {
            if (dataGridViewT.SelectedRows.Count > 0)
            {
                string TransID = dataGridViewT.SelectedRows[0].Cells["ID"].Value.ToString();
                Console.WriteLine("TransID: {TransID}");
                var response = await dbAPI.desactivarTransportista(TransID, GestioSessins.token);
                Console.WriteLine($"response: {response}");
                if (response.Contains("\"correctament\":") || response != "0")
                {
                    using (Message msg = new Message("Transportista desactivat correctament.", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error durant la desactivacio.", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
                LoadTransportistes();
            }
            else
            {
                using (Message msg = new Message("No hi ha cap transportista seleccionat.", "error"))
                {
                    msg.ShowDialog();
                }
            }
        }

        //crearTransportista

        private void bCrearTrans_Click_1(object sender, EventArgs e)
        {
            

        }

        private void bModificarTrans_Click(object sender, EventArgs e)
        {

        }
    }


}
