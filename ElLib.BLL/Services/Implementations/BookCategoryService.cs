using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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
            return bookCategoryRepository.GetById(id);
        }

        public OperationDetails Create(BookCategory item)
        {
            try
            {
                bookCategoryRepository.Create(item);
                return new OperationDetails(true, "Категория книги успешно создана");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании категории книги");
            }
        }

        public OperationDetails Update(BookCategory item)
        {
            try
            {
                bookCategoryRepository.Update(item);
                return new OperationDetails(true, "Категория книги успешно обновлена");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении категории книги");
            }
        }

        public OperationDetails Delete(int? id)
        {
            try
            {
                bookCategoryRepository.Delete(id);
                return new OperationDetails(true, "Категория книги успешно удалена");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении категории книги");
            }
        }
    }
}
