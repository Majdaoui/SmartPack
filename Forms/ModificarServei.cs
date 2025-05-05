using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartPack.Forms
{
    /// <summary>
    /// Class Modificar Un Servei
    /// </summary>
    public partial class ModificarServei : TitleForm
    {
        /// <summary>
        /// Constructor de la classe ModificarServei
        /// </summary>
        public ModificarServei()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega el formulari i les dades del servei en el datagrid
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDB();
        }

        /// <summary>
        /// Al tancar el formulari, obre el formulari de Servei
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Servei servei = new Servei();
            servei.Show();
        }

        /// <summary>
        /// Carrega les dades del servei en el datagrid
        /// </summary>
        private async void LoadDB()
        {
            if (GestioSessins.role == "ROLE_DELIVERYMAN")
            {
                var list = await dbAPI.getServeiPerId(GestioSessins.id);
                if (list != null)
                {
                    List<VisualServei> viewModels = list.Select(s => new VisualServei
                    {
                        ID = s.id,
                        UsuariID = s.usuariId,
                        TransportistaID = s.transportistaId,
                        Estat = s.estat,
                        Detalls = s.paquet?.detalls,
                        Pes = s.paquet?.pes ?? 0,
                        Mida = s.paquet?.mida,
                        Destinatari = s.paquet?.nomDestinatari,
                        Adreça = s.paquet?.adreçadestinatari,
                        Telefon = s.paquet?.telefondestinatari
                    }).ToList();

                    dataGridView1.DataSource = viewModels;
                    dataGridView1.Columns["usuariId"].Visible = false;
                    dataGridView1.Columns["transportistaId"].Visible = false;
                    dataGridView1.Refresh();
                }
            }
            else if (GestioSessins.role == "ROLE_ADMIN")
            {
                var list = await dbAPI.getServeiLlist(GestioSessins.token);
                if (list != null)
                {
                    List<VisualServei> viewModels = list.Select(s => new VisualServei
                    {
                        ID = s.id,
                        UsuariID = s.usuariId,
                        TransportistaID = s.transportistaId,
                        Estat = s.estat,
                        Detalls = s.paquet?.detalls,
                        Pes = s.paquet?.pes ?? 0,
                        Mida = s.paquet?.mida,
                        Destinatari = s.paquet?.nomDestinatari,
                        Adreça = s.paquet?.adreçadestinatari,
                        Telefon = s.paquet?.telefondestinatari
                    }).ToList();
                    dataGridView1.DataSource = viewModels;
                    dataGridView1.Columns["usuariId"].Visible = false;
                    dataGridView1.Columns["transportistaId"].Visible = false;
                    dataGridView1.Refresh();
                }
            }
        }

        /// <summary>
        /// Carrega les dades del servei seleccionat en els camps de text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ID = row.Cells["ID"].Value.ToString();
                string UsuariID = row.Cells["usuariID"].Value.ToString();
                string TransportistaID = row.Cells["transportistaID"].Value.ToString();
                string Estat = row.Cells["Estat"].Value.ToString();
                string Detalls = row.Cells["Detalls"].Value.ToString();
                string Pes = row.Cells["Pes"].Value.ToString();
                string Destinatari = row.Cells["Destinatari"].Value.ToString();
                string Telefon = row.Cells["Telefon"].Value.ToString();
                string Mida = row.Cells["Mida"].Value.ToString();
                string Adreça = row.Cells["Adreça"].Value.ToString();
                if (Estat == "ENTREGAT" || Estat == "RETORNAT" || Estat == "ENVIAT")
                {
                    using (Message msg = new Message("No es pot modificar les dades d`aquest paquet.", "info"))
                    {
                        msg.ShowDialog();
                    }
                    return;
                }
                tbID.Text = ID;
                u_detall.Text = Detalls;
                u_pes.Text = Pes;
                u_codiQR.Text = "";
                if (Mida.Contains(","))
                {
                    var array = Mida.Split(',');
                    if (array.Length == 3)
                    {
                        u_altura.Text = array[0].Trim();
                        u_profunditat.Text = array[1].Trim();
                        u_amplada.Text = array[2].Trim();
                    }
                }
                u_nomDestinatari.Text = Destinatari;
                u_telefonDestinatari.Text = Telefon;
                if (Adreça.Contains(","))
                {
                    var array = Adreça.Split(',');
                    if (array.Length == 8)
                    {
                        u_tVia.Text = array[0].Trim();
                        u_nomVia.Text = array[1].Trim();
                        u_num.Text = array[2].Trim();
                        u_planta.Text = array[3].Trim();
                        u_porta.Text = array[4].Trim();
                        u_codipostal.Text = array[5].Trim();
                        u_poblacio.Text = array[6].Trim();
                        u_provincia.Text = array[7].Trim();
                    }
                }
            }
        }

        /// <summary>
        /// Actualitza les dades del servei seleccionat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void UpdateServei_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                string usuariId = fila.Cells["usuariId"].Value.ToString();
                string transportistaId = fila.Cells["transportistaId"].Value.ToString();
                var adreça = u_tVia.Text.Trim() + ", " + u_nomVia.Text.Trim() + ", " + 
                    u_num.Text.Trim() + ", " +
                    u_planta.Text.Trim() + ", " +
                    u_porta.Text.Trim() + ", " +
                    u_codipostal.Text.Trim() + ", " + u_poblacio.Text.Trim() + ", " +
                    u_provincia.Text.Trim();
                var update = new
                {
                    //estat = "ORDENAT",
                    usuariId = usuariId,
                    transportistaId = transportistaId,
                    paquet = new
                    {
                        detalls = u_detall.Text,
                        pes = u_pes.Text,
                        mida = (u_altura.Text + "," + u_profunditat.Text + "," + u_amplada.Text),
                        nomDestinatari = u_nomDestinatari.Text,
                        adreçadestinatari = adreça,
                        telefondestinatari = u_telefonDestinatari.Text,
                        codiqr = "123456789"
                    }
                };
                var r = await dbAPI.PutUpdateServeiPerId(update, tbID.Text, GestioSessins.token);
                LoadDB();
                if (r != null)
                {
                    using (Message msg = new Message("El servei s'ha actualitzat correctament.", "info"))
                    {
                        msg.ShowDialog();
                    }
                }
                else
                {
                    using (Message msg = new Message("Error al modificar el servei.", "error"))
                    {
                        msg.ShowDialog();
                    }
                }
            }
            else
            {
                using (Message msg = new Message("Si us plau selecciona el servei a modificar.", "error"))
                {
                    msg.ShowDialog();
                }
            }
        }
    }
}
