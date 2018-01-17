using Bloonk.DataAccess;
using Bloonk.DataAccess.DataModel;
using System.Windows;
using System.Windows.Controls;

namespace Bloonk.GUI.UserControls
{
    /// <summary>
    /// Interaction logic for NoviDonorUserControl.xaml
    /// </summary>
    public partial class NoviDonorUserControl : UserControl
    {
        public NoviDonorUserControl()
        {
            InitializeComponent();
        }

        private void SpremiNovogDonora(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as BlonkMainWindow;
            if (window != null)
            {
                var donor = window.DonorNovi;
                if (donor != null)
                {
                    if (string.IsNullOrEmpty(donor.Ime)) MessageBox.Show("Ime je obavezan podatak;");
                    if (string.IsNullOrEmpty(donor.Prezime)) MessageBox.Show("Prezime je obavezan podatak;");
                    if (string.IsNullOrEmpty(donor.Oib)) MessageBox.Show("Oib je obavezan podatak;");
                    if (string.IsNullOrEmpty(donor.KontaktBroj)) MessageBox.Show("Kontakt broj je obavezan podatak;");
                    if (donor.KrvaGrupa.ID == 0) MessageBox.Show("Krvna grupa je obavezan podatak");
                    if (donor.Mjesto.ID == 0) MessageBox.Show("Mjesto stanovanja je obavezan podatak");
                    if (donor.Spol.ID == 0) MessageBox.Show("Spol je obavezan podatak");
                    if (donor.RodjenDatum == null) MessageBox.Show("Datum rođenja je obavezan podatak");
 
                    if (DalFactory.DonorData.UpdateSave(donor))
                    {
                        MessageBox.Show("Promjene su uspješno snimljene u bazu donora");
                        window.DonorNovi = new Donor();
                    }
                }
            }
        }

        private void ResetirajFormu(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as BlonkMainWindow;
            if (window != null)
            {
                window.DonorNovi = new Donor();
            }
        }
    }
}
