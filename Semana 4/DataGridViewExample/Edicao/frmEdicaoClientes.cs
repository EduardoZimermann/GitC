using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoClientes : Form
    {
        public frmEdicaoClientes()
        {
            InitializeComponent();
        }

        public DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.ClientesRow clienteRow;
        private void FrmEdicaoClientes_Load(object sender, EventArgs e)
        {
            textBox1.Text = clienteRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clienteRow.Nome = textBox1.Text;

            this.Close();
        }
    }
}
