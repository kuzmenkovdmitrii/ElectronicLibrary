using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface ILanguageService : IService<Language>
    {
        bool CheckName(string name);
    }
}
