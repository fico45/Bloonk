using Bloonk.DataAccess.Repository;
using DataAccess.Repository;

namespace Bloonk.DataAccess
{
    public static class DalFactory
    {
        private static DonorDataAccess donor;
        private static ReferencaDataAccess reference;
        private static GradDataAccess gradovi;
        private static KorisnikDataAccess korisnik;
        private static StatistikaDataAccess statistika;

        public static StatistikaDataAccess StatistikaData
        {
            get { return statistika ?? (statistika = new StatistikaDataAccess()); }
        }

        public static KorisnikDataAccess KorisnikData
        {
            get { return korisnik ?? (korisnik = new KorisnikDataAccess()); }
        }
        public static DonorDataAccess DonorData
        {
            get { return donor ?? (donor = new DonorDataAccess()); }
        }

        public static GradDataAccess GradDataAcces
        {
            get { return gradovi ?? (gradovi = new GradDataAccess()); }
        }

        public static ReferencaDataAccess ReferencaDataAccess
        {
            get
            {
                return reference ?? (reference = new ReferencaDataAccess());
            }
        }
    }
}
