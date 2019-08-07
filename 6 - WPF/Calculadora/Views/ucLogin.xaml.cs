using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora.Views
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public event EventHandler correctLogin;

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            VerificaLogin(tbxNome.Text, tbxSenha.Text);
        }

        public void VerificaLogin(string nome, string senha)
        {
            if (nome == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                correctLogin(null, new EventArgs());
            }
            else
                MessageBox.Show("Login errado!!!");
        }

        private void TbxSenha_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
