using FormCarros.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Carro> carro = new List<Carro>();

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCad = new TelaDeCadastro();
            formCad.ShowDialog();
            carro.Add(new Carro {
                Id = carro.Count,
                Modelo = formCad.novoCarro.Modelo,
                Ano = formCad.novoCarro.Ano,
                Placa = formCad.novoCarro.Placa
            });

            BlindList();
        }

        private void BlindList()
        {
            var newList = new List<Carro>();

            foreach (Carro item in carro)
                newList.Add(new Carro
                {
                    Id = item.Id,
                    Modelo = item.Modelo,
                    Ano = item.Ano,
                    Placa = item.Placa
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var collumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0:
                        MessageBox.Show("Impossível modificar esta coluna!");
                        break;
                    case 1:
                        if (MessageBox.Show("Desejas realmente modificar esta coluna?"
                            , "Editar"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            carro.FirstOrDefault(x =>
                            x.Id == (int)collumId.Value).Modelo = collValue.Value.ToString();
                        }
                        break;
                    case 2:
                        if (MessageBox.Show("Desejas realmente modificar esta coluna?"
                            , "Editar"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            carro.FirstOrDefault(x =>
                            x.Id == (int)collumId.Value).Ano = (int)collValue.Value;
                        }
                        break;
                    case 3:
                        if (MessageBox.Show("Desejas realmente modificar esta coluna?"
                            , "Editar"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            carro.FirstOrDefault(x =>
                            x.Id == (int)collumId.Value).Placa = collValue.Value.ToString();
                        }
                        break;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
