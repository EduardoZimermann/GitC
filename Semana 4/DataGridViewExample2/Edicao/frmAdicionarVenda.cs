using DataGridViewExample2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2.Edicao
{
    public partial class frmAdicionarVenda : Form
    {
        public frmAdicionarVenda()
        {
            InitializeComponent();
        }

        public Venda vendasRow;
        private void FrmAdicionarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal valorVenda);

            vendasRow = new Venda
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valorVenda
            };

            this.Close();
        }
    }
}
