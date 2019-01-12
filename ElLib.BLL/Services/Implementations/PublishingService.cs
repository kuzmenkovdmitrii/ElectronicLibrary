using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
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

        public Publishing GetById(int? id)
        {
            ThrowException.CheckId(id);

            return publishingRepository.GetById(id);
        }

        public OperationDetails Create(Publishing item)
        {
            ThrowException.CheckNull(item);

            publishingRepository.Create(item);

            return new OperationDetails(true, "Издательство успешно создано");
        }

        public OperationDetails Update(Publishing item)
        {
            ThrowException.CheckNull(item);

            publishingRepository.Update(item);

            return new OperationDetails(true, "Издательство успешно обновлено");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            publishingRepository.Delete(id);

            return new OperationDetails(true, "Издательство успешно удалено");
        }

        public IEnumerable<Publishing> Search(string query)
        {
            ThrowException.CheckNull(query);

            return publishingRepository.GetByQuery(query);
        }

        public bool CheckName(string name)
        {
            ThrowException.CheckNull(name);

            Publishing publishing = publishingRepository.GetByName(name);

            return publishing == null;
        }
    }
}
