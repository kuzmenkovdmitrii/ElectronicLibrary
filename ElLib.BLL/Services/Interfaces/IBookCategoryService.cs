using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IBookCategoryService : IService<BookCategory>
    {
        IEnumerable<BookCategory> Search(string query);
    }
}
