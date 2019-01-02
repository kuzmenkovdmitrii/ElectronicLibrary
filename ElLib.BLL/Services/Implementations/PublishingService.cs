using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class PublishingService : IPublishingService
    {
        IPublishingRepository publishingRepository;

        public PublishingService(IPublishingRepository publishingRepository)
        {
            this.publishingRepository = publishingRepository;
        }

        public IEnumerable<Publishing> GetAll()
        {
            return publishingRepository.GetAll();
        }

        public IEnumerable<Publishing> GetByBookId(int id)
        {
            return publishingRepository.GetPublishingsByBookId(id);
        }

        public Publishing GetById(int id)
        {
            return publishingRepository.GetById(id);
        }

        public OperationDetails Create(Publishing item)
        {
            try
            {
                publishingRepository.Create(item);
                return new OperationDetails(true, "Издательство успешно создано");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании издательства");
            }
        }

        public OperationDetails Update(Publishing item)
        {
            try
            {
                publishingRepository.Update(item);
                return new OperationDetails(true, "Издательство успешно обновлено");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении издательства");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                publishingRepository.Delete(id);
                return new OperationDetails(true, "Издательство успешно удалено");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении издательства");
            }
        }
    }
}
