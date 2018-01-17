using Bloonk.DataAccess.Repository;
using DataAccess.DataModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Repository
{
    public sealed class GradDataAccess
    {
        private List<Grad> _gradLista;
        public GradDataAccess()
        {
            _gradLista = new List<Grad>();
            GetGradLista();
        }

        private void GetGradLista()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT Id, PostanskiBroj, Naziv FROM Grad", conn))
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
                                _gradLista.Add(Grad.Parse(row));
                        }
                    }
                }
            }
        }

        public List<Grad> Gradovi
        {
            get { return _gradLista; }
        }
    }
}
