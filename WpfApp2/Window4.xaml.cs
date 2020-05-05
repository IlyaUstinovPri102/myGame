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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Click_Click(object sender, RoutedEventArgs e)
        {
            int a = ListBox1.SelectedIndex;
            int c = ListView1.SelectedIndex;
            if ((a == 1) && (c == 6))
            {
                Hide();
                Window5 Готово = new Window5();
                Готово.Show();
                Close();
            }
            else
            {
                Hide();
                Close();
            }
        }
    }
}
