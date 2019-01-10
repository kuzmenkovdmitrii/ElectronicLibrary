using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Implementations;
using ElLib.DAL.Parameters.Implementations;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Implementations;
using ElLib.DAL.Repositories.Interfaces;
using StructureMap;

namespace ElLib.DAL.Dependency
{
    public class DALRegistry : Registry
    {
        public DALRegistry()
        {
            For<IAuthorRepository>().Use<AuthorRepository>();
            For<IBookCategoryRepository>().Use<BookCategoryRepository>();
            For<IBookRepository>().Use<BookRepository>();
            For<ILanguageRepository>().Use<LanguageRepository>();
            For<IPublishingRepository>().Use<PublishingRepository>();
            For<IUserRepository>().Use<UserRepository>();
            For<IRoleRepository>().Use<RoleRepository>();

            For<IProcedureExecuter>().Use<ProcedureExecuter>();

            For<IConverter<Author>>().Use<AuthorConverter>();
            For<IConverter<BookCategory>>().Use<BookCategoryConverter>();
            For<IConverter<Book>>().Use<BookConverter>();
            For<IConverter<Language>>().Use<LanguageConverter>();
            For<IConverter<Publishing>>().Use<PublishingConverter>();
            For<IConverter<User>>().Use<UserConverter>();
            For<IConverter<Role>>().Use<RoleConverter>();

            For<IParameters<Author>>().Use<AuthorParameters>();
            For<IParameters<BookCategory>>().Use<BookCategoryParameters>();
            For<IParameters<Book>>().Use<BookParameters>();
            For<IParameters<Language>>().Use<LanguageParameters>();
            For<IParameters<Publishing>>().Use<PublishingParameters>();
            For<IParameters<User>>().Use<UserParameters>();
            For<IParameters<Role>>().Use<RoleParameters>();
        }
    }
}
