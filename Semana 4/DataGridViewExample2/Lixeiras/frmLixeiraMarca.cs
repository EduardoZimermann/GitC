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
    public partial class frmLixeiraMarca : Form
    {
        public frmLixeiraMarca()
        {
            InitializeComponent();
        }

        private void FrmLixeiraMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcaSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.marcasTableAdapter.Restaurar(marcaSelect.Id);
                    break;
            }

            this.marcasTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Marcas);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
