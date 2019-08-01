using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2.Lixeiras
{
    public partial class frmLixeiraVenda : Form
    {
        public frmLixeiraVenda()
        {
            InitializeComponent();
        }

        private void FrmLixeiraVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendaSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.vendasTableAdapter.Restaurar(vendaSelect.Id);
                    break;
            }

            this.vendasTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Vendas);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
