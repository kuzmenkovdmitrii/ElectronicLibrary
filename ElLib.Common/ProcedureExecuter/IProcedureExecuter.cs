using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Converter;

namespace ElLib.Common.ProcedureExecuter
{
    public interface IProcedureExecuter
    {
        string ConnectionString { get; set; }
        ICollection<SqlParameter> Parameters { get; set; }

        void ExecuteVoid(string storedProcedure);

        IEnumerable<T> Execute<T>(string storedProcedure, IConverter<T> converter)
            where T : class;
    }
}
