using System;
using System.ServiceModel;
using ElLib.BLL.Services.Implementations;
using ElLib.BLL.Services.Interfaces;

namespace ElLib.WCF
{
    public static class InitializeChannel
    {
        //public static IAdvertisingService1 CreateChannel()
        //{
        //    Uri address = new Uri("http://localhost:50817/");

        //    BasicHttpBinding binding = new BasicHttpBinding();

        //    EndpointAddress endpoint = new EndpointAddress(address);

        //    ChannelFactory<IAdvertisingService1> factory = new ChannelFactory<IAdvertisingService1>(binding, endpoint);

        //    IAdvertisingService1 channel = factory.CreateChannel();

        //    //object cannel = OperationContext.Current.GetCallbackChannel<>();

        //    //BLL.Services.Interfaces.IAdvertisingService channel = OperationContext.Current.GetCallbackChannel<BLL.Services.Interfaces.IAdvertisingService>();

        //    return channel;
        //}
    }
}