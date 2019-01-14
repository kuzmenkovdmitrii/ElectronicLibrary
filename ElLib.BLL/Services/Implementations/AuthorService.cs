﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.BLL.Services.Interfaces;
using ElLib.BLL.ValidationInfo;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public Author GetById(int? id)
        {
            ThrowException.CheckId(id);

            return authorRepository.GetById(id);
        }

        public OperationDetails Create(Author item)
        {
            ThrowException.CheckNull(item);

            try
            {
                authorRepository.Create(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании автора");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Update(Author item)
        {
            ThrowException.CheckNull(item);

            try
            {
                authorRepository.Update(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении автора");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            try
            {
                authorRepository.Delete(id);
            }
            catch (SqlException e)
            {
                return new OperationDetails(false, "Не удалось удалить автора, так как есть книги связанные с автором");
            }

            return new OperationDetails(true);
        }

        public IEnumerable<Author> Search(string query)
        {
            ThrowException.CheckNull(query);

            return authorRepository.GetByQuery(query);
        }
    }
}
