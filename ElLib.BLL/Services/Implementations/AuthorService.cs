using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
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

        public Author GetById(int? id)
        {
            ThrowException.CheckId(id);

            return authorRepository.GetById(id);
        }

        public OperationDetails Create(Author item)
        {
            ThrowException.CheckNull(item);

            authorRepository.Create(item);

            return new OperationDetails(true, "Автор успешно создан");
        }

        public OperationDetails Update(Author item)
        {
            ThrowException.CheckNull(item);

            authorRepository.Update(item);

            return new OperationDetails(true, "Автор успешно обновлён");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            authorRepository.Delete(id);

            return new OperationDetails(true, "Автор успешно удалён");
        }

        public IEnumerable<Author> Search(string query)
        {
            ThrowException.CheckNull(query);

            return authorRepository.GetByQuery(query);
        }
    }
}
