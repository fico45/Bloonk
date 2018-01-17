using Bloonk.DataAccess;
using System.Windows;
using System.Windows.Controls;

namespace Bloonk.GUI.UserControls
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public bool korisnikAutentitciran { get; private set; }
        public bool korisnikOdustao { get; private set; }
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void OdustaniOdPrijave(object sender, RoutedEventArgs e)
        {
            korisnikOdustao = true;
            korisnikAutentitciran = false;
            var window = Window.GetWindow(this);
            window.Close();
        }
        private void LoginKorisnika(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameBox.Text) ||
               string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Niste unijeli podatke za prijavu u sustav", "Login info", MessageBoxButton.OK);
                korisnikAutentitciran = false;
                return;
            }

            var Korisnik = DalFactory.KorisnikData.GetKorisnik(UserNameBox.Text);
            if (Korisnik == null)
            {
                MessageBox.Show("Nepoznat korisnik");
                UserNameBox.Clear();
                PasswordBox.Clear();
                return;
            }

            if (string.Compare(Korisnik.Sifra, PasswordBox.Password, true) == 0)
            {
                korisnikAutentitciran = true;
                var window = Window.GetWindow(this);
                window.Close();
            }
            else
            {
                MessageBox.Show("Nepoznat korisnik");
                UserNameBox.Clear();
                PasswordBox.Clear();
                korisnikAutentitciran = false;
            }
        }
    }
}
