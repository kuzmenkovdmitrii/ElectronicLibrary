using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class LanguageService : ILanguageService
    {
        readonly ILanguageRepository languageRepository;
        public LanguageService(ILanguageRepository languageRepository)
        {
            this.languageRepository = languageRepository;
        }

        public IEnumerable<Language> GetAll()
        {
            return languageRepository.GetAll();
        }

        public Language GetById(int? id)
        {
            ThrowException.CheckNull(id);

            return languageRepository.GetById(id);
        }

        public OperationDetails Create(Language item)
        {
            ThrowException.CheckNull(item);

            languageRepository.Create(item);

            return new OperationDetails(true, "Язык успешно создан");
        }

        public OperationDetails Update(Language item)
        {
            ThrowException.CheckNull(item);

            languageRepository.Update(item);

            return new OperationDetails(true, "Язык успешно обновлён");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckNull(id);

            languageRepository.Delete(id);

            return new OperationDetails(true, "Язык успешно удалён");
        }

        public bool CheckName(string name)
        {
            Language language = languageRepository.GetByName(name);

            return language == null;
        }
    }
}
