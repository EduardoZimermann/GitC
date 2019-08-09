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

namespace WpfAppEntity
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

        private void UcLoginForm_success(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
            ucLoginForm.Visibility = Visibility.Hidden;
            ucGridViewForm.Visibility = Visibility.Visible;
        }

        private void UcLoginForm_fail(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}
