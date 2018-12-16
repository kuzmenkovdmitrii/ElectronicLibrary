using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.BLL.Service
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

        public Language GetById(int id)
        {
            return languageRepository.GetById(id);
        }

        public OperationDetails Create(Language item)
        {
            try
            {
                languageRepository.Create(item);
                return new OperationDetails(true, "Язык успешно создан");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании языка");
            }
        }

        public OperationDetails Update(Language item)
        {
            try
            {
                languageRepository.Update(item);
                return new OperationDetails(true, "Язык успешно обновлён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении языка");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                languageRepository.Delete(id);
                return new OperationDetails(true, "Язык успешно удалён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении языка");
            }
        }
    }
}
