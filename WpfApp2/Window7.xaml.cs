using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow Готово = new MainWindow();
            Готово.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Window1 Готово = new Window1();
            Готово.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            Window2 Готово = new Window2();
            Готово.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hide();
            Window3 Готово = new Window3();
            Готово.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Hide();
            Window4 Готово = new Window4();
            Готово.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Hide();
            Window5 Готово = new Window5();
            Готово.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Hide();
            Window6 Готово = new Window6();
            Готово.Show();
            Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Hide();
            Window7 Готово = new Window7();
            Готово.Show();
            Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Hide();
            Window8 Готово = new Window8();
            Готово.Show();
            Close();
        }
    }
}
