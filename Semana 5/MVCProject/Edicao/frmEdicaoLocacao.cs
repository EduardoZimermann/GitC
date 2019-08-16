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
    public partial class frmEdicaoLocacao : Form
    {
        int X = 0;
        int Y = 0;

        public frmEdicaoLocacao()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmEdicaoLocacao_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmEdicaoLocacao_MouseMove);
        }

        public SistemaBibliotecaDBDataSet.LocacaoRow locacaoRow;

        private void FrmEdicaoLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            cbxLivro.SelectedValue = locacaoRow.Livro;
            cbxUsuario.SelectedValue = locacaoRow.Usuario;
            numTipo.Value = locacaoRow.Tipo;
            dtpDevolucao.Value = locacaoRow.Devolucao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow.Livro = (int)cbxLivro.SelectedValue;
            locacaoRow.Usuario = (int)cbxUsuario.SelectedValue;
            locacaoRow.Tipo = (int)numTipo.Value;
            locacaoRow.Devolucao = dtpDevolucao.Value;
            locacaoRow.UsuAlt = Session.user.Id;
            locacaoRow.DatAlt = DateTime.Now;

            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdicaoLocacao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmEdicaoLocacao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
