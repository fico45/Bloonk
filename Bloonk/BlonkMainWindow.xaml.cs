using Bloonk.DataAccess.DataModel;
using DataAccess.DataModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Bloonk.DataAccess;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bloonk
{
    /// <summary>
    /// Interaction logic for BlonkMainWindow.xaml
    /// </summary>
    public partial class BlonkMainWindow : Window, INotifyPropertyChanged
    {
        private List<Grad> gradovi;
        private List<Referenca> spolovi;
        private List<Referenca> krvneGrupe;

        private List<Statistika> statistikaKrvi;
        private List<Statistika> statistikaKrviGradovi;

        private Donor donor;
        private Donor noviDonor;

        public BlonkMainWindow()
        {
            InitializeComponent();
            var login = new Login();
            login.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Hide();

            login.ShowDialog();
            if (login.AuthData.korisnikAutentitciran)
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen;
                Show();
            }
            else
                Close();


            Gradovi = new List<Grad>(DalFactory.GradDataAcces.Gradovi);
            Spolovi = new List<Referenca>(DalFactory.ReferencaDataAccess.Spolovi);
            KrvneGrupe = new List<Referenca>(DalFactory.ReferencaDataAccess.KrvneGrupe);

            statistikaKrvi = new List<Statistika>(DalFactory.StatistikaData.StatKrvneGrupe());
            Chart statistikaKrviChart = FindName("Statistikakrvi") as Chart;
            statistikaKrviChart.DataSource = statistikaKrvi;
            statistikaKrviChart.Series["series"].XValueMember = "Naziv";
            statistikaKrviChart.Series["series"].YValueMembers = "Kolicina";


            statistikaKrviGradovi = new List<Statistika>(DalFactory.StatistikaData.StatKrvneGrupGradovi());
            Chart statistikaKrviGradChart = FindName("StatistikakrviGrad") as Chart;
            statistikaKrviChart.DataSource = statistikaKrvi;
            statistikaKrviChart.Series["series"].XValueMember = "Naziv";
            statistikaKrviChart.Series["series"].YValueMembers = "Kolicina";

            DonorSelected = new Donor();
            DonorNovi = new Donor();
        }



        public List<Referenca> KrvneGrupe
        {
            get { return krvneGrupe; }
            private set
            {
                krvneGrupe = value;
                OnPropertyChanged();
            }
        }

        public List<Referenca> Spolovi
        {
            get { return spolovi; }
            private set
            {
                spolovi = value;
                OnPropertyChanged();
            }
        }

        public List<Grad> Gradovi
        {
            get { return gradovi; }
            private set
            {
                gradovi = value;
                OnPropertyChanged();
            }
        }

        public Donor DonorSelected
        {
            get { return donor; }
            set
            {
                donor = value;
                OnPropertyChanged();
            }
        }

        public Donor DonorNovi
        {
            get { return noviDonor; }
            set
            {
                noviDonor = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
