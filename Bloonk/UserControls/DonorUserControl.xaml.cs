using Bloonk.DataAccess;
using Bloonk.DataAccess.DataModel;
using System.Windows;
using System.Windows.Controls;


namespace Bloonk.GUI.UserControls
{
    /// <summary>
    /// Interaction logic for DonorUserControl.xaml
    /// </summary>
    public partial class DonorUserControl : UserControl
    {
        public DonorUserControl()
        {
            InitializeComponent();
        }

        private void SpremiPromjene(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this) as BlonkMainWindow;
            if (window != null)
            {
                var donor = window.DonorSelected;
                if (donor != null)
                {
                    if (string.IsNullOrEmpty(donor.Ime)) { MessageBox.Show("Ime je obavezan podatak;"); return; }
                    if (string.IsNullOrEmpty(donor.Prezime)) { MessageBox.Show("Prezime je obavezan podatak;"); return; }
                    if (string.IsNullOrEmpty(donor.Oib)) { MessageBox.Show("Oib je obavezan podatak;"); return; }
                    if (string.IsNullOrEmpty(donor.KontaktBroj)) { MessageBox.Show("Kontakt broj je obavezan podatak;"); return; }
                    if (donor.KrvaGrupa.ID == 0) { MessageBox.Show("Krvna grupa je obavezan podatak"); return; }
                    if (donor.Mjesto.ID == 0) { MessageBox.Show("Mjesto stanovanja je obavezan podatak"); return; }
                    if (donor.Spol.ID == 0) { MessageBox.Show("Spol je obavezan podatak"); return; }
                    if (donor.RodjenDatum == null) { MessageBox.Show("Datum rođenja je obavezan podatak"); return; }

                    var odgovor = MessageBox.Show("Jeste li sigurni da želite spremiti promjene?", "Upozorenje", MessageBoxButton.YesNo);
                    if (odgovor == MessageBoxResult.Yes)
                    {
                        if (DalFactory.DonorData.UpdateSave(donor))
                        {
                            MessageBox.Show("Promjene su uspješno snimljene u bazu donora");
                        }
                    }
                    
                }
            }
        }

        private void Obrisi(object sender, RoutedEventArgs e)
        {

            var window = Window.GetWindow(this) as BlonkMainWindow;
            if (window != null)
            {
                if (window.DonorSelected != null)
                {
                    var odgovor = MessageBox.Show("Jeste li sigurni da želite obrisati donora?", "Upozorenje", MessageBoxButton.YesNo);
                    if (odgovor == MessageBoxResult.Yes)
                    {
                        if (DalFactory.DonorData.Delete(window.DonorSelected))
                        {
                            window.DonorSelected = new Donor();
                            MessageBox.Show("Donor je uspješno obrisan iz baze podataka");
                        }
                    }
                }
            }
        }
    }
}
