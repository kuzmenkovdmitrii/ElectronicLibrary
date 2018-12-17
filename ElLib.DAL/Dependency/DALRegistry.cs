using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converter;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository;
using ElLib.DAL.Repository.Interface;
using StructureMap;

namespace ElLib.DAL.Dependency
{
    public class DALRegistry : Registry
    {
        public DALRegistry()
        {
            For<IAddressRepository>().Use<AddressRepository>();
            For<IAuthorRepository>().Use<AuthorRepository>();
            For<IBookCategoryRepository>().Use<BookCategoryRepository>();
            For<IBookRepository>().Use<BookRepository>();
            For<ILanguageRepository>().Use<LanguageRepository>();
            For<IPublishingRepository>().Use<PublishingRepository>();

            For<IProcedureExecuter>().Use<ProcedureExecuter>();

            For<IConverter<Address>>().Use<AddressConverter>();
            For<IConverter<Author>>().Use<AuthorConverter>();
            For<IConverter<BookCategory>>().Use<BookCategoryConverter>();
            For<IConverter<Book>>().Use<BookConverter>();
            For<IConverter<Language>>().Use<LanguageConverter>();
            For<IConverter<Publishing>>().Use<PublishingConverter>();

            For<IParameters<Address>>().Use<AddressParameters>();
            For<IParameters<Author>>().Use<AuthorParameters>();
            For<IParameters<BookCategory>>().Use<BookCategoryParameters>();
            For<IParameters<Book>>().Use<BookParameters>();
            For<IParameters<Language>>().Use<LanguageParameters>();
            For<IParameters<Publishing>>().Use<PublishingParameters>();
        }
    }
}
