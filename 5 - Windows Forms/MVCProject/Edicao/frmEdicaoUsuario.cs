﻿using System;
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
        public frmEdicaoUsuario()
        {
            InitializeComponent();
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

            this.Close();
        }
    }
}
