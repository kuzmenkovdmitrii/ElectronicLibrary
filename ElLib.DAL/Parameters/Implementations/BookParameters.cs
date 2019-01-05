using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
{
    public class BookParameters : IParameters<Book>
    {
        public IEnumerable<SqlParameter> GetParameters(Book item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@PublishingDate", item.PublishingDate),
                new SqlParameter("@LanguageId", item.Language.Id),
                new SqlParameter("@Picture", item.Picture.Value),
                new SqlParameter("@File", item.File.Value)
            };
        }
    }
}
