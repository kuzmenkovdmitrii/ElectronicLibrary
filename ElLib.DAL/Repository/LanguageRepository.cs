using System.Configuration;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    class LanguageRepository : CommonRepository<Language>, ILanguageRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public LanguageRepository(IConverter<Language> converter, IProcedureExecuter executer)
            : base(executer)
        {
            ConnectionString = connectionString;
            EntityName = "Language";
            TableName = "Languages";
            Converter = converter;
        }
    }
}
