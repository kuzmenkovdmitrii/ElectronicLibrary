using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common;
using ElLib.DAL.Mapper.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public abstract class CommonRepository<T> : IRepository<T>
        where T:class
    {
        public string ConnectionString { get; set; }
        public string TableName { get; set; }
        public string PluralTableName { get; set; }
        public IMapper<T> Mapper { get; set; }

        public IEnumerable<T> GetAll()
        {
            if (PluralTableName == null)
            {
                throw new NullReferenceException("PluralTableName not filled in.");
            }

            string storedProcedure = "usp_SelectAll" + PluralTableName;

            IEnumerable<T> list;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                da.SelectCommand = cmd;

                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                list = Mapper.FromTable(dt);
            }

            return list;
        }

        public virtual T GetById(int id)
        {
            if (TableName == null)
            {
                throw new NullReferenceException("TableName not filled in.");
            }

            string storedProcedure = "usp_Select" + TableName + "ById";

            T item;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                da.SelectCommand = cmd;

                da.Fill(ds);

                DataTable dt = ds.Tables[0];

                item = Mapper.FromTable(dt).FirstOrDefault();
            }

            return item;
        }

        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            string storedProcedure = "usp_Delete" + TableName;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Id", id));

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
