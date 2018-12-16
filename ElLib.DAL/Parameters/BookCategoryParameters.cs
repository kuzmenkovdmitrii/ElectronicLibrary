using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters
{
    public class BookCategoryParameters : IParameters<BookCategory>
    {
        public IEnumerable<SqlParameter> GetParameters(BookCategory item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@Description", item.Description),
            };
        }
    }
}
