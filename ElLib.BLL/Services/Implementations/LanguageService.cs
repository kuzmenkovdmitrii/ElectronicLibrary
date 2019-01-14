using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.BLL.Services.Interfaces;
using ElLib.BLL.ValidationInfo;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository languageRepository;

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
            ThrowException.CheckId(id);

            return languageRepository.GetById(id);
        }

        public OperationDetails Create(Language item)
        {
            ThrowException.CheckNull(item);

            try
            {
                languageRepository.Create(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании языка");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Update(Language item)
        {
            ThrowException.CheckNull(item);

            try
            {
                languageRepository.Update(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении языка");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            try
            {
                languageRepository.Delete(id);
            }
            catch (SqlException e)
            {
                return new OperationDetails(false, "Не удалось удалить язык, так как есть книги связанные с языком");
            }

            return new OperationDetails(true);
        }

        public bool CheckName(string name)
        {
            ThrowException.CheckNull(name);

            Language language = languageRepository.GetByName(name);

            if (language == null)
            {
                return true;
            }

            return false;
        }
    }
}
