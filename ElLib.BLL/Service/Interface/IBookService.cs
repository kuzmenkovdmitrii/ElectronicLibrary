using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        void Create(Book item);
        void Update(Book item);
        void Delete(int id);
    }
}
