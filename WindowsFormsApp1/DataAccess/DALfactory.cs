using Bloonk.DataAccess.Repository;
using System;

namespace Bloonk.DataAccess
{
    public sealed class DALfactory
    {
        private static DonorDataAccess donor;

        public static DonorDataAccess DonorData
        {
            get { return donor ?? (donor = new DonorDataAccess()); }
        }
    }


}
