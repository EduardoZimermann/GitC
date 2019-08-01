using DataGridViewExample.Edicao;
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
    public partial class Form1 : Form
    {
        int X = 0;
        int Y = 0;

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 adicionar = new Form2();
            adicionar.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 usuario = new Form3();
            usuario.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.ParteFinalLocadoraTSQLDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter.SetAtivoQuery(carSelect.Id);
                    break;
                case 1:
                    frmEdicaoCarros editCarro = new frmEdicaoCarros();
                    editCarro.CarrosRow = carSelect;
                    editCarro.ShowDialog();

                    this.carrosTableAdapter.Update(editCarro.CarrosRow);

                        /*editCarro.CarrosRow.Marca,
                        editCarro.CarrosRow.Modelo,
                        editCarro.CarrosRow.Ano,
                        editCarro.CarrosRow.UsuAlt,
                        editCarro.CarrosRow.DatAlt = DateTime.Now,
                        editCarro.CarrosRow.Id);*/
                    break;
            }

            this.carrosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Carros);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 cliente = new Form4();
            cliente.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5 estoque = new Form5();
            estoque.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //this.carrosTableAdapter.Recuperar();
            this.carrosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet1.Carros);
        }
    }
}
