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
using System.Windows.Threading;

namespace Практическая_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Дударев И. В. ИСП-34. \nВариант 4.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GetCalculations_Click(object sender, RoutedEventArgs e)
        {
            if (volumeresult.Text != string.Empty || squareresult.Text != string.Empty)
            {
                inputvalue.Focus();
                volumeresult.Text = Math.Pow(int.Parse(inputvalue.Text), 3).ToString();
                squareresult.Text = (6 * Math.Pow(int.Parse(inputvalue.Text), 2)).ToString();
            }
            else MessageBox.Show("Введите данные", "Ошибка");
        }

        private void Inputvalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            squareresult.Clear();
            volumeresult.Clear();
        }

        private void GetTon_Click(object sender, RoutedEventArgs e)
        {
            if (kgvalue.Text != string.Empty)
            {
                kgvalue.Focus();
                tonsresult.Text = (int.Parse(kgvalue.Text) / 1000).ToString();
            }
            else MessageBox.Show("Введите данные", "Ошибка");
        }

        private void Kgvalue_TextChanged(object sender, TextChangedEventArgs e)
        {
            tonsresult.Clear();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            data.Text =  DateTime.Now.ToString("dd/MM/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
