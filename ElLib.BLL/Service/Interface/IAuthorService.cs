using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IAuthorService
    {
        OperationDetails Create(Author author);
        IEnumerable<Author> GetAll();
    }
}
