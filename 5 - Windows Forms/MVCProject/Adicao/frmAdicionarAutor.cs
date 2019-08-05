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
    public partial class frmAdicionarAutor : Form
    {
        int X = 0;
        int Y = 0;

        public frmAdicionarAutor()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmAdicionarAutor_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmAdicionarAutor_MouseMove);
        }

        public Autor novoAutor;

        private void Salvar_Click(object sender, EventArgs e)
        {
            novoAutor = new Autor
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarAutor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmAdicionarAutor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
