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
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }
        string jazik;
        string jazik1;
        string tex;
        string tex1;
        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            jazik = tvItem.Header.ToString();
        }
        private void TreeViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem_1 = (TreeViewItem)sender;
            tex = tvItem_1.Header.ToString();
        }

        private void click_Click(object sender, RoutedEventArgs e)
        {
            if ((jazik == "C#") && (tex == "WPF"))
            {
                Hide();
                Window7 Готово = new Window7();
                Готово.Show();
                Close();
            }
            else
            {
                Hide();
                Close();
            }
        }

        private void vibor_Click(object sender, RoutedEventArgs e)
        {
            jazik1 = jazik;
            tex1 = tex;
        }
    }
}
