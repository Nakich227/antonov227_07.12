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
            int n = Convert.ToInt32(AA.Text);
            double x = Convert.ToInt32(BB.Text);
            double a, r1, r2, s;

            switch (n)
            {
                case 1:
                    a = x;
                    r1 = a * Math.Sqrt(3) / 6;
                    r2 = 2 * r1;
                    s = a * a * Math.Sqrt(3) / 4;
                    MessageBox.Show($"ответ: r1 = {r1} r2 = {r2} s = {s}");
                    break;
                case 2:
                    r1 = x;
                    a = r1 * 6 / Math.Sqrt(3);
                    r2 = 2 * r1;
                    s = a * a * Math.Sqrt(3) / 4;
                    MessageBox.Show($"ответ: a = {a} r2 = {r2} s = {s}");
                    break;
                case 3:
                    r2 = x;
                    r1 = r2 / 2;
                    a = r1 * 6 / Math.Sqrt(3);
                    s = a * a * Math.Sqrt(3) / 4;
                    MessageBox.Show($"ответ: a = {a} r1 = {r1} s = {s}");
                    break;
                case 4:
                    s = x;
                    a = Math.Sqrt(s * 4 / Math.Sqrt(3));
                    r1 = a * Math.Sqrt(3) / 6;
                    r2 = 2 * r1;
                    MessageBox.Show($"ответ: r1 = {r1} r2 = {r2} a = {a}");
                    break;
            }



        }
    }
}
