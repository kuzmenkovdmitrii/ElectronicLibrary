using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IBookCategoryService : IService<BookCategory>
    {
        IEnumerable<BookCategory> Search(string query);
        bool CheckName(string name);
    }
}
