using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public abstract class CommonRepository<T> : IRepository<T>
        where T : class
    {
        protected string EntityName { get; set; }
        protected string TableName { get; set; }
        protected IConverter<T> Converter { get; set; }
        protected IParameters<T> Parameters { get; set; }
        protected IProcedureExecuter Executer { get; }

        public CommonRepository(IProcedureExecuter executer)
        {
            Executer = executer;
            Executer.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        }

        public virtual IEnumerable<T> GetAll()
        {
            if (TableName == null)
            {
                throw new NullReferenceException("TableName not filled in.");
            }

            string storedProcedure = "usp_SelectAll" + TableName;
            return Executer.Execute<T>(storedProcedure,Converter);
        }

        public virtual T GetById(int? id)
        {
            if (EntityName == null)
            {
                throw new NullReferenceException("EntityName not filled in.");
            }

            if (id == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_Select" + EntityName + "ById";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute<T>(storedProcedure,Converter).FirstOrDefault();
        }

        public virtual void Create(T item)
        {
            string storedProcedure = "usp_Create" + EntityName;

            Executer.Parameters = Parameters.GetParameters(item).Where(x => x.ParameterName != "@Id").ToList();

            Executer.ExecuteVoid(storedProcedure);
        }

        public virtual void Update(T item)
        {
            string storedProcedure = "usp_Update" + EntityName;

            Executer.Parameters = Parameters.GetParameters(item).ToList();

            Executer.ExecuteVoid(storedProcedure);
        }

        public virtual void Delete(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_Delete" + EntityName;

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            Executer.ExecuteVoid(storedProcedure);
        }
    }
}
