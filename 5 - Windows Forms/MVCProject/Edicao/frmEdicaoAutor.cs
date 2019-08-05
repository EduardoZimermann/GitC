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
    public partial class frmEdicaoAutor : Form
    {
        int X = 0;
        int Y = 0;

        public frmEdicaoAutor()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmEdicaoAutor_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmEdicaoAutor_MouseMove);
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;
        private void FrmEdicaoAutor_Load(object sender, EventArgs e)
        {
            tbxNome.Text = AutoresRow.Nome;
            tbxDescricao.Text = AutoresRow.Descricao;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome = tbxNome.Text;
            AutoresRow.Descricao = tbxDescricao.Text;

            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdicaoAutor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmEdicaoAutor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
