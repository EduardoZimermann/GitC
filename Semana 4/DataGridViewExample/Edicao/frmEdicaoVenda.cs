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
    public partial class frmEdicaoVenda : Form
    {
        public frmEdicaoVenda()
        {
            InitializeComponent();
        }

        private void FrmEdicaoVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet1.Clientes);
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet1.Carros);

        }
    }
}
