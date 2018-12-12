﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ElLib.DAL.StoredProcedure
{
    public interface IProcedureExecuter
    {
        ICollection<SqlParameter> Parameters { get; set; }

        void ExecuteVoid(string storedProcedure);
        DataTable Execute(string storedProcedure);
    }
}
