using System.Collections.Generic;
using System.Data.SqlClient;

namespace ElLib.DAL.Parameters.Interface
{
    public interface IParameters<T>
        where T:class
    {
        IEnumerable<SqlParameter> GetParameters(T item);
    }
}
