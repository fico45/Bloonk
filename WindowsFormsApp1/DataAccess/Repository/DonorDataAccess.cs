using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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
            var connection = SqlHelper.Instance.Connection;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            connection.Close();
            connection.Dispose();
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
            throw new NotImplementedException();
        }
    }
}
