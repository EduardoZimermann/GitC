using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Lixeira
{
    public partial class frmLixeiraLocacao : Form
    {
        int X = 0;
        int Y = 0;

        public frmLixeiraLocacao()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmLixeiraLocacao_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmLixeiraLocacao_MouseMove);
        }

        private void FrmLixeiraLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.SelectInativos(this.sistemaBibliotecaDBDataSet.Locacao);

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
            var locacaoSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.locacaoTableAdapter.Restaurar(locacaoSelect.Id);
                    break;
            }

            this.locacaoTableAdapter.SelectInativos(this.sistemaBibliotecaDBDataSet.Locacao);
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

        private void FrmLixeiraLocacao_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmLixeiraLocacao_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
