using System.Media;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using StudyWithPatron.DAL;

namespace StudyWithPatron
{
    /// <summary>
    /// Interaction logic for RatingWindow.xaml
    /// </summary>
    public partial class RatingWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public RatingWindow()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
            db.UserScore.Load();
            DataContext = db.UserScore.Local.ToObservableCollection();
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

            RegistrationWindow reg_win = new RegistrationWindow();
            this.Visibility = Visibility.Hidden;
            reg_win.Show();
        }
    }
}
