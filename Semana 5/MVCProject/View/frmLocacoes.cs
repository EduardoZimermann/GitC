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
    public partial class frmLocacoes : Form
    {
        int X = 0;
        int Y = 0;

        public frmLocacoes()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmLocacoes_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmLocacoes_MouseMove);
        }

        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Locacao);

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
                    this.locacaoTableAdapter.Deletar(locacaoSelect.Id);
                    break;
                case 1:
                    frmEdicaoLocacao editLocacao = new frmEdicaoLocacao();
                    editLocacao.locacaoRow = locacaoSelect;
                    editLocacao.ShowDialog();

                    this.locacaoTableAdapter.Update(editLocacao.locacaoRow);
                    break;
            }

            this.locacaoTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao addLocacao = new frmAdicionarLocacao();
            addLocacao.ShowDialog();

            if (addLocacao.novoLocacao != null && addLocacao.novoLocacao?.Tipo != 0)
            {
                this.locacaoTableAdapter.Insert(
                addLocacao.novoLocacao.Livro,
                addLocacao.novoLocacao.Usuario,
                addLocacao.novoLocacao.Tipo,
                addLocacao.novoLocacao.Devolucao,
                true,
                Session.user.Id,
                Session.user.Id,
                DateTime.Now,
                DateTime.Now
                );
            }

            this.locacaoTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmLixeiraLocacao lixeiraLocacao = new frmLixeiraLocacao();
            lixeiraLocacao.ShowDialog();

            this.locacaoTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Locacao);
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

        private void FrmLocacoes_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmLocacoes_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
