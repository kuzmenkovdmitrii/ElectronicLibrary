using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.BLL.Service
{
    public class AuthorService : IAuthorService
    {
        readonly IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return authorRepository.GetById(id);
        }

        public OperationDetails Create(Author item)
        {
            try
            {
                authorRepository.Create(item);
                return new OperationDetails(true, "Автор успешно создан");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании автора");
            }
        }

        public OperationDetails Update(Author item)
        {
            try
            {
                authorRepository.Update(item);
                return new OperationDetails(true, "Автор успешно обновлён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении автора");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                authorRepository.Delete(id);
                return new OperationDetails(true, "Автор успешно удалён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении автора");
            }
        }
    }
}
