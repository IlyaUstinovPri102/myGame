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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            if ((var1.IsChecked == true) && (nomer1.IsChecked == true))
            {
                Hide();
                Window4 Готово = new Window4();
                Готово.Show();
                Close();
            }
            else
            {
                Close();
                Hide();
            }
        }
    }
}
