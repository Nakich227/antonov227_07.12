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
            int a = int.Parse(AA.Text);
            string r = "";
            switch (a / 100)
            {
                case 1: r = "cто "; break;
                case 2: r = "двести "; break;
                case 3: r = "триста "; break;
                case 4: r = "четыреста "; break;
                case 5: r = "пятьсот "; break;
                case 6: r = "шестьсот "; break;
                case 7: r = "семьсот "; break;
                case 8: r = "восемьсот "; break;
                case 9: r = "девятьсот "; break;
            }
            switch (a % 100 / 10)
            {
                case 2: r += "двадцать "; break;
                case 3: r += "тридцать "; break;
                case 4: r += "сорок "; break;
                case 5: r += "пятьдесят "; break;
                case 6: r += "шестьдесят "; break;
                case 7: r += "семьдесят "; break;
                case 8: r += "восемьдесят "; break;
                case 9: r += "девяносто "; break;
            }
            switch (a % 10)
            {
                case 1: r = "один"; break;
                case 2: r += "два"; break;
                case 3: r += "три"; break;
                case 4: r += "четыре"; break;
                case 5: r += "пять"; break;
                case 6: r += "шесть"; break;
                case 7: r += "семь"; break;
                case 8: r += "восемь"; break;
                case 9: r += "девять"; break;
            }
            MessageBox.Show($"Ответ: {r}");








        }
    }
}
