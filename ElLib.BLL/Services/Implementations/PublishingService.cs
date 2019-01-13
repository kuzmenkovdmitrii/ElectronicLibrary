using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            try
            {
                publishingRepository.Create(item);
            }
            catch (Exception)
            {
                return new OperationDetails(true, "Произошла ошибка при создании издательства");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Update(Publishing item)
        {
            ThrowException.CheckNull(item);

            try
            {
                publishingRepository.Update(item);
            }
            catch (Exception)
            {
                return new OperationDetails(true, "Произошла ошибка при обновлении издательства");
            }
            
            return new OperationDetails(true);
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            try
            {
                publishingRepository.Delete(id);
            }
            catch (SqlException)
            {
                return new OperationDetails(false, "Не удалось удалить издательство, так как есть книги связанные с издательством");
            }

            return new OperationDetails(true);
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
