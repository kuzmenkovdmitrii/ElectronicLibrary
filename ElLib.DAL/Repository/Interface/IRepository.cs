using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElLib.DAL.Repository.Interface
{
    public interface IRepository<T>
        where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
