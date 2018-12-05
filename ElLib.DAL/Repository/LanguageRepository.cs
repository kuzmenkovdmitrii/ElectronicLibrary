using System.Collections.Generic;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    class LanguageRepository : CommonRepository, ILanguageRepository
    {
        public IEnumerable<Language> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Language GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Language item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Language item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
