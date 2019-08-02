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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.autoresTableAdapter.Deletar(autorSelect.Id);
                    break;
                case 1:
                    frmEdicaoAutor editAutor = new frmEdicaoAutor();
                    editAutor.AutoresRow = autorSelect;
                    editAutor.ShowDialog();

                    this.autoresTableAdapter.Update(editAutor.AutoresRow);
                    break;
            }

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor addAutor = new frmAdicionarAutor();
            addAutor.ShowDialog();

            if (!string.IsNullOrEmpty(addAutor.novoAutor?.Nome) &&
                !string.IsNullOrEmpty(addAutor.novoAutor?.Descricao))
            {
                this.autoresTableAdapter.Insert(
                addAutor.novoAutor.Nome,
                addAutor.novoAutor.Descricao
                );
            }

            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
