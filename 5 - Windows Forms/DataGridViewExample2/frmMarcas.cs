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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcaSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.marcasTableAdapter.DeleteQuery(marcaSelect.Id);
                    break;
                case 1:
                    frmEdicaoMarcas editMarca = new frmEdicaoMarcas();
                    editMarca.marcasRow = marcaSelect;
                    editMarca.ShowDialog();

                    this.marcasTableAdapter.Update(editMarca.marcasRow);
                    break;
            }

            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmLixeiraMarca lixeiraMarca = new frmLixeiraMarca();
            lixeiraMarca.ShowDialog();
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarca addMarca = new frmAdicionarMarca();
            addMarca.ShowDialog();

            if (!string.IsNullOrEmpty(addMarca.marcasRow?.Nome))
            {
                this.marcasTableAdapter.Insert(
                addMarca.marcasRow.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
        }
    }
}
