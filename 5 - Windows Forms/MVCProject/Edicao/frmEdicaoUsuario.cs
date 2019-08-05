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
    public partial class frmEdicaoUsuario : Form
    {
        int X = 0;
        int Y = 0;

        public frmEdicaoUsuario()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmEdicaoUsuario_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmEdicaoUsuario_MouseMove);
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow usuarioRow;

        private void FrmEdicaoUsuario_Load(object sender, EventArgs e)
        {
            tbxNome.Text = usuarioRow.Nome;
            tbxLogin.Text = usuarioRow.Login;
            tbxSenha.Text = usuarioRow.Senha;
            tbxEmail.Text = usuarioRow.Email;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow.Nome = tbxNome.Text;
            usuarioRow.Login = tbxLogin.Text;
            usuarioRow.Senha = tbxSenha.Text;
            usuarioRow.Email = tbxEmail.Text;
            usuarioRow.UsuAlt = Session.user.Id;
            usuarioRow.DatAlt = DateTime.Now;

            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEdicaoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmEdicaoUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
