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
        public frmAdicionarAutor()
        {
            InitializeComponent();
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
    }
}
