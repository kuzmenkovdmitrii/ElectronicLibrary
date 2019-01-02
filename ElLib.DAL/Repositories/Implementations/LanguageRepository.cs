using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
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
