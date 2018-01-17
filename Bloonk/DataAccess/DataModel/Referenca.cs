using System.Data;
namespace DataAccess.DataModel
{
    public class Referenca
    {
        private int _id;
        private int _tipReferencaId;
        private string _naziv;
       public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
       public int TipReferencaID
        {
            get { return _tipReferencaId; }
            set { _tipReferencaId = value; }
        }
	   public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public static Referenca Parse(DataRow row)
        {
            return new Referenca
            {
                ID = row.Field<int>("ID"),
                TipReferencaID = row.Field<int>("TipReferencaID"),
                Naziv = row.Field<string>("Naziv")
            };
        }
    }
}
