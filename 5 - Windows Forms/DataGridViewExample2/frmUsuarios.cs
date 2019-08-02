using DataGridViewExample2.Edicao;
using DataGridViewExample2.Lixeiras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample2
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                    break;
                case 1:
                    frmEdicaoUsuarios editUser = new frmEdicaoUsuarios();
                    editUser.usuariosRow = usuarioSelect;
                    editUser.ShowDialog();

                    this.usuariosTableAdapter.Update(editUser.usuariosRow);
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmLixeiraUsuario lixeiraUsuario = new frmLixeiraUsuario();
            lixeiraUsuario.ShowDialog();
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario addUser = new frmAdicionarUsuario();
            addUser.ShowDialog();

            if (!string.IsNullOrEmpty(addUser.userRow?.User))
            {
                this.usuariosTableAdapter.Insert(
                addUser.userRow.User,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
        }
    }
}
