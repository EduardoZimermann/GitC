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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras editora = new frmEditoras();
            editora.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autor = new frmAutores();
            autor.ShowDialog();
        }

        private void GêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros genero = new frmGeneros();
            genero.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros livro = new frmLivros();
            livro.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacoes locacao = new frmLocacoes();
            locacao.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
