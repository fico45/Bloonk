
using System.Data;

namespace DataAccess.DataModel
{
    public class Korisnik
    {
        private int id;
        private string korisnickoIme;
        private string sifra;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        public static Korisnik Parse(DataRow row)
        {
            return new Korisnik
            {
                Id = row.Field<int>("ID"),
                KorisnickoIme = row.Field<string>("KorisnickoIme"),
                Sifra = row.Field<string>("Sifra")
            };
        }
    }
}
