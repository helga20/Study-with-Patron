using Microsoft.EntityFrameworkCore;
using StudyWithPatron.DAL;
using System.Media;
using System.Windows;

namespace StudyWithPatron
{
    /// <summary>
    /// Interaction logic for RatingWindow.xaml
    /// </summary>
    public partial class RatingWindow : Window
    {
        readonly ApplicationContext db = new ();
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
                SoundPlayer playSound = new (Properties.ResourcesSounds.close);
                playSound.Play();
            }
            Close();
        }

        private void Back_Menu_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.Checks_Sound == true)
            {
                SoundPlayer playSound = new (Properties.ResourcesSounds.back);
                playSound.Play();
            }

            RegistrationWindow reg_win = new ();
            this.Visibility = Visibility.Hidden;
            reg_win.Show();
        }
    }
}
