using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
namespace StudyWithPatron
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        
        private void Sum_Diff_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
            playSound.Play();

            AddSubtWindow add_sub_win = new AddSubtWindow();
            this.Visibility = Visibility.Hidden;
            add_sub_win.Show();
        }

        private void Mul_Div_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
            playSound.Play();

            MultDivWindow mul_div_win = new MultDivWindow();
            this.Visibility = Visibility.Hidden;
            mul_div_win.Show();
        }

        private void Saper_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
            playSound.Play();

            RegistrationWindow reg_win = new RegistrationWindow();
            this.Visibility = Visibility.Hidden;
            reg_win.Show();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.back);
            playSound.Play();

            MainWindow main_win = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main_win.Show();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.close);
            playSound.Play();

            Close();
        }
    }
}
