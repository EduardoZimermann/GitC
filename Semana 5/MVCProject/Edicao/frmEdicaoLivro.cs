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

namespace MVCProject.Edicao
{
    public partial class frmEdicaoLivro : Form
    {
        int X = 0;
        int Y = 0;

        public frmEdicaoLivro()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmEdicaoLivro_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmEdicaoLivro_MouseMove);
        }

        public SistemaBibliotecaDBDataSet.LivrosRow livrosRow;

        private void FrmEdicaoLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            tbxRegistro.Text = livrosRow.Registro.ToString();
            tbxTitulo.Text = livrosRow.Titulo;
            tbxIsbn.Text = livrosRow.Isbn;
            cbxGenero.SelectedValue = livrosRow.Genero;
            cbxEditora.SelectedValue = livrosRow.Editora;
            tbxSinopse.Text = livrosRow.Sinopse;
            tbxObservacoes.Text = livrosRow.Observacoes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow.Registro = int.Parse(tbxRegistro.Text);
            livrosRow.Titulo = tbxTitulo.Text;
            livrosRow.Isbn = tbxIsbn.Text;
            livrosRow.Genero = (int)cbxGenero.SelectedValue;
            livrosRow.Editora = (int)cbxEditora.SelectedValue;
            livrosRow.Sinopse = tbxSinopse.Text;
            livrosRow.Observacoes = tbxObservacoes.Text;
            livrosRow.UsuAlt = Session.user.Id;
            livrosRow.DatAlt = DateTime.Now;

            this.Close();
        }

        private void TbxRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdicaoLivro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmEdicaoLivro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
