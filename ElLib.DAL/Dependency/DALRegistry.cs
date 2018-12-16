using ElLib.Common.Entity;
using ElLib.DAL.Converter;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;
using StructureMap;

namespace ElLib.DAL.Dependency
{
    public class DALRegistry : Registry
    {
        public DALRegistry()
        {
            For<IAddressRepository>().Singleton().Use<AddressRepository>();
            For<IAuthorRepository>().Singleton().Use<AuthorRepository>();
            For<IBookCategoryRepository>().Singleton().Use<BookCategoryRepository>();
            For<IBookRepository>().Singleton().Use<BookRepository>();
            For<ILanguageRepository>().Singleton().Use<LanguageRepository>();
            For<IPublishingRepository>().Singleton().Use<PublishingRepository>();

            For<IProcedureExecuter>().Use<ProcedureExecuter>();

            For<IConverter<Address>>().Singleton().Use<AddressConverter>();
            For<IConverter<Author>>().Singleton().Use<AuthorConverter>();
            For<IConverter<BookCategory>>().Singleton().Use<BookCategoryConverter>();
            For<IConverter<Book>>().Singleton().Use<BookConverter>();
            For<IConverter<Language>>().Singleton().Use<LanguageConverter>();
            For<IConverter<Publishing>>().Singleton().Use<PublishingConverter>();

            For<IParameters<Address>>().Singleton().Use<AddressParameters>();
            For<IParameters<Author>>().Singleton().Use<AuthorParameters>();
            For<IParameters<BookCategory>>().Singleton().Use<BookCategoryParameters>();
            For<IParameters<Book>>().Singleton().Use<BookParameters>();
            For<IParameters<Language>>().Singleton().Use<LanguageParameters>();
            For<IParameters<Publishing>>().Singleton().Use<PublishingParameters>();
        }
    }
}
