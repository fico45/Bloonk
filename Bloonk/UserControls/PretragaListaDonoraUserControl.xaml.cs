using Bloonk.DataAccess;
using Bloonk.DataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
namespace Bloonk.GUI.UserControls
{
    /// <summary>
    /// Interaction logic for PretragaListaDonoraUserControl.xaml
    /// </summary>
    public partial class PretragaListaDonoraUserControl : UserControl, INotifyPropertyChanged
    {

        private List<Donor> _donorList;
        public PretragaListaDonoraUserControl()
        {
            InitializeComponent();
            _donorList = new List<Donor>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Search(object sender, RoutedEventArgs e)
        {
            string oib = OibTextBox.Text;
            _donorList.Clear();
            Donori.AddRange(DalFactory.DonorData.ZahvatiListuDonora(oib));
            DonoriGrid.ItemsSource = Donori;
        }

        public List<Donor> Donori
        {
            get { return _donorList; }
            private set
            {
                _donorList = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Donori"));
            }
        }

        public void DonorAdd(Donor donor)
        {
            if (Donori.Count > 0)
                Donori.Add(donor);
        }

        public void DonorRemove(Donor donor)
        {
            if (Donori.Count > 0 && !Donori.Contains(donor))
                Donori.Remove(donor);
        }

        private void DonoriGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
