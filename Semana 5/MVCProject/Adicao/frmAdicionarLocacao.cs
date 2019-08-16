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

namespace MVCProject.Adicao
{
    public partial class frmAdicionarLocacao : Form
    {
        int X = 0;
        int Y = 0;

        public frmAdicionarLocacao()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmAdicionarLocacao_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmAdicionarLocacao_MouseMove);
        }

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        public Locacao novoLocacao;

        private void Button1_Click(object sender, EventArgs e)
        {
            novoLocacao = new Locacao
            {
                Livro = (int)cbxLivro.SelectedValue,
                Usuario = (int)cbxUsuario.SelectedValue,
                Tipo = (int)numTipo.Value,
                Devolucao = dtpDevolucao.Value
            };

            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CbxLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpDevolucao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumTipo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarLocacao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmAdicionarLocacao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
