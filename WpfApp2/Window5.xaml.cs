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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        string cop;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            cop = boxtextone.SelectedText;
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            if (cop != "")
            {
                Hide();
                Window6 Готово = new Window6();
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
