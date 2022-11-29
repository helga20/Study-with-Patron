using System;
using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace StudyWithPatron
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
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
                playSound.Play();
            }

            RatingWindow rat_win = new RatingWindow();
            this.Visibility = Visibility.Hidden;
            rat_win.Show();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.close);
                playSound.Play();
            }

            Close();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.back);
                playSound.Play();
            }

            MenuWindow menu_win = new MenuWindow();
            this.Visibility = Visibility.Hidden;
            menu_win.Show();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new SoundPlayer(Properties.ResourcesSounds.sound1);
                playSound.Play();
            }

            if (String.IsNullOrEmpty(nickname_textbox.Text))
            {
                nickname_textbox.Background = Brushes.Red;

                if (Globals.Checks_Sound == true)
                {
                    SoundPlayer playSound1 = new SoundPlayer(Properties.ResourcesSounds.error);
                    playSound1.Play();
                }

                MessageBox.Show("Псевдонім не введено.\nПовторіть спробу");
            }
            else
            {
                Globals.name = nickname_textbox.Text.Trim();

                SaperWindow sap_win = new SaperWindow();
                this.Visibility = Visibility.Hidden;
                sap_win.Show();
            }
        }

        private void EnterClicked(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Start_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
