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
using StudyWithPatron.BLL;
using StudyWithPatron.DAL;
using System.Media;

namespace StudyWithPatron
{
    public static class Globals
    {
        public static bool Checks_Sound;
        public static string? name;
        public static int result;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Globals.Checks_Sound)
            {
                Check_Sound.IsChecked = true;
            }
        }
        private void Start_game_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
                playSound.Play();
            }

            MenuWindow menu_win = new MenuWindow();
            this.Visibility = Visibility.Hidden;
            menu_win.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if(Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.close);
                playSound.Play();
            }
            Close();
        }

        private void Check_Sound_Checked(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound)
            {
                Globals.Checks_Sound = false;
            }
            else
            {
                Globals.Checks_Sound = true;
            }
        }
    }
}
