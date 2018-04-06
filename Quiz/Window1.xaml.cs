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
using System.Windows.Shapes;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Questions> Qlist = new List<Questions>();
        

        public Window1()
        {
            InitializeComponent();
            List<string> a = new List<string> { "a", "b", "c" };
            Qlist.Add(new Questions("lalal", a));
            Qlist.Add(new Questions("sadsa", a));
        }
    }
}
