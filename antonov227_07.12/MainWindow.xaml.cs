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
            int b = Convert.ToInt32(BB.Text);
            string s = "";
            switch (a)
            {
                case 6: s = "шестёрка"; break;
                case 7: s = "семерка"; break;
                case 8: s = "восмерка"; break;
                case 9: s = "девятка"; break;
                case 10: s = "десятка"; break;
                case 11: s = "валет"; break;
                case 12: s = "дама"; break;
                case 13: s = "король"; break;
                case 14: s = "туз"; break;
            }
            switch (b)
            {
                case 1: s += " пики"; break;
                case 2: s += "  крести"; break;
                case 3: s += " буби"; break;
                case 4: s += " черви"; break;
            }
            MessageBox.Show($"ответ: {s}") ;


        }
    }
}
