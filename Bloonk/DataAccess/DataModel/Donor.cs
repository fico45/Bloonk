using DataAccess.DataModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Bloonk.DataAccess.DataModel
{
    public class Donor : INotifyPropertyChanged
    {
        private int _id;
        private string _ime;
        private string _prezime;
        private string _oib;
        private DateTime _rodjenDatum;
        private Grad _mjesto;
        private Referenca _spol;
        private Referenca _krvnaGrupa;
        private string _kontaktBroj;
        private bool _aktivanDonor;
        private DateTime? _datumInsert;
        private DateTime? _datumUpdate;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(null, new PropertyChangedEventArgs(name));
        }

        public Donor()
        {
            _mjesto = new Grad();
            _spol = new Referenca();
            _krvnaGrupa = new Referenca();
        }
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Ime
        {
            get { return _ime; }
            set
            {
                _ime = value;
                OnPropertyChanged();
            }
        }
        public string Prezime
        {
            get { return _prezime; }
            set
            {
                _prezime = value;
                OnPropertyChanged();
            }
        }
        public string Oib
        {
            get { return _oib; }
            set
            {
                _oib = value;
                OnPropertyChanged();
            }
        }
        public DateTime? RodjenDatum
        {
            get
            {
                return _rodjenDatum == default(DateTime)
                 ? default(DateTime?)
                 : _rodjenDatum;
            }
            set
            {
                if (value.HasValue)
                    _rodjenDatum = value.Value;
                OnPropertyChanged();
            }
        }
        public Grad Mjesto
        {
            get { return _mjesto; }
            set
            {
                _mjesto = value;
                OnPropertyChanged();
            }
        }
        public Referenca Spol
        {
            get { return _spol; }
            set
            {
                _spol = value;
                OnPropertyChanged();
            }
        }
        public Referenca KrvaGrupa
        {
            get { return _krvnaGrupa; }
            set
            {
                _krvnaGrupa = value;
                OnPropertyChanged();
            }
        }
        public string KontaktBroj
        {
            get { return _kontaktBroj; }
            set
            {
                _kontaktBroj = value;
                OnPropertyChanged();
            }
        }
        public bool AktivanDonor
        {
            get { return _aktivanDonor; }
            set
            {
                _aktivanDonor = value;
                OnPropertyChanged();
            }
        }
        public DateTime? DatumInsert
        {
            get { return _datumInsert; }
            set
            {
                _datumInsert = value;

            }
        }
        public DateTime? DatumUpdate
        {
            get { return _datumUpdate; }
            set { _datumUpdate = value; }
        }

        public static Donor Parse(DataRow row)
        {
            return new Donor
            {
                Id = row.Field<int>("ID"),
                Ime = row.Field<string>("Ime"),
                Prezime = row.Field<string>("Prezime"),
                Oib = row.Field<string>("Oib"),
                RodjenDatum = row.Field<DateTime>("RodjenDatum"),
                Mjesto = DalFactory.GradDataAcces.Gradovi.Find(grad => grad.ID == row.Field<int>("GradId")),
                Spol = DalFactory.ReferencaDataAccess.Spolovi.Find(spol => spol.ID == row.Field<int>("Spol")),
                KrvaGrupa = DalFactory.ReferencaDataAccess.KrvneGrupe.Find(krvnaGrupa => krvnaGrupa.ID == row.Field<int>("KrvaGrupa")),
                KontaktBroj = row.Field<string>("KontaktBroj"),
                AktivanDonor = row.Field<bool>("AktivanDonor"),
                DatumInsert = row.Field<DateTime?>("DatumInsert"),
                DatumUpdate = row.Field<DateTime?>("DatumUpdate")
            };
        }
    }
}