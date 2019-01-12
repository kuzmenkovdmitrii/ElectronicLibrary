using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Implementations;
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

        public void UpdatePassword(User user, string password)
        {
            ThrowException.CheckNull(user);
            ThrowException.CheckNull(password);

            string storedProcedure = "usp_Update" + EntityName + "Password";

            Executer.Parameters.Add(new SqlParameter("@Id", user.Id));
            Executer.Parameters.Add(new SqlParameter("@Password", password));

            Executer.ExecuteVoid(storedProcedure);
        }

        public User GetByUserName(string userName)
        {
            ThrowException.CheckNull(userName);

            string storedProcedure = "usp_Select" + EntityName + "ByUserName";

            Executer.Parameters.Add(new SqlParameter("@UserName", userName));

            return Executer.Execute(storedProcedure, Converter).FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            ThrowException.CheckNull(email);

            string storedProcedure = "usp_Select" + EntityName + "ByEmail";

            Executer.Parameters.Add(new SqlParameter("@Email", email));

            return Executer.Execute(storedProcedure, Converter).FirstOrDefault();
        }

        public IEnumerable<User> GetByQuery(string query)
        {
            ThrowException.CheckNull(query);

            string storedProcedure = "usp_Select" + TableName + "ByQuery";

            Executer.Parameters.Add(new SqlParameter("@Query", query));

            return Executer.Execute(storedProcedure, Converter);
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

            return Executer.Execute(storedProcedure, new PasswordConverter()).FirstOrDefault();
        }
    }
}
