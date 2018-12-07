using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public abstract class CommonRepository<T> : IRepository<T>
        where T : class
    {
        protected string ConnectionString { get; set; }
        protected string EntityName { get; set; }
        protected string TableName { get; set; }
        protected IConverter<T> Converter { get; set; }

        public virtual IEnumerable<T> GetAll()
        {
            if (TableName == null)
            {
                throw new NullReferenceException("TableName not filled in.");
            }

            string storedProcedure = "usp_SelectAll" + TableName;

            return Converter.FromTable(Execute(storedProcedure));
        }

        public virtual T GetById(int id)
        {
            if (EntityName == null)
            {
                throw new NullReferenceException("EntityName not filled in.");
            }

            string storedProcedure = "usp_Select" + EntityName + "ById";

            IEnumerable<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };

            return Converter.FromTable(Execute(storedProcedure,parameters)).FirstOrDefault();
        }

        public virtual void Create(T item)
        {
            string storedProcedure = "usp_Create" + EntityName;

            IEnumerable<SqlParameter> parameters =
                Converter.AddParameters(item).Where(x => x.ParameterName != "@Id");

            ExecuteVoid(storedProcedure, parameters);
        }

        public virtual void Update(T item)
        {
            string storedProcedure = "usp_Update" + EntityName;

            IEnumerable<SqlParameter> parameters = Converter.AddParameters(item);

            ExecuteVoid(storedProcedure, parameters);
        }

        public virtual void Delete(int id)
        {
            string storedProcedure = "usp_Delete" + EntityName;

            IEnumerable<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };

            ExecuteVoid(storedProcedure, parameters);
        }


        protected void ExecuteVoid(string storedProcedure, IEnumerable<SqlParameter> parameters)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(parameters.ToArray());

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected DataTable Execute(string storedProcedure)
        {
            return Execute(storedProcedure,new SqlParameter[0]);
        }

        protected DataTable Execute(string storedProcedure, IEnumerable<SqlParameter> parameters)
        {
            DataTable table;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters.ToArray());

                da.SelectCommand = cmd;

                cmd.ExecuteNonQuery();

                da.Fill(ds);

                table = ds.Tables[0];
            }

            return table;
        }
    }
}
