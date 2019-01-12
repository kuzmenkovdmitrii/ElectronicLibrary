using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entities;

namespace ElLib.DAL.Converters.Implementations
{
    class BookCategoryConverter : IConverter<BookCategory>
    {
        public BookCategory FromReader(SqlDataReader reader)
        {
            return new BookCategory()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"]
            };
        }
    }
}