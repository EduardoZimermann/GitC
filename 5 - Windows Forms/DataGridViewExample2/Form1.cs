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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample2.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    break;
                case 1:
                    frmEdicaoCarros editCar = new frmEdicaoCarros();
                    editCar.carrosRow = carSelect;
                    editCar.ShowDialog();

                    this.carrosTableAdapter.Update(editCar.carrosRow);
                    break;
            }

            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            vendas.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMarcas marca = new frmMarcas();
            marca.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmLixeiraCarro lixeiraCarro = new frmLixeiraCarro();
            lixeiraCarro.ShowDialog();
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            nuclearContent sanic = new nuclearContent();
            sanic.ShowDialog();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            this.carrosTableAdapter.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
        }
    }
}
