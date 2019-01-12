using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    class LanguageRepository : CommonRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(
            IProcedureExecuter executer,
            IParameters<Language> parameters,
            IConverter<Language> converter)
            : base(executer)
        {
            EntityName = "Language";
            TableName = "Languages";
            Parameters = parameters;
            Converter = converter;
        }

        public Language GetByName(string name)
        {
            ThrowException.CheckNull(name);

            string storedProcedure = "usp_Select" + EntityName + "ByName";

            Executer.Parameters.Add(new SqlParameter("@Name", name));

            return Executer.Execute(storedProcedure, Converter).FirstOrDefault();
        }
    }
}
