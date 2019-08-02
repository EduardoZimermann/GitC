using MVCProject.Adicao;
using MVCProject.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.usuariosTableAdapter.Deletar(userSelect.Id);
                    break;
                case 1:
                    frmEdicaoUsuario formEdit = new frmEdicaoUsuario();
                    formEdit.usuarioRow = userSelect;
                    formEdit.ShowDialog();

                    this.usuariosTableAdapter.Update(formEdit.usuarioRow);
                    break;
            }

            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario addUser = new frmAdicionarUsuario();
            addUser.ShowDialog();

            if (!string.IsNullOrEmpty(addUser.userRow?.Nome) &&
                !string.IsNullOrEmpty(addUser.userRow?.Login) &&
                !string.IsNullOrEmpty(addUser.userRow?.Senha) &&
                !string.IsNullOrEmpty(addUser.userRow?.Email))
            {
                this.usuariosTableAdapter.Insert(
                addUser.userRow.Nome,
                addUser.userRow.Login,
                addUser.userRow.Senha,
                addUser.userRow.Email,
                true,
                0,
                0,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);
        }
    }
}
