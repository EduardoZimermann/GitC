using FormCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCarros
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Carro novoCarro = new Carro();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = tbxModelo.Text;
            novoCarro.Ano = int.Parse(tbxAno.Text);
            novoCarro.Placa = tbxPlaca.Text;

            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
