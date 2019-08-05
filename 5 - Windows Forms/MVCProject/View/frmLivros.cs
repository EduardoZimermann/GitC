using MVCProject.Adicao;
using MVCProject.Edicao;
using MVCProject.Lixeira;
using MVCProject.Model;
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
    public partial class frmLivros : Form
    {
        int X = 0;
        int Y = 0;

        public frmLivros()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmLivros_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmLivros_MouseMove);
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 218, 180);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(230, 230, 230);
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 57, 17);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.livrosTableAdapter.Deletar(livroSelect.Id);
                    break;
                case 1:
                    frmEdicaoLivro editLivro = new frmEdicaoLivro();
                    editLivro.livrosRow = livroSelect;
                    editLivro.ShowDialog();

                    this.livrosTableAdapter.Update(editLivro.livrosRow);
                    break;
                case 2:
                    frmLivroAutor livroAutor = new frmLivroAutor();
                    livroAutor.livroRow = livroSelect;
                    livroAutor.ShowDialog();
                    break;
            }

            this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivro addLivro = new frmAdicionarLivro();
            addLivro.ShowDialog();

            if (!string.IsNullOrEmpty(addLivro.novoLivro?.Registro.ToString()) &&
                !string.IsNullOrEmpty(addLivro.novoLivro?.Titulo) &&
                !string.IsNullOrEmpty(addLivro.novoLivro?.Isbn))
            {
                this.livrosTableAdapter.InsertQuery(
                    addLivro.novoLivro.Registro,
                    addLivro.novoLivro.Titulo,
                    addLivro.novoLivro.Isbn,
                    addLivro.novoLivro.Genero,
                    addLivro.novoLivro.Editora,
                    addLivro.novoLivro.Sinopse,
                    addLivro.novoLivro.Observacoes,
                    true,
                    Session.user.Id,
                    Session.user.Id,
                    DateTime.Now,
                    DateTime.Now
                );
            }

            this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLixeiraLivro lixeiraLivro = new frmLixeiraLivro();
            lixeiraLivro.ShowDialog();
            this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmLivros_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmLivros_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
