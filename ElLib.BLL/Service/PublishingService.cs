using System.Collections.Generic;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.BLL.Service
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
            throw new System.NotImplementedException();
        }

        public Publishing GetById(int id)
        {
            return publishingRepository.GetById(id);
        }
    }
}
