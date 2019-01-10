using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IBookService : IService<Book>
    {
        IEnumerable<Book> Search(string query);
    }
}
