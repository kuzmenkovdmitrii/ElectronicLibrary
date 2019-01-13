using ElLib.BLL.Services.Implementations;
using ElLib.BLL.Services.Interfaces;
using StructureMap;

namespace ElLib.BLL.Dependency
{
    public class BLLRegistry : Registry
    {
        public BLLRegistry()
        {
            For<IAdvertisingService>().Use<AdvertisingService>();
            For<IAuthorService>().Singleton().Use<AuthorService>();
            For<IAuthService>().Singleton().Use<AuthService>();
            For<IBookCategoryService>().Singleton().Use<BookCategoryService>();
            For<IBookService>().Singleton().Use<BookService>();
            For<ILanguageService>().Singleton().Use<LanguageService>();
            For<IPublishingService>().Singleton().Use<PublishingService>();
            For<IUploadService>().Singleton().Use<UploadService>();
            For<IUserService>().Singleton().Use<UserService>();
            For<IRoleService>().Singleton().Use<RoleService>();
        }
    }
}
