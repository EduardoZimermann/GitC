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
    public partial class frmEdicaoEditora : Form
    {
        int X = 0;
        int Y = 0;

        public frmEdicaoEditora()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmEdicaoEditora_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmEdicaoEditora_MouseMove);
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow editorasRow;

        private void FrmEdicaoEditora_Load(object sender, EventArgs e)
        {
            tbxNome.Text = editorasRow.Nome;
            tbxDescricao.Text = editorasRow.Descricao;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            editorasRow.Nome = tbxNome.Text;
            editorasRow.Descricao = tbxDescricao.Text;

            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdicaoEditora_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmEdicaoEditora_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
