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
    public partial class frmLixeiraCarro : Form
    {
        public frmLixeiraCarro()
        {
            InitializeComponent();
        }

        private void FrmLixeiraCarro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
                        this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                        as DataGridViewExample2.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter.Restaurar(carSelect.Id);
                    break;
            }

            this.carrosTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Carros);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
