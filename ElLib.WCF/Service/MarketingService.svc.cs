using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using ElLib.WCF.Entity;

namespace ElLib.WCF.Service
{
    public class MarketingService : IMarketingService
    {
        public IEnumerable<Marketing> GetAll(int id)
        {
            ICollection<Marketing> list = new List<Marketing>()
            {
                new Marketing()
                {
                    Id = 1,
                    Picture = new Url("http://photo.ru/1")
                },
                new Marketing()
                {
                    Id = 2,
                    Picture = new Url("http://photo.ru/2")
                }
            };
            return list;
        }

        public Marketing GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
