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
    public partial class frmAdicionarUsuario : Form
    {
        int X = 0;
        int Y = 0;

        public frmAdicionarUsuario()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmAdicionarUsuario_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmAdicionarUsuario_MouseMove);
        }

        public Usuario userRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            userRow = new Usuario
            {
                Nome = tbxNome.Text,
                Login = tbxLogin.Text,
                Senha = tbxSenha.Text,
                Email = tbxEmail.Text
            };

            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmAdicionarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
