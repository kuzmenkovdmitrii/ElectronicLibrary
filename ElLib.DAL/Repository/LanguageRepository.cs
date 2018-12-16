using System.Configuration;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    class LanguageRepository : CommonRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(IParameters<Language> parameters, IConverter<Language> converter, IProcedureExecuter executer)
            : base(executer)
        {
            EntityName = "Language";
            TableName = "Languages";
            Parameters = parameters;
            Converter = converter;
        }
    }
}
