using ElLib.WCF.DAL;
using StructureMap;

namespace ElLib.WCF.Dependency
{
    public class WCFRegistry : Registry
    {
        public WCFRegistry()
        {
            For<IAdvertisingRepository>().Use<AdvertisingRepository>();
        }
    }
}