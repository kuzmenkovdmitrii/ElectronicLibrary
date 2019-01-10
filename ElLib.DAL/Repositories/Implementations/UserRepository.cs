using System;
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
    public class UserRepository : CommonRepository<User>, IUserRepository
    {
        public UserRepository(
            IProcedureExecuter executer,
            IParameters<User> parameters,
            IConverter<User> converter)
            : base(executer)
        {
            EntityName = "User";
            TableName = "Users";
            Parameters = parameters;
            Converter = converter;
        }

        public User GetByUserName(string userName)
        {
            ThrowException.CheckNull(userName);

            string storedProcedure = "usp_Select" + EntityName + "ByUserName";

            Executer.Parameters.Add(new SqlParameter("@UserName", userName));

            return Executer.Execute<User>(storedProcedure,Converter).FirstOrDefault();
        }

        public IEnumerable<User> GetByQuery(string query)
        {
            ThrowException.CheckNull(query);

            string storedProcedure = "usp_Select" + TableName + "ByQuery";

            Executer.Parameters.Add(new SqlParameter("@Query", query));

            return Executer.Execute<User>(storedProcedure, Converter);
        }

        public void Create(User item, string password)
        {
            ThrowException.CheckNull(item);
            ThrowException.CheckNull(password);

            string storedProcedure = "usp_Create" + EntityName;

            Executer.Parameters = Parameters.GetParameters(item).Where(x => x.ParameterName != "@Id").ToList();
            Executer.Parameters.Add(new SqlParameter("@password", password));

            Executer.ExecuteVoid(storedProcedure);
        }

        public string GetPassword(int? id)
        {
            ThrowException.CheckNull(id);

            string storedProcedure = "usp_SelectPasswordByUserId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            //TODO
            //return Executer.Execute(storedProcedure).Rows[0][0].ToString();
            return null;
        }
    }
}
