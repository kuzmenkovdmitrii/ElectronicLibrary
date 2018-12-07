using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ElLib.DAL.Converter.Interface
{
    public interface IConverter<T>
        where T: class
    {
        IEnumerable<T> FromTable(DataTable table);
        IEnumerable<SqlParameter> AddParameters(T item);
    }
}
