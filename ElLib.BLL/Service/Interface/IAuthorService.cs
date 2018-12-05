using System.Collections.Generic;
using System.Threading.Tasks;
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
