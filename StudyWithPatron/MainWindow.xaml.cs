using System.Media;
using System.Windows;

namespace StudyWithPatron
{
    public static class Globals
    {
        private static bool checks_Sound;
        private static string? name;
        private static int result;

        public static bool Checks_Sound { get => checks_Sound; set => checks_Sound = value; }
        public static string? Name { get => name; set => name = value; }
        public static int Result { get => result; set => result = value; }
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
                SoundPlayer playSound = new (Properties.ResourcesSounds.sound1);
                playSound.Play();
            }

            MenuWindow menu_win = new ();
            this.Visibility = Visibility.Hidden;
            menu_win.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new (Properties.ResourcesSounds.close);
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
