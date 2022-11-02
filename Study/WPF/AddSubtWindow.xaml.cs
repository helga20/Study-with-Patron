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
    /// Interaction logic for AddSubtWindow.xaml
    /// </summary>
    public partial class AddSubtWindow : Window
    {
        public AddSubtWindow()
        {
            InitializeComponent();
        }
        private void Result_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
        private void One_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Level_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu_win = new MenuWindow();
            this.Visibility = Visibility.Hidden;
            menu_win.Show();
        }
    }
}
