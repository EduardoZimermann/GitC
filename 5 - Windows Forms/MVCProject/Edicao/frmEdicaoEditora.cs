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
        public frmEdicaoEditora()
        {
            InitializeComponent();
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
    }
}
