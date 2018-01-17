
using System.Data;


namespace DataAccess.DataModel
{
    public class Grad
    {
        private int _id;
        private string _postanskiBroj;
        private string _naziv;
        public int ID
        {
            get { return _id; }
            set { _id = value; } 
        }
        public string PostanskiBroj
        {
            get { return _postanskiBroj; }
            set { _postanskiBroj = value; }
        }
        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public static Grad Parse(DataRow row)
        {
            return new Grad
            {
                ID = row.Field<int>("ID"),
                PostanskiBroj = row.Field<string>("PostanskiBroj"),
                Naziv = row.Field<string>("Naziv")
            };
        }
    }
}
