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
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void acceptButton_Click1(object sender, RoutedEventArgs e)
        {
            int a = ComboBox1.SelectedIndex;
            if (a == 0)
            {
                Hide();
                Window3 Готово = new Window3();
                Готово.ShowDialog();
                Close();
            }
            else
            {
                Close();
                Hide();
            }
        }
        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
