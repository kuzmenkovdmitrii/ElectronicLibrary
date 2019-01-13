using ElLib.BLL.Dependency;
using ElLib.Common.Dependency;
using ElLib.DAL.Dependency;
using ElLib.WCF.Dependency;
using StructureMap;

namespace ElLib.Dependency
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.AssemblyContainingType<WCFRegistry>();
                scan.AssemblyContainingType<DALRegistry>();
                scan.AssemblyContainingType<BLLRegistry>();
                scan.AssemblyContainingType<CommonRegistry>();

                scan.LookForRegistries();
            });
        }
    }
}
