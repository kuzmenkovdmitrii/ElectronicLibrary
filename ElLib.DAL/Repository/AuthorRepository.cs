using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> List()
        {
            throw new NotImplementedException();
        }

        public Task<Author> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Author item)
        {
            throw new NotImplementedException();
        }

        public void Update(Author item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
