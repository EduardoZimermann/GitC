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
    public partial class LixeiraUsuario : Form
    {
        public LixeiraUsuario()
        {
            InitializeComponent();
        }

        private void LixeiraUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectInativos(this.parteFinalLocadoraTSQLDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.Recuperar(usuarioSelect.Id);
                    break;
            }

            this.usuariosTableAdapter.SelectInativos(this.parteFinalLocadoraTSQLDataSet1.Usuarios);
        }
    }
}
