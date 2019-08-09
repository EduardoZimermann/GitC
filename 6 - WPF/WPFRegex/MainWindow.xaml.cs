using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFRegex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var resultFone = Regex.IsMatch(txtTelefone.Text, @"\d{2}\s+\d{2}\s+\d{9}");
            var resultMail = Regex.IsMatch(txtEmail.Text, "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$");

            if (resultFone)
                MessageBox.Show("Telefone válido!\r\n");
            else
                MessageBox.Show("Telefone inválido!\r\n");

            if (resultMail)
                MessageBox.Show("E-mail válido!");
            else
                MessageBox.Show("E-mail inválido!");
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            string infos = $"Telefone: {txtTelefone.Text}\r\nE-mail: {txtEmail.Text}";
            MessageBox.Show(infos);
        }
    }
}
