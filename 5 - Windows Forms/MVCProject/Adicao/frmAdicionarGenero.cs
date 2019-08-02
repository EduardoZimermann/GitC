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
        public frmAdicionarGenero()
        {
            InitializeComponent();
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
    }
}
