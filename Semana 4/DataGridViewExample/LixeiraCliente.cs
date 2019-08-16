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
    public partial class LixeiraCliente : Form
    {
        public LixeiraCliente()
        {
            InitializeComponent();
        }

        private void LixeiraCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.SelectInativo(this.parteFinalLocadoraTSQLDataSet1.Clientes);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.ClientesRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.clientesTableAdapter.Recuperar(clienteSelect.Id);
                    break;
            }

            this.clientesTableAdapter.SelectInativo(this.parteFinalLocadoraTSQLDataSet1.Clientes);
        }
    }
}
