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
    public partial class frmPrincipal2 : Form
    {
        int X = 0;
        int Y = 0;

        public Usuario usuario = new Usuario();

        public frmPrincipal2()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(FrmPrincipal2_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmPrincipal2_MouseMove);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnUsuarios.Height;
            pnlLeft.Top = btnUsuarios.Top;

            frmUsuarios user = new frmUsuarios();
            user.ShowDialog();
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnAutores.Height;
            pnlLeft.Top = btnAutores.Top;

            frmAutores autor = new frmAutores();
            autor.ShowDialog();

        }

        private void BtnGeneros_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnGeneros.Height;
            pnlLeft.Top = btnGeneros.Top;

            frmGeneros generos = new frmGeneros();
            generos.ShowDialog();
        }

        private void BtnLivros_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnLivros.Height;
            pnlLeft.Top = btnLivros.Top;

            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }

        private void BtnLocacao_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnLocacao.Height;
            pnlLeft.Top = btnLocacao.Top;

            frmLocacoes locacoes = new frmLocacoes();
            locacoes.ShowDialog();
        }

        private void BtnEditoras_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnEditoras.Height;
            pnlLeft.Top = btnEditoras.Top;

            frmEditoras editoras = new frmEditoras();
            editoras.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmPrincipal2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmPrincipal2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FrmPrincipal2_Load(object sender, EventArgs e)
        {
            label13.Text = "Usuário: " + Session.user.Login;
        }
    }
}
