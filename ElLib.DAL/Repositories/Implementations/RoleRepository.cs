using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
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
            ThrowException.CheckNull(id);

            string storedProcedure = "usp_Select" + TableName + "ByUserId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute(storedProcedure,Converter);
        }

        public Role GetByName(string name)
        {
            ThrowException.CheckNull(name);

            string storedProcedure = "usp_Select" + EntityName + "ByName";

            Executer.Parameters.Add(new SqlParameter("@Name", name));

            return Executer.Execute(storedProcedure,Converter).FirstOrDefault();
        }

        public void AddRoleToUser(User user, Role role)
        {
            ThrowException.CheckNull(user);
            ThrowException.CheckNull(role);

            string storedProcedure = "usp_AddRoleToUser";

            Executer.Parameters.Add(new SqlParameter("@UserId", user.Id));
            Executer.Parameters.Add(new SqlParameter("@RoleId", role.Id));

            Executer.ExecuteVoid(storedProcedure);
        }
    }
}
