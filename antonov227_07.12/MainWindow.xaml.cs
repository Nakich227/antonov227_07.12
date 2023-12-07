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
            switch (a) // переключатель, основанный на выборе пользователя.
            {
                case 1:
                case 2:
                case 12:
                    {
                        MessageBox.Show("Winter!"); // выбрал значения 1, 2, 12 .
                        break;
                    }

                case 3:
                case 4:
                case 5:
                    {
                        MessageBox.Show("весна"); // выбрал значения 3, 4, 5.
                        break;
                    }

                case 6:
                case 7:
                case 8:
                    {
                        MessageBox.Show("лето") ; // выбрал значение 6, 7, 8.
                        break;
                    }

                case 9:
                case 10:
                case 11:
                    {
                        MessageBox.Show("Осень"); // выбрал значение 9, 10, 11.
                        break;
                    }
            }

        }
    }
}
