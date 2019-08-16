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

namespace MVCProject.Adicao
{
    public partial class frmAdicionarLivro : Form
    {
        int X = 0;
        int Y = 0;

        public frmAdicionarLivro()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(FrmAdicionarLivro_MouseDown);
            this.MouseMove += new MouseEventHandler(FrmAdicionarLivro_MouseMove);
        }

        public Livro novoLivro;

        private void Button1_Click(object sender, EventArgs e)
        {
            int.TryParse(tbxRegistro.Text, out int registroLivro);

            novoLivro = new Livro
            {
                Registro = registroLivro,
                Titulo = tbxTitulo.Text,
                Isbn = tbxIsbn.Text,
                Genero = (int)cbxGenero.SelectedValue,
                Editora = (int)cbxEditora.SelectedValue,
                Sinopse = tbxSinopse.Text,
                Observacoes = tbxObservacoes.Text
            };

            this.Close();
        }

        private void FrmAdicionarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void TbxRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarLivro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmAdicionarLivro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
