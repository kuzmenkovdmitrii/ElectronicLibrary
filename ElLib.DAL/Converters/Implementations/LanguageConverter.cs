using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    class LanguageConverter : IConverter<Language>
    {
        public Language FromReader(SqlDataReader reader)
        {
            return new Language()
            {
                Id = (int) reader["Id"],
                Name = (string) reader["Name"],
            };
        }
    }
}