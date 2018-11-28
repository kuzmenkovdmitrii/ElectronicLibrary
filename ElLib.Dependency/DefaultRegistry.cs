using ElLib.BLL.Dependency;
using ElLib.DAL.Dependency;
using StructureMap;

namespace ElLib.Dependency
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.AssemblyContainingType<DALRegistry>();
                scan.AssemblyContainingType<BLLRegistry>();

                scan.LookForRegistries();
            });
        }
    }
}
