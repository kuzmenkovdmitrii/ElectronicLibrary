using ElLib.BLL.Service;
using ElLib.BLL.Service.Interface;
using StructureMap;

namespace ElLib.BLL.Dependency
{
    public class BLLRegistry : Registry
    {
        public BLLRegistry()
        {
            For<IAuthorService>().Singleton().Use<AuthorService>();
            For<IBookCategoryService>().Singleton().Use<BookCategoryService>();
            For<IBookService>().Singleton().Use<BookService>();
            For<ILanguageService>().Singleton().Use<LanguageService>();
            For<IPublishingService>().Singleton().Use<PublishingService>();
            For<IAddressService>().Singleton().Use<AddressService>();
        }
    }
}
