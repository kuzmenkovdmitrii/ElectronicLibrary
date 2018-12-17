using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ElLib.Common.ProcedureExecuter
{
    public interface IProcedureExecuter
    {
        string ConnectionString { get; set; }
        ICollection<SqlParameter> Parameters { get; set; }

        void ExecuteVoid(string storedProcedure);
        DataTable Execute(string storedProcedure);
    }
}
