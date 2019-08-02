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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.editorasTableAdapter.Deletar(editoraSelect.Id);
                    break;
                case 1:
                    frmEdicaoEditora editEditora = new frmEdicaoEditora();
                    editEditora.editorasRow = editoraSelect;
                    editEditora.ShowDialog();

                    this.editorasTableAdapter.Update(editEditora.editorasRow);
                    break;
            }

            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarEditora addEditora = new frmAdicionarEditora();
            addEditora.ShowDialog();

            if (!string.IsNullOrEmpty(addEditora.novoEditora?.Nome) &&
                !string.IsNullOrEmpty(addEditora.novoEditora?.Nome))
            {
                this.editorasTableAdapter.Insert(
                addEditora.novoEditora.Nome,
                addEditora.novoEditora.Descricao
                );
            }

            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
