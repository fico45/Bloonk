using System.Collections.Generic;

namespace Bloonk.DataAccess.Interfaces
{
    public interface Idbclient<T>
    {
         T Get(string code);
         bool Save(T model);
         bool Delete(T model);
         bool Update(T model);
    }
}
