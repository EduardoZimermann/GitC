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
    public partial class frmAdicionarGenero : Form
    {
        int X = 0;
        int Y = 0;

        public frmAdicionarGenero()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmAdicionarGenero_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmAdicionarGenero_MouseMove);
        }

        public Genero novoGenero;

        private void Salvar_Click(object sender, EventArgs e)
        {
            novoGenero = new Genero
            {
                Tipo = tbxTipo.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarGenero_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmAdicionarGenero_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
