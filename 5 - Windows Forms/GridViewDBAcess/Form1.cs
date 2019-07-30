using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewDBAcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet.Estoque);
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet.Usuarios);
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Locacoes' table. You can move, or remove it, as needed.
            this.locacoesTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet.Locacoes);
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet.Carros);

        }
    }
}
