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
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Rating_Click(object sender, RoutedEventArgs e)
        {
            RatingWindow rat_win = new RatingWindow();
            this.Visibility = Visibility.Hidden;
            rat_win.Show();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            SaperWindow sap_win = new SaperWindow();
            this.Visibility = Visibility.Hidden;
            sap_win.Show();
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
