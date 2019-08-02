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
        public frmEdicaoAutor()
        {
            InitializeComponent();
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
    }
}
