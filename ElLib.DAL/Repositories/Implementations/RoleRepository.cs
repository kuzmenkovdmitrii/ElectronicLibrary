﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class RoleRepository : CommonRepository<Role>, IRoleRepository
    {
        public RoleRepository(
            IProcedureExecuter executer,
            IConverter<Role> converter,
            IParameters<Role> parameters)
            : base(executer)
        {
            EntityName = "Role";
            TableName = "Roles";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<Role> GetByUserId(int? id)
        {
            string storedProcedure = "usp_Select" + TableName + "ByUserId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }

        public Role GetByName(string name)
        {
            string storedProcedure = "usp_Select" + EntityName + "ByName";

            Executer.Parameters.Add(new SqlParameter("@Name", name));

            return Converter.FromTable(Executer.Execute(storedProcedure)).FirstOrDefault();
        }
    }
}
