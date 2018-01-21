using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Bloonk.DataAccess.DataModel;
using System.Configuration;
using System.Diagnostics;

namespace Bloonk.DataAccess.Repository
{
    public sealed class DonorDataAccess
    {
        public List<Donor> ZahvatiListuDonora(string oib)
        {
            List<Donor> lista = new List<Donor>();

            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
            {
                using (var cmd = new SqlCommand("Donor_Select", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@oib", string.IsNullOrEmpty(oib) ? (object)DBNull.Value : oib);
                    conn.Open();
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        if (table.Rows != null && table.Rows.Count > 0)
                            foreach (DataRow row in table.Rows)
                                lista.Add(Donor.Parse(row));
                    }
                }
            }

            return lista;
        }


        public bool UpdateSave(Donor donor)
        {
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("DONOR_UPDATE", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", donor.Id);
                        cmd.Parameters.AddWithValue("@Ime", donor.Ime);
                        cmd.Parameters.AddWithValue("@Prezime", donor.Prezime);
                        cmd.Parameters.AddWithValue("@Oib", donor.Oib);
                        cmd.Parameters.AddWithValue("@RodjenDatum", donor.RodjenDatum);
                        cmd.Parameters.AddWithValue("@GradId", donor.Mjesto.ID);
                        cmd.Parameters.AddWithValue("@Spol", donor.Spol.ID);
                        cmd.Parameters.AddWithValue("@KrvaGrupa", donor.KrvaGrupa.ID);
                        cmd.Parameters.AddWithValue("@KontaktBroj", donor.KontaktBroj);
                        cmd.Parameters.AddWithValue("@AktivanDonor", donor.AktivanDonor);
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

            return true;
        }

        public bool Delete(Donor donor)
        {

            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString))
                {
                    using (var cmd = new SqlCommand("Donor_Delete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", donor.Id);
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}