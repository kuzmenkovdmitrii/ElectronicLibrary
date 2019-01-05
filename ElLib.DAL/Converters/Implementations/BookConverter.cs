using System;
using System.Data.SqlClient;
using System.Security.Policy;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    public class BookConverter : IConverter<Book>
    {
        public Book FromReader(SqlDataReader reader)
        {
            return new Book()
            {
                Id = (int) reader["Id"],
                Name = (string) reader["Name"],
                PublishingDate = (DateTime) reader["PublishingDate"],
                Language = new Language()
                {
                    Id = (int) reader["LanguageId"],
                    Name = (string) reader["LanguageName"]
                },
                Picture = new Url((string) reader["Picture"]),
                File = new Url((string) reader["File"])
            };
        }
    }
}