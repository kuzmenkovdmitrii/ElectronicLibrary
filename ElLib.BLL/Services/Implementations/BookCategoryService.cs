using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class BookCategoryService : IBookCategoryService
    {
        readonly IBookCategoryRepository bookCategoryRepository;

        public BookCategoryService(IBookCategoryRepository bookCategoryRepository)
        {
            this.bookCategoryRepository = bookCategoryRepository;
        }

        public IEnumerable<BookCategory> GetAll()
        {
            return bookCategoryRepository.GetAll();
        }

        public BookCategory GetById(int? id)
        {
            ThrowException.CheckId(id);

            return bookCategoryRepository.GetById(id);
        }

        public OperationDetails Create(BookCategory item)
        {
            ThrowException.CheckNull(item);

            try
            {
                bookCategoryRepository.Create(item);
            }
            catch (Exception)
            {
                return new OperationDetails(false, "Произошла ошибка при содании жанра");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Update(BookCategory item)
        {
            ThrowException.CheckNull(item);

            try
            {
                bookCategoryRepository.Update(item);
            }
            catch (Exception)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении жанра");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            try
            {
                bookCategoryRepository.Delete(id);
            }
            catch (SqlException)
            {
                return new OperationDetails(false, "Не удалось удалить жанр, так как есть книги связанные с жанорм");
            }

            return new OperationDetails(true);
        }

        public IEnumerable<BookCategory> Search(string query)
        {
            ThrowException.CheckNull(query);

            return bookCategoryRepository.GetByQuery(query);
        }

        public bool CheckName(string name)
        {
            ThrowException.CheckNull(name);

            BookCategory category = bookCategoryRepository.GetByName(name);

            return category == null;
        }
    }
}
