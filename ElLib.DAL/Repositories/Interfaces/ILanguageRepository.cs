using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface ILanguageRepository : IRepository<Language>
    {
        Language GetByName(string name);
    }
}
