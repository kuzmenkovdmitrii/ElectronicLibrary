using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookCategoryRepository : CommonRepository, IBookCategoryRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public IEnumerable<BookCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookCategory GetById(int id)
        {
            BookCategory bookCategory;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(StoredProcedure.SELECT_BOOKCATEGORY_BY_ID, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                bookCategory = new BookCategory
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Description = (string)reader["Description"],
                };
            }

            return bookCategory;
        }

        public void Create(BookCategory item)
        {
            throw new NotImplementedException();
        }

        public void Update(BookCategory item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
