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

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string x = "pfffff";
        public MainWindow()
        {
            InitializeComponent();
            Login.Focus();
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == x)
            {
                (new Window1()).Show();
                Close();
            }
            else
                MessageBox.Show("złe hasło!!!!");
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ButtonLog_Click(sender, e);
            }
        }

    }
}
