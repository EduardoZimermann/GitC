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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.SetAtivoQuery(usuarioSelect.Id);
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Usuarios);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LixeiraUsuario user = new LixeiraUsuario();
            user.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Usuarios);
        }
    }
}
