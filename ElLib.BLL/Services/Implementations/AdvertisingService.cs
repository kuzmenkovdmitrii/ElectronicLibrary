using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using ElLib.BLL.AdvSevice;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;

namespace ElLib.BLL.Services.Implementations
{
    public class AdvertisingService : Interfaces.IAdvertisingService
    {
        public IEnumerable<Advertising> GetRandomByCount(int? count)
        {
            ThrowException.CheckNull(count);

            Uri address = new Uri("http://localhost:50817/IAdvertisingService");

            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<IAdvertisingService> factory = new ChannelFactory<IAdvertisingService>(binding, endpoint);

            IAdvertisingService channel = factory.CreateChannel();


            //var val = channel.GetRandomByCount(6);

            //object cannel = OperationContext.Current.GetCallbackChannel<>();

            //BLL.Services.Interfaces.IAdvertisingService channel = OperationContext.Current.GetCallbackChannel<BLL.Services.Interfaces.IAdvertisingService>();


            return null;
        }
    }
}
