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

namespace antonov227_07._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(AA.Text);
            double b = Convert.ToInt32(BB.Text);
            double z, x, c, v;
            switch (a)
            {
                case 1:
                    z = b ;
                    x = z * Math.Sqrt(3) / 6;
                    c = 2 *x;
                    v = z * z * Math.Sqrt(3) / 4;
                    Console.WriteLine(x);
                    Console.WriteLine(c);
                    Console.WriteLine(v);
                    break;
                case 2:
                    x = b;
                    z = x * 6 / Math.Sqrt(3);
                    c = 2 * x;
                    v = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine(z);
                    Console.WriteLine(c);
                    Console.WriteLine(v);
                    break;
                case 3:
                    c = b;
                    x = c / 2;
                    z = x * 6 / Math.Sqrt(3);
                    v = a * a * Math.Sqrt(3) / 4;
                    Console.WriteLine(z);
                    Console.WriteLine(x);
                    Console.WriteLine(v);
                    break;
                case 4:
                    v = b;
                    z = Math.Sqrt(v * 4 / Math.Sqrt(3));
                    x = a * Math.Sqrt(3) / 6;
                    c = 2 * x;
                    Console.WriteLine(x);
                    Console.WriteLine(c);
                    Console.WriteLine(z);
                    break;
            }



        }
    }
}
