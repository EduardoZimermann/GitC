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
    public partial class frmEdicaoGenero : Form
    {
        public frmEdicaoGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow generosRow;

        private void FrmEdicaoGenero_Load(object sender, EventArgs e)
        {
            tbxTipo.Text = generosRow.Tipo;
            tbxDescricao.Text = generosRow.Descricao;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            generosRow.Tipo = tbxTipo.Text;
            generosRow.Descricao = tbxDescricao.Text;

            this.Close();
        }
    }
}
