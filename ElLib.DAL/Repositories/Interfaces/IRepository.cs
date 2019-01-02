using System.Collections.Generic;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
