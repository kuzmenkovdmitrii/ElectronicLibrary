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

        public OperationDetails Create(Author author)
        {
            authorRepository.Create(author);

            return new OperationDetails(true, "Регистрация успешно пройдена");
        }

        public IEnumerable<Author> GetAll()
        {
            return authorRepository.GetAll();
        }
    }
}
