using MVCProject.Adicao;
using MVCProject.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.generosTableAdapter.Deletar(generoSelect.Id);
                    break;
                case 1:
                    frmEdicaoGenero editGenero = new frmEdicaoGenero();
                    editGenero.generosRow = generoSelect;
                    editGenero.ShowDialog();

                    this.generosTableAdapter.Update(editGenero.generosRow);
                    break;
            }

            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGenero addGenero = new frmAdicionarGenero();
            addGenero.ShowDialog();

            if (!string.IsNullOrEmpty(addGenero.novoGenero?.Tipo) &&
                !string.IsNullOrEmpty(addGenero.novoGenero?.Descricao))
            {
                this.generosTableAdapter.Insert(
                    addGenero.novoGenero.Tipo,
                    addGenero.novoGenero.Descricao
                    );
            }

            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
