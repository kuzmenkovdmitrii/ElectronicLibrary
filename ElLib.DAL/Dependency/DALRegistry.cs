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
        }
    }
}
