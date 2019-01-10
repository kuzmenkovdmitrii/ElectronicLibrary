using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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
            ThrowException.CheckNull(id);

            return bookCategoryRepository.GetById(id);
        }

        public OperationDetails Create(BookCategory item)
        {
            ThrowException.CheckNull(item);

            bookCategoryRepository.Create(item);
            return new OperationDetails(true, "Категория книги успешно создана");
        }

        public OperationDetails Update(BookCategory item)
        {
            ThrowException.CheckNull(item);

            bookCategoryRepository.Update(item);
            return new OperationDetails(true, "Категория книги успешно обновлена");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckNull(id);

            bookCategoryRepository.Delete(id);
            return new OperationDetails(true, "Категория книги успешно удалена");
        }

        public IEnumerable<BookCategory> Search(string query)
        {
            return bookCategoryRepository.GetByQuery(query);
        }

        public bool CheckName(string name)
        {
            BookCategory category = bookCategoryRepository.GetByName(name);

            return category == null;
        }
    }
}
