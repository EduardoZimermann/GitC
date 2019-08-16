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
    public partial class frmEdicaoCarros : Form
    {
        public frmEdicaoCarros()
        {
            InitializeComponent();
        }

        public DataGridViewExample2.QuerysInnerJoinDataSet.CarrosRow carrosRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);

            textBox1.Text = carrosRow.Modelo;
            dateTimePicker1.Value = carrosRow.Ano;
            comboBox1.SelectedValue = carrosRow.Marca;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow.Modelo = textBox1.Text;
            carrosRow.Ano = dateTimePicker1.Value;
            carrosRow.Marca = (int)comboBox1.SelectedValue;

            this.Close();
        }

        private void FillMarcasToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillMarcas(this.querysInnerJoinDataSet.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
