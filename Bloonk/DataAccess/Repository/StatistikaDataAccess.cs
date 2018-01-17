using DataAccess.DataModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Repository
{
    public sealed class StatistikaDataAccess
    {
        public List<Statistika> StatKrvneGrupe()
        {
            List<Statistika> lista = new List<Statistika>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT Kolicina, Naziv FROM KolicinaKrvi", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                            foreach (DataRow row in table.Rows)
                                lista.Add(Statistika.Parse(row));
                    }
                }
            }

            return lista;
        }


        public List<Statistika> StatKrvneGrupGradovi()
        {
            List<Statistika> lista = new List<Statistika>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT Kolicina, Naziv FROM StatistikaGrad", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                            foreach (DataRow row in table.Rows)
                                lista.Add(Statistika.Parse(row));
                    }
                }
            }

            return lista;
        }
    }
}
