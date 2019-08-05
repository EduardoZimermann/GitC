using MVCProject.Adicao;
using MVCProject.Edicao;
using MVCProject.Lixeira;
using MVCProject.Model;
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

        int X = 0;
        int Y = 0;

        public frmUsuarios()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmUsuarios_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmUsuarios_MouseMove);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 218, 180);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(230, 230, 230);
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 57, 17);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);
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
                Session.user.Id,
                Session.user.Id,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLixeiraUsuario lixeiraUsuario = new frmLixeiraUsuario();
            lixeiraUsuario.ShowDialog();

            this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet1.Usuarios);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmUsuarios_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmUsuarios_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
