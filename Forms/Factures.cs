using SmartPack.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartPack.Forms
{
    /// <summary>
    /// Formulari factures
    /// 
    /// </summary>
    public partial class Factures : TitleForm
    {
        /// <summary>
        /// Constructor del formulari de factures i carrega les factures en el datagridview
        /// </summary>
        public Factures()
        {
            InitializeComponent();
            LoadFactures();
        }

        /// <summary>
        /// Al tancar el formulari, obre el formulari de principal
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Principal principal = new Principal();
            principal.Show();
        }

        /// <summary>
        /// Carrega les factures del servei i les mostra en el datagridview
        /// </summary>
        public async void LoadFactures()
        {
            if (GestioSessins.role == "ROLE_DELIVERYMAN" || GestioSessins.role == "ROLE_USER")
            {
                List<Factura> list = await dbAPI.getFactures(GestioSessins.id);
                List<VisualFactura> listvs = new List<VisualFactura>();
                foreach (Factura factura in list)
                {
                    VisualFactura vs = new VisualFactura()
                    {
                        Id = factura.id,
                        Numero = factura.numFactura,
                        Preu = factura.preu.ToString(),
                        IVA = factura.iva.ToString(),
                        Data = factura.data.ToString(),
                        Servei = factura.serveiId,
                        Usuari = factura.usuariId,
                        Pagat = factura.pagat,
                        Metode = factura.metodePagament
                    };
                    
                    listvs.Add(vs);
                }

                dataGridView1.DataSource = listvs;
                dataGridView1.Refresh();
            }
        }


        /// <summary>
        /// Paga la factura seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bPagarFactura_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ID = selectedRow.Cells["Id"].Value.ToString();
                var responseBody = await dbAPI.facturaPagar(ID, GestioSessins.token);
                if (responseBody.Contains("marcada"))
                {
                    MessageBox.Show("La factura ja està marcada com a pagada");
                    LoadFactures();
                }
                else if (responseBody.Contains("pagada"))
                {
                    MessageBox.Show("Factura pagada correctament");
                    LoadFactures();
                }
                else
                {
                    MessageBox.Show("Error al pagar la factura");
                }
            }
        }


        /// <summary>
        /// Selecciona la fila del datagridview i agafa l'ID de la factura seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ID = row.Cells["id"].Value.ToString();
                Factura factura = new Factura
                {
                    /*
                    Codi = row.Cells["id"].Value.ToString(),
                    TotalSenseIVA ="",
                    Preu = "",
                    Data = "",
                    Numero = "",
                    IVA = "",
                    Descripcio = "",
                    TotalAmbIVA = "",
                    DadesClient = "",
                    */
                };
                //Facturacio vistaFactura = new Facturacio(factura);
            }
        }
    }
}
