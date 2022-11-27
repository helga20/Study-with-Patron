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
using StudyWithPatron.BLL;
using StudyWithPatron.DAL;
using System.Media;

namespace StudyWithPatron
{
    /// <summary>
    /// Interaction logic for MultDivWindow.xaml
    /// </summary>
    public partial class MultDivWindow : Window
    {
        public MultDivWindow()
        {
            InitializeComponent();
        }
        int counter = 0;
        int max = 0;

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.clear);
            playSound.Play();

            result_TextBox.Text = "";
        }
        public char GetModul()
        {
            Random rnd = new Random();
            string chars = "*/";
            int num = rnd.Next(0, 2);
            char modul = chars[num];
            return modul;
        }
        private void NextSol()
        {
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
                modul = '*';
            }
            number_1.Content = a_1.ToString();
            number_2.Content = b_1.ToString();
            modul_.Content = modul.ToString();
        }

        private void Result_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tString = result_TextBox.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Будь ласка, введи число");
                    result_TextBox.Text = "";
                    return;
                }
            }
        }
        private void Div_Load(object sender, RoutedEventArgs e)
        {
            max = 10;
            next_level.Visibility = Visibility.Collapsed;
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
            if (a % b != 0 && modul == '/')
            {
                modul = '*';
            }
            number_1.Content = a.ToString();
            modul_.Content = modul.ToString();
            number_2.Content = b.ToString();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            string temp = result_TextBox.Text;
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

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.check);
            playSound.Play();

            if (result_TextBox.Text == "")
            {
                MessageBox.Show("Введи свою відповідь)");
            }
            else
            {
                max = 10;
                string var;
                var = result_TextBox.Text;
                int res = Convert.ToInt32(var);
                int a = Convert.ToInt32(number_1.Content);
                int b = Convert.ToInt32(number_2.Content);
                if (res == a * b || res == a / b)
                {
                    NextSol();
                    counter++;
                    result.Text = "Вдалось - " + counter;

                }
                else
                {
                    SoundPlayer playSound1 = new SoundPlayer(Properties.ResourcesSounds.error);
                    playSound1.Play();

                    MessageBox.Show("Обережно, ти відповів неправильно");
                    counter--;
                    if (counter < 0)
                    {
                        counter = 0;
                    }
                    result.Text = "Вдалось - " + counter;
                    NextSol();
                }
                if (counter >= 15)
                {
                    next_level.Visibility = Visibility.Visible;
                }
                if (counter == 25)
                {
                    MessageBox.Show("Вітаю! Ти пройшов урок");
                    MenuWindow menu_win = new MenuWindow();
                    this.Visibility = Visibility.Hidden;
                    menu_win.Show();
                }
            }
        }

        private void Next_Level_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
            playSound.Play();

            MultDivWindow mult_win = new MultDivWindow();
            this.Visibility = Visibility.Hidden;
            mult_win.Show();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.back);
            playSound.Play();

            MenuWindow menu_win = new MenuWindow();
            this.Visibility = Visibility.Hidden;
            menu_win.Show();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.close);
            playSound.Play();

            Close();
        }
    }
}
