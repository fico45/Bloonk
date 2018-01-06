using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Bloonk.DataAccess.Repository
{
    internal sealed class SqlHelper
    {
        private readonly string SqlConnectionString;
        public SqlConnection Connection { get; private set; }
        private static SqlHelper instance;

        private SqlHelper()
        {
            SqlConnectionString = ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString;
            if (string.IsNullOrEmpty(SqlConnectionString))
                throw new Exception("Connection string not found in app.xml");
            Connection = new SqlConnection(SqlConnectionString);
        }

        public static SqlHelper Instance
        {
            get { return instance ?? (instance = new SqlHelper()); }
        }
    }
}
