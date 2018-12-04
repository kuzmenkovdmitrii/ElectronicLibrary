﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElLib.DAL.Repository.Interface
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);

        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
