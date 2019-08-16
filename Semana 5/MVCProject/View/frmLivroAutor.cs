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
    public partial class frmLivroAutor : Form
    {
        int X = 0;
        int Y = 0;

        public frmLivroAutor()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmLivroAutor_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmLivroAutor_MouseMove);
        }

        public SistemaBibliotecaDBDataSet.LivrosRow livroRow;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.SelectLivroAutor(this.sistemaBibliotecaDBDataSet.LivroAutor, livroRow.Id);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            //this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

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

            lblTitulo.Text = livroRow.Titulo;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var countLinhas = this.livroAutorTableAdapter.VerificarQuery(livroRow.Id, (int)cbxAutor.SelectedValue);

            if (countLinhas < 1)
            {
                this.livroAutorTableAdapter.Insert(
                livroRow.Id,
                (int)cbxAutor.SelectedValue
                );
            }
            else
                MessageBox.Show("Registro já existente!");

            this.livroAutorTableAdapter.SelectLivroAutor(this.sistemaBibliotecaDBDataSet.LivroAutor, livroRow.Id);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLivroAutor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmLivroAutor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
