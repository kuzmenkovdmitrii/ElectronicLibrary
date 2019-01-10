﻿using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IAuthorService : IService<Author>
    {
        IEnumerable<Author> Search(string query);
    }
}
