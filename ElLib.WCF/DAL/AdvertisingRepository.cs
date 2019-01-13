using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
using ElLib.WCF.Converter;

namespace ElLib.WCF.DAL
{
    public class AdvertisingRepository : IAdvertisingRepository
    {
        private string connectionStrings = ConfigurationManager.ConnectionStrings["ElLibWCFDB"].ConnectionString;

        public IEnumerable<Advertising> GetRandomByCount(int count)
        {
            ThrowException.CheckNull(count);

            ProcedureExecuter executer = new ProcedureExecuter();

            executer.ConnectionString = connectionStrings;

            string storedProcedure = "usp_SelectRandomAdvertisingByCount";

            executer.Parameters.Add(new SqlParameter("@Count", count));

            return executer.Execute(storedProcedure, new AdvertisingConverter());
        }
    }
}