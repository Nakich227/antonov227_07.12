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
            switch (a)
            {
                case 6:
                    MessageBox.Show("шестёрка ");
                    break;
                case 7:
                    MessageBox.Show("семёрка ");
                    break;
                case 8:
                    MessageBox.Show("восьмёрка ");
                    break;
                case 9:
                    MessageBox.Show("девятка ");
                    break;
                case 10:
                    MessageBox.Show("десятка ");
                    break;
                case 11:
                    MessageBox.Show("валет ");
                    break;
                case 12:
                    MessageBox.Show("дама");
                    break;
                case 13:
                    MessageBox.Show("король ");
                    break;
                case 14:
                    MessageBox.Show("туз ");
                    break;
            }

            switch (b)
            {
                case 1:
                    MessageBox.Show("пики");
                    break;
                case 2:
                    MessageBox.Show("крести");
                    break;
                case 3:
                    MessageBox.Show("буби");
                    break;
                case 4:
                    MessageBox.Show("черви");
                    break;
            }


        }
    }
}
