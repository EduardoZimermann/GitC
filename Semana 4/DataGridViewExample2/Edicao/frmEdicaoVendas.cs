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
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample2.QuerysInnerJoinDataSet.VendasRow vendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);

            comboBox1.SelectedValue = vendasRow.Carro;
            numericUpDown1.Value = vendasRow.Quantidade;
            textBox1.Text = vendasRow.Valor.ToString();
        }

        private void Salvar_Click_1(object sender, EventArgs e)
        {
            vendasRow.Carro = (int)comboBox1.SelectedValue;
            vendasRow.Quantidade = (int)numericUpDown1.Value;
            decimal.TryParse(textBox1.Text, out decimal valorVenda);
            vendasRow.Valor = valorVenda;

            this.Close();
        }
    }
}
