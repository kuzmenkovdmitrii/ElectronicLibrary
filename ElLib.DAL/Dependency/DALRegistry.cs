using ElLib.Common.Entity;
using ElLib.DAL.Mapper;
using ElLib.DAL.Mapper.Interface;
using ElLib.DAL.Repository;
using ElLib.DAL.Repository.Interface;
using StructureMap;

namespace ElLib.DAL.Dependency
{
    public class DALRegistry : Registry
    {
        public DALRegistry()
        {
            For<IAuthorRepository>().Singleton().Use<AuthorRepository>();
            For<IBookCategoryRepository>().Singleton().Use<BookCategoryRepository>();
            For<IBookRepository>().Singleton().Use<BookRepository>();
            For<ILanguageRepository>().Singleton().Use<LanguageRepository>();
            For<IPublishingRepository>().Singleton().Use<PublishingRepository>();
            For<IAddressRepository>().Singleton().Use<AddressRepository>();
            For<IMapper<Address>>().Singleton().Use<AddressMapper>();
            For<IMapper<Author>>().Singleton().Use<AuthorMapper>();
            For<IMapper<BookCategory>>().Singleton().Use<BookCategoryMapper>();
            For<IMapper<Book>>().Singleton().Use<BookMapper>();
            For<IMapper<Language>>().Singleton().Use<LanguageMapper>();
            For<IMapper<Publishing>>().Singleton().Use<PublishingMapper>();
        }
    }
}
