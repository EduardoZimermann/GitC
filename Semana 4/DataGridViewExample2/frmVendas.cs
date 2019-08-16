using DataGridViewExample2.Edicao;
using DataGridViewExample2.Lixeiras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendaSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.vendasTableAdapter.DeleteQuery(vendaSelect.Id);
                    break;
                case 1:
                    frmEdicaoVendas editVendas = new frmEdicaoVendas();
                    editVendas.vendasRow = vendaSelect;
                    editVendas.ShowDialog();

                    this.vendasTableAdapter.Update(editVendas.vendasRow);
                    break;
            }

            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmLixeiraVenda lixeiraVenda = new frmLixeiraVenda();
            lixeiraVenda.ShowDialog();
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVenda addVenda = new frmAdicionarVenda();
            addVenda.ShowDialog();

            if (addVenda.vendasRow?.Carro != null &&
                addVenda.vendasRow.Quantidade != 0 && 
                addVenda.vendasRow?.Valor != null
                )
            {
                this.vendasTableAdapter.Insert(
                addVenda.vendasRow.Carro,
                addVenda.vendasRow.Quantidade,
                addVenda.vendasRow.Valor,
                true,
                2,
                2,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }
    }
}
