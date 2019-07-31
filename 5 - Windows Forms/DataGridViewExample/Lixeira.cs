using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.GetAllData(this.parteFinalLocadoraTSQLDataSet1.DataTable1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //((System.Windows.Forms.DataGridViewRow)((((System.Windows.Forms.DataGridView)sender).Rows).Items[0])).DataBoundItem
            var lixeiraGlobal = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.DataTable1Row;

            switch (lixeiraGlobal.Tabela)
            {
                case "carros":
                    this.carrosTableAdapter1.Recuperar(lixeiraGlobal.Id);
                    break;
                case "clientes":
                    this.clientesTableAdapter1.Recuperar(lixeiraGlobal.Id);
                    break;
                case "usuarios":
                    this.usuariosTableAdapter1.Recuperar(lixeiraGlobal.Id);
                    break;
            }

            this.dataTable1TableAdapter.GetAllData(this.parteFinalLocadoraTSQLDataSet1.DataTable1);
        }
    }
}
