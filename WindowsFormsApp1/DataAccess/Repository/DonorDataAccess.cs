using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Bloonk.DataAccess.DataModel;

namespace Bloonk.DataAccess.Repository
{
    public sealed class DonorDataAccess : GenericDataAccess<Donor>
    {
        public override bool Delete(Donor model)
        {
            throw new NotImplementedException();
        }

        public override Donor Get(string code)
        {
            using (var conn = SqlHelper.Instance.Connection)
            {
                using (var cmd = new SqlCommand("get_donor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@oib", code);
                    conn.Open();
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                            return Parse(table.Rows[0]);
                    }
                }
            }

            return null;
        }

        public override bool Save(Donor model)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Donor model)
        {
            throw new NotImplementedException();
        }

        protected override Donor Parse(DataRow DbRow)
        {
            return new Donor
            {
                Ime = DbRow.Field<string>("ime"),
                Prezime = DbRow.Field<string>("prezime"),
                Oib = DbRow.Field<string>("oib"),
                Datum_rodenja = DbRow.Field<DateTime>("datum_rodenja"),
                Grad = DbRow.Field<string>("grad"),
                Br_mobitela = DbRow.Field<string>("br_mobitela"),
                Datum = DbRow.Field<DateTime>("datum"),
                Id = DbRow.Field<int>("Id"),
                SpolDonor = Donor.MapirajSpol(DbRow.Field<int>("spol")),
                KrvnaGrupa = Donor.MapirajKrvnuGrupu(DbRow.Field<string>("krvna_grupa"))
            };

        }
    }
}

