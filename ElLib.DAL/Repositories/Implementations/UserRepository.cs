using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class UserRepository : CommonRepository<User>, IUserRepository
    {
        public UserRepository(IParameters<User> parameters, IConverter<User> converter, IProcedureExecuter executer) : 
            base(executer)
        {
            EntityName = "User";
            TableName = "Users";
            Parameters = parameters;
            Converter = converter;
        }

        public void Create(User item, string password)
        {
            string storedProcedure = "usp_Create" + EntityName;

            Executer.Parameters = Parameters.GetParameters(item).Where(x => x.ParameterName != "@Id").ToList();
            Executer.Parameters.Add(new SqlParameter("@password", password));

            Executer.ExecuteVoid(storedProcedure);
        }

        public string GetPassword(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }

            string storedProcedure = "usp_SelectPasswordByUserId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute(storedProcedure).Rows[0][0].ToString();
        }

        public User GetByUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new NullReferenceException();
            }

            string storedProcedure = "usp_Select" + EntityName + "ByUserName";

            Executer.Parameters.Add(new SqlParameter("@UserName", userName));

            return Converter.FromTable(Executer.Execute(storedProcedure)).FirstOrDefault();
        }

        public User GetByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new NullReferenceException();
            }

            string storedProcedure = "usp_Select" + EntityName + "ByEmail";

            Executer.Parameters.Add(new SqlParameter("@UserName", email));

            return Converter.FromTable(Executer.Execute(storedProcedure)).FirstOrDefault();
        }
    }
}
