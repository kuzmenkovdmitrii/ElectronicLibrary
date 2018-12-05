namespace ElLib.DAL
{
    public static class StoredProcedure
    {
        public const string ADD_AUTHOR_TO_BOOK = "usp_AddAuthorToBook";
        public const string ADD_BOOKCATEGORY_TO_BOOK = "usp_AddBookCategoryToBook";
        public const string ADD_PUBLISHING_TO_BOOK = "usp_AddPublishingToBook";
        public const string ADD_ROLE_TO_USER = "usp_AddRoleToUser";

        public const string CREATE_ADDRESS = "usp_CreateAddress";
        public const string CREATE_AUTHOR = "usp_CreateAuthor";
        public const string CREATE_BOOKCATEGORY = "usp_CreateBookCategory";
        public const string CREATE_BOOK = "usp_CreateBook";
        public const string CREATE_FILE = "usp_CreateFile";
        public const string CREATE_LANGUAGE = "usp_CreateLanguage";
        public const string CREATE_PICTURE = "usp_CreatePicture";
        public const string CREATE_PUBLISHING = "usp_CreatePublishing";
        public const string CREATE_ROLE = "usp_CreateRole";
        public const string CREATE_USER = "usp_CreateUser";

        public const string DELETE_AUTHOR = "usp_DeleteAuthor";
        public const string DELETE_BOOKCATEGORY = "usp_DeleteBookCategory";
        public const string DELETE_BOOK = "usp_DeleteBook";
        public const string DELETE_FILE = "usp_DeleteFile";
        public const string DELETE_LANGUAGE = "usp_DeleteLanguage";
        public const string DELETE_PICTURE = "usp_DeletePicture";
        public const string DELETE_PUBLISHING = "usp_DeletePublishing";
        public const string DELETE_ROLE = "usp_DeleteRole";
        public const string DELETE_USER = "usp_DeleteUser";

        public const string SELECT_ALL_ADDRESSES = "usp_SelectAllAddresses";
        public const string SELECT_ALL_AUTHORS = "usp_SelectAllAuthors";
        public const string SELECT_ALL_BOOKCATEGORIES = "usp_SelectAllBookCategories";
        public const string SELECT_ALL_BOOKS = "usp_SelectAllBooks";
        public const string SELECT_ALL_LANGUAGES = "usp_SelectAllLanguages";
        public const string SELECT_ALL_PUBLISHINGS = "usp_SelectAllPublishings";
        public const string SELECT_ALL_ROLES = "usp_SelectAllRoles";
        public const string SELECT_ALL_USERS = "usp_SelectAllUsers";
        public const string SELECT_BOOK_BY_AUTHOR_ID = "usp_SelectBooksByAuthorId";
        public const string SELECT_BOOK_BY_BOOKCATEGORY_ID = "usp_SelectBooksByBookCategoryId";
        public const string SELECT_BOOK_BY_LANGUAGE_ID = "usp_SelectBooksByLanguageId";
        public const string SELECT_BOOK_BY_PUBLISHING_ID = "usp_SelectBooksByPublishingId";
        public const string SELECT_CITIES_BY_COUNTRY_Name = "usp_SelectCitiesByCountryName";
        public const string SELECT_PUBLISHINGS_BY_COUNTRY_ID = "usp_SelectPublishingsByCountryId";
        public const string SELECT_USERS_BY_ROLE_ID = "usp_SelectUsersByRoleId";

        public const string UPDATE_ADDRESS = "usp_UpdateAddress";
        public const string UPDATE_AUTHOR = "usp_UpdateAuthor";
        public const string UPDATE_BOOKCATEGORY = "usp_UpdateBookCategory";
        public const string UPDATE_BOOK = "usp_UpdateBook";
        public const string UPDATE_FILE = "usp_UpdateFIle";
        public const string UPDATE_LANGUAGE = "usp_UpdateLanguage";
        public const string UPDATE_PICTURE = "usp_UpdatePicture";
        public const string UPDATE_PUBLISHING = "usp_UpdatePublishing";
        public const string UPDATE_ROLE = "usp_UpdateRole";
        public const string UPDATE_USER = "usp_UpdateUser";

        public const string SELECT_ADDRESS_BY_ID = "usp_SelectAddressById";
        public const string SELECT_AUTHOR_BY_ID = "Susp_electAuthorById";
        public const string SELECT_BOOKCATEGORY_BY_ID = "usp_SelectBookCategoryById";
        public const string SELECT_BOOK_BY_ID = "usp_SelectBookById";
        public const string SELECT_FILE_BY_ID = "usp_SelectFileById";
        public const string SELECT_LANGUAGE_BY_ID = "usp_SelectLanguageById";
        public const string SELECT_PICTURE_BY_ID = "usp_SelectPictureById";
        public const string SELECT_PUBLISHING_BY_ID = "usp_SelectPublishingById";
        public const string SELECT_ROLE_BY_ID = "usp_SelectRoleById";
        public const string SELECT_USER_BY_ID = "usp_SelectUserById";
    }
}
