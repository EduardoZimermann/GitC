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
    public partial class TelaDeCadastro : Form
    {
        int X = 0;
        int Y = 0;

        public TelaDeCadastro()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(TelaDeCadastro_MouseDown);
            this.MouseMove += new MouseEventHandler(TelaDeCadastro_MouseMove);
        }

        public Carro novoCarro = new Carro();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = tbxModelo.Text;
            novoCarro.Placa = tbxPlaca.Text;
            novoCarro.Ano = (int)numAno.Value;

            if (VerificaValores(novoCarro.Modelo, novoCarro.Placa, novoCarro.Ano))
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
                return;
            }

            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificaValores(string modelo, string placa, int ano)
        {
            if (string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(placa) || ano == 0)
                return true;

            return false;
        }

        private void TelaDeCadastro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void TelaDeCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
