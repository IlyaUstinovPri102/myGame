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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        int click = 0;
        int timersec = 0;
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timerTick(object sender, EventArgs e)
        {
            timersec++;
            secunda.Content = timersec;
            if (timersec > 15)
            {
                Close();
            }
        }
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
                click++;
                Text.Content = ($"Вы нажали на кнопку " + click + " раз.");
        }
        private void acceptButton_Click1(object sender, RoutedEventArgs e)
        {
            if ((click >= 5) && (timersec < 16))
            {
                Hide();
                Window7 Готово = new Window7();
                Готово.ShowDialog();
                Close();
            }
            else
            {
                else1.Content = ("Вы нажали на кнопку меньше 5 раз!");
            }
        }
    }
}
