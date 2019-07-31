using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Locacoes' table. You can move, or remove it, as needed.
            this.locacoesTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet1.Locacoes);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.LocacoesRow;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
