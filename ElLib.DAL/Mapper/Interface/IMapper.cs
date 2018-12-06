using System.Collections.Generic;
using System.Data;

namespace ElLib.DAL.Mapper.Interface
{
    public interface IMapper<T>
        where T: class
    {
        IEnumerable<T> FromTable(DataTable table);
        DataTable ToTable(T item);
    }
}
