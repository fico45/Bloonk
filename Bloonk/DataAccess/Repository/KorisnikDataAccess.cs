using DataAccess.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class KorisnikDataAccess
    {
        public Korisnik GetKorisnik(string korisnickoIme)
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                var sql = string.Format(@"SELECT * FROM Korisnik WHERE KorisnickoIme = '{0}'", korisnickoIme);
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                            return Korisnik.Parse(table.Rows[0]);
                    }
                }
            }

            return null;
        }
    }
}
