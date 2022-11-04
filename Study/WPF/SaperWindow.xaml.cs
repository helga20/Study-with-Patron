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
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for SaperWindow.xaml
    /// </summary>
    public partial class SaperWindow : Window
    {
        public SaperWindow()
        {
            InitializeComponent();

        }

        int counter = 0;
        int max = 0;

        private void Timer_set()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 20);
            dispatcherTimer.Start();
            DateTime startTime;
            startTime = DateTime.Now;
            dispatcherTimer.Tick += (s, ev) => { time_TextBox.Text = String.Format("{0:00}", (DateTime.Now - startTime).Seconds); };
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Слідкуй за часом");
            Check_Hearts();
            counter--;
            if (counter < 0)
            {
                counter = 0;
            }
            score.Content = "Рахунок - " + counter;
            NextSol();
        }

        private void Result_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = "";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            string temp =result_TextBox.Text;
            result_TextBox.Text = temp + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
            result_TextBox.Text = temp + "0";
        }

        public char GetModul()
        {
            Random rnd = new Random();
            string chars = "+/-*";
            int num = rnd.Next(0, 4);
            char modul = chars[num];
            return modul;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //Timer_set();
            start.Visibility = Visibility.Collapsed;
            max = 10;
            Random rnd = new Random();
            int a = rnd.Next(1, max);
            int b = rnd.Next(1, max);
            char modul = GetModul();
            if (a < b && modul == '-')
            {
                int temp = a;
                a = b;
                b = temp;
            }
            number_1.Content = a.ToString();

            modul_.Content = modul.ToString();
            number_2.Content = b.ToString();
            eq.Content = "=";
        }

        private void NextSol()
        {
            //Timer_set();
            result_TextBox.Text = "";
            Random rnd = new Random();
            int a_1 = rnd.Next(1, max);
            int b_1 = rnd.Next(1, max);
            char modul = GetModul();
            if (a_1 < b_1 && modul == '-')
            {
                int temp = a_1;
                a_1 = b_1;
                b_1 = temp;
            }
            if (a_1 % b_1 != 0 && modul == '/')
            {
                modul = '+';
            }
            number_1.Content = a_1.ToString();
            number_2.Content = b_1.ToString();
            modul_.Content = modul.ToString();
        }

        private void Check_Hearts()
        {
            if (heart3.Visibility == Visibility.Visible)
            {
                heart3.Visibility = Visibility.Collapsed;
            }
            else if (heart2.Visibility == Visibility.Visible)
            {
                heart2.Visibility = Visibility.Collapsed;
            }
            else if (heart1.Visibility == Visibility.Visible)
            {
                heart1.Visibility = Visibility.Collapsed;
                MessageBox.Show("Не залишилося спроб. Гра завершена");
                MenuWindow m_win = new MenuWindow();
                this.Visibility = Visibility.Hidden;
                m_win.Show();
            }
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (result_TextBox.Text == "")
            {
                MessageBox.Show("Введи свою відповідь)");
            }
            else
            {
                string var; var = result_TextBox.Text;
                int res = Convert.ToInt32(var);
                int a = Convert.ToInt32(number_1.Content);
                int b = Convert.ToInt32(number_2.Content);

                if (res == a + b || res == a - b || res == a * b || res == a * b)
                {
                    NextSol();

                    counter++;
                    score.Content = "Рахунок - " + counter;

                }
                else
                {
                    MessageBox.Show("Обережно, ти відповів неправильно");
                    Check_Hearts();
                    counter--;
                    if (counter < 0)
                    {
                        counter = 0;
                    }
                    score.Content = "Рахунок - " + counter;
                    NextSol();
                }
                if (counter >= 15)
                {
                    max = 50;
                }
                if (counter >= 25)
                {
                    max = 75;
                }
                if (counter >= 32)
                {
                    max = 130;
                }
            }
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow reg_win = new RegistrationWindow();
            this.Visibility = Visibility.Hidden;
            reg_win.Show();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Time_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
