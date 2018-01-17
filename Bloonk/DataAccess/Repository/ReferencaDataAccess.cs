using Bloonk.DataAccess.Repository;
using DataAccess.DataModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Repository
{
    public sealed class ReferencaDataAccess 
    {
        private List<Referenca> _reference;
        public ReferencaDataAccess()
        {
            _reference = new List<Referenca>();
            GetReferenceList();
        }

        private void GetReferenceList()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT Id, TipReferencaID, Naziv FROM Referenca", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                        {
                            foreach (DataRow row in table.Rows)
                                _reference.Add(Referenca.Parse(row));
                        }
                    }
                }
            }
        }

        public List<Referenca> KrvneGrupe
        {
            get { return _reference.FindAll(referenca => referenca.TipReferencaID == 1); }
        }

        public List<Referenca> Spolovi
        {
            get { return _reference.FindAll(referenca => referenca.TipReferencaID == 2); }
        }
    }
}
