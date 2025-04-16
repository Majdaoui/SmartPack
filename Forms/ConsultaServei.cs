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
    public partial class ConsultaServei : TitleForm
    {
        public ConsultaServei()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDB();

        }

        private bool justClosed = false;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (!justClosed)
            {
                var principal = new Principal();
                principal.Show();
            }
        }

        private async void LoadDB()
        {
            var list = await dbAPI.getServeiPerId(GestioSessins.id);
            if (list != null)
            {
                List<VisualServei> viewModels = list.Select(s => new VisualServei
                {
                    ID = s.id.ToString(),
                    Estat = s.estat,
                    Detalls = s.paquet?.detalls,
                    Pes = s.paquet?.pes ?? 0,
                    Mida = s.paquet?.mida,
                    Destinatari = s.paquet?.nomDestinatari,
                    Adreça = s.paquet?.adreçadestinatari,
                    Telefon = s.paquet?.telefondestinatari
                }).ToList();

                dataGridView1.DataSource = viewModels;
                dataGridView1.Refresh();
            }
        }

        private void bConsulta_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private async void bCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ID = selectedRow.Cells["ID"].Value.ToString();
                string Estat = selectedRow.Cells["Estat"].Value.ToString();
                string Detalls = selectedRow.Cells["Detalls"].Value.ToString();
                Console.WriteLine($"Estat: {Estat}, Detalls: {Detalls}");
                var r = await dbAPI.canviEstatServei(ID, cbEstado.Text, GestioSessins.token);
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string Estat = row.Cells["Estat"].Value.ToString();
                string Detalls = row.Cells["Detalls"].Value.ToString();
                Console.WriteLine($"Estat: {Estat}, Detalls: {Detalls}");
            }
        }

        /*
          "estat": "ORDENAT",
            "usuariId": 0,
            "transportistaId": 0,
            "paquet": {
              "id": 0,
              "detalls": "string",
              "pes": 0,
              "mida": "string",
              "nomDestinatari": "string",
              "adreçadestinatari": "string",
              "telefondestinatari": "string",
              "codiqr": "string"
         
         */

    }
}
