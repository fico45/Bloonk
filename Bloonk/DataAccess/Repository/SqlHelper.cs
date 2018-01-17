using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Bloonk.DataAccess.Repository
{
    internal sealed class SqlHelper
    {
        private readonly SqlConnection _connection
            = new SqlConnection(ConfigurationManager.ConnectionStrings["Bloonk"].ConnectionString);
        private static SqlHelper instance = new SqlHelper();

        private SqlHelper() {}
        static SqlHelper() { }

        public static SqlHelper Instance
        {
            get { return instance; }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
