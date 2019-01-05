using System.Data.SqlClient;

namespace ElLib.Common.Converter
{
    public interface IConverter<T>
        where T: class
    {
        T FromReader(SqlDataReader reader);
    }
}