using DataGridViewExample.Edicao;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Clientes);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.ClientesRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.clientesTableAdapter.SetAtivoQuery(clienteSelect.Id);
                    break;
                case 1:
                    frmEdicaoClientes editCliente = new frmEdicaoClientes();
                    editCliente.clienteRow = clienteSelect;
                    editCliente.ShowDialog();

                    this.clientesTableAdapter.Update(editCliente.clienteRow);
                    break;
            }

            this.clientesTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Clientes);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LixeiraCliente lixeiraCliente = new LixeiraCliente();
            lixeiraCliente.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Clientes);
        }
    }
}
