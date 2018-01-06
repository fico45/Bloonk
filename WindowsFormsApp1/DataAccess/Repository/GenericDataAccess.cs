using Bloonk.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bloonk.DataAccess.Repository
{
    public abstract class GenericDataAccess<T> : Idbclient<T>
    {
        public abstract bool Delete(T model);
        public abstract T Get(string code);
        public abstract bool Save(T model);
        public abstract bool Update(T model);
        protected abstract T Parse(DataRow DbRow);
    }
}
