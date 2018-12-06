using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;
using Microsoft.SqlServer.Server;

namespace ElLib.DAL.Repository
{
    public class AuthorRepository : CommonRepository<Author>, IAuthorRepository
    {
        readonly string connectionString =
            @"Data Source=ZENBOOK\SQLEXPRESS;Initial Catalog=ElLibDataBase;Integrated Security=True";

        public IEnumerable<Author> GetAll()
        {
            IList<Author> list = new List<Author>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProcedure.SELECT_ALL_AUTHORS, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    //await connection.OpenAsync();
                    connection.Open();
                    //var reader = await cmd.ExecuteReaderAsync();
                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //while (reader.ReadAsync() != null)
                        while (reader.Read())
                        {
                            list.Add(new Author()
                            {
                                Id = (int) reader["Id"],
                                Name = (string) reader["Name"],
                                LastName = (string) reader["LastName"],
                                MiddleName = (string) reader["MiddleName"],
                                Email = (string)reader["Email"]
                            });
                        }
                    }
                    reader.Close();
                }
            }
            return list;
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Author item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProcedure.CREATE_AUTHOR, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Name", item.Name));
                    cmd.Parameters.Add(new SqlParameter("@LastName", item.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", item.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@Email", item.Email));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Author item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProcedure.CREATE_AUTHOR, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id", item.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", item.Name));
                    cmd.Parameters.Add(new SqlParameter("@LastName", item.LastName));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", item.MiddleName));
                    cmd.Parameters.Add(new SqlParameter("@Email", item.Email));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProcedure.CREATE_AUTHOR, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Id", id));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
