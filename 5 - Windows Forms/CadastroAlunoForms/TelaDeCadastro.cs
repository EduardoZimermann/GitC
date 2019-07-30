using CadastroAlunoForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunoForms
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Idade = int.Parse(tbxIdade.Text);

            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = null;
            tbxIdade.Text = null;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaDeCadastro_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200,200);
        }
    }
}
