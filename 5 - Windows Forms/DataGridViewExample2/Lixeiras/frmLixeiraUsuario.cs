using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2.Lixeiras
{
    public partial class frmLixeiraUsuario : Form
    {
        public frmLixeiraUsuario()
        {
            InitializeComponent();
        }

        private void FrmLixeiraUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.Restaurar(usuarioSelect.Id);
                    break;
            }

            this.usuariosTableAdapter.SelectNaoAtivos(this.querysInnerJoinDataSet.Usuarios);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
