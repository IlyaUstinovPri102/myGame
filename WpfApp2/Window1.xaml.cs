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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        string otvet;
        private void acceptButton_Click2(object sender, RoutedEventArgs e)
        {
            if (otvet == "Лампочка")
            {
                Hide();
                Window2 Готово = new Window2();
                Готово.ShowDialog();
                Close();
            }
            else
            {
                Hide();
                Close();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            otvet = Convert.ToString(textbox1.Text);
        }
    }
}
