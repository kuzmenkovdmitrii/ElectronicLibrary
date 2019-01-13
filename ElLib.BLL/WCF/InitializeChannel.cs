using System;
using System.ServiceModel;
using ElLib.BLL.AdvSevice;

namespace ElLib.BLL.WCF
{
    public static class InitializeChannel
    {
        public static IAdvertisingService CreateChannel()
        {
            Uri address = new Uri("http://localhost:50817/AdvertisingService.svc");

            BasicHttpBinding binding = new BasicHttpBinding();

            EndpointAddress endpoint = new EndpointAddress(address);

            ChannelFactory<IAdvertisingService> factory = new ChannelFactory<IAdvertisingService>(binding, endpoint);

            IAdvertisingService channel = factory.CreateChannel();

            return channel;
        }
    }
}