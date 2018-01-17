using System.Data;

namespace DataAccess.DataModel
{
    public class Statistika
    {
        public decimal Kolicina { get; set; }
        public string Naziv { get; set; }


        public static Statistika Parse(DataRow row)
        {
            return new Statistika
            {
                Kolicina = row.Field<decimal>("Kolicina"),
                Naziv = row.Field<string>("Naziv")
            };

        }
    }
}
