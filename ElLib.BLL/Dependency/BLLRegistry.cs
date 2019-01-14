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
            For<IAuthorService>().Use<AuthorService>();
            For<IAuthService>().Use<AuthService>();
            For<IBookCategoryService>().Use<BookCategoryService>();
            For<IBookService>().Use<BookService>();
            For<ILanguageService>().Use<LanguageService>();
            For<IPublishingService>().Use<PublishingService>();
            For<IUploadService>().Use<UploadService>();
            For<IUserService>().Use<UserService>();
            For<IRoleService>().Use<RoleService>();
        }
    }
}
