using System.Collections.Generic;
using ElLib.BLL.Infrastructure;

namespace ElLib.BLL.Service.Interface
{
    public interface IService<T>
        where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        OperationDetails Create(T item);
        OperationDetails Update(T item);
        OperationDetails Delete(int id);
    }
}
