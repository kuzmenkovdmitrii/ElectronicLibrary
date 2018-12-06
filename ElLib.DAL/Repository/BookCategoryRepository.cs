using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookCategoryRepository : CommonRepository<BookCategory>, IBookCategoryRepository
    {
    }
}
