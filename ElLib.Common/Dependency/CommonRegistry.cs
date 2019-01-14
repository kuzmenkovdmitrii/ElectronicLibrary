using ElLib.Common.Logger;
using ElLib.Common.ProcedureExecuter;
using StructureMap;

namespace ElLib.Common.Dependency
{
    public class CommonRegistry : Registry
    {
        public CommonRegistry()
        {
            For<ILogger>().Singleton().Use<Logger.Logger>();
            For<IProcedureExecuter>().Use<ProcedureExecuter.ProcedureExecuter>();
        }
    }
}
