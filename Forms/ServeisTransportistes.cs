using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Classe ServeisTransportistes
    /// </summary>
    public partial class ServeisTransportistes : TitleForm
    {
        /// <summary>
        /// Formulari de ServeisTransportistes.
        /// </summary>
        public TitleForm Open { get; set; } = null;

        public ServeisTransportistes()
        {
            InitializeComponent();
            LoadServei();
            LoadTransportista();
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
        /// Mètode que carrega la llista de serveis.
        /// </summary>
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

        /// <summary>
        /// Mètode que carrega la llista de transportistes.
        /// </summary>
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
                        Email = transportista.usuariEmail,
                        Llicencia = transportista.llicencia,
                        Id = transportista.id,
                        Marca = transportista.vehicle?.marca,
                        Model = transportista.vehicle?.model,
                        Matricula = transportista.vehicle?.matricula,
                        Color = transportista.vehicle?.color,
                        Tipus = transportista.vehicle?.tipus

                    };
                    listvt.Add(vt);
                }

                dataGridViewTrans.DataSource = listvt;
                dataGridViewTrans.Columns["IdVehicle"].Visible = false;
                dataGridViewTrans.Columns["Color"].Visible = false;
                dataGridViewTrans.Columns["Tipus"].Visible = false;
                dataGridViewTrans.Refresh();
            }
        }


        private void dataGridViewServei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        /// <summary>
        /// Mètode que s'executa quan es fa clic al botó d'assignar servei a un transportista.
        /// Despres de fer clic, es comprova si hi ha un servei i un transportista seleccionats.
        /// Actualitza la base de dades assignant el servei al transportista seleccionat.
        /// Actualitza dataGridViewServei i dataGridViewTrans per mostrar els serveis i transportistes actualitzats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bAssignarServie_Click(object sender, EventArgs e)
        {
            if (dataGridViewServei.SelectedRows.Count > 0 && dataGridViewTrans.SelectedRows.Count > 0)
            {
                string ServeiID = dataGridViewServei.SelectedRows[0].Cells["ID"].Value.ToString();
                string TransID = dataGridViewTrans.SelectedRows[0].Cells["ID"].Value.ToString();
                Console.WriteLine($"ServeiID: {ServeiID}, TransID: {TransID}");
                var response = await dbAPI.assignarServeiTransportista(ServeiID, TransID, GestioSessins.token);
                Console.WriteLine($"response: {response}");
                if (response.Contains("\"id\":"))
                {
                    using (Message msg = new Message("Servei assignat correctament.", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error al assignar el servei.", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
                LoadServei();
                LoadTransportista();
            }
        }
    }
}
