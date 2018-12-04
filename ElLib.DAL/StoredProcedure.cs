namespace ElLib.DAL
{
    public static class StoredProcedure
    {
        public const string ADD_AUTHOR_TO_BOOK = "AddAuthorToBook";
        public const string ADD_BOOKCATEGORY_TO_BOOK = "AddBookCategoryToBook";
        public const string ADD_PUBLISHING_TO_BOOK = "AddPublishingToBook";
        public const string ADD_ROLE_TO_USER = "AddRoleToUser";

        public const string CREATE_ADDRESS = "CreateAddress";
        public const string CREATE_AUTHOR = "CreateAuthor";
        public const string CREATE_BOOKCATEGORY = "CreateBookCategory";
        public const string CREATE_BOOK = "CreateBook";
        public const string CREATE_CITY = "CreateCity";
        public const string CREATE_COUNTRY = "CreateCountry";
        public const string CREATE_FILE = "CreateFile";
        public const string CREATE_LANGUAGE = "CreateLanguage";
        public const string CREATE_PICTURE = "CreatePicture";
        public const string CREATE_PUBLISHING = "CreatePublishing";
        public const string CREATE_ROLE = "CreateRole";
        public const string CREATE_USER = "CreateUser";

        public const string DELETE_AUTHOR = "DeleteAuthor";
        public const string DELETE_BOOKCATEGORY = "DeleteBookCategory";
        public const string DELETE_BOOK = "DeleteBook";
        public const string DELETE_CITY = "DeleteCity";
        public const string DELETE_COUNTRY = "DeleteCountry";
        public const string DELETE_FILE = "DeleteFile";
        public const string DELETE_LANGUAGE = "DeleteLanguage";
        public const string DELETE_PICTURE = "DeletePicture";
        public const string DELETE_PUBLISHING = "DeletePublishing";
        public const string DELETE_ROLE = "DeleteRole";
        public const string DELETE_USER = "DeleteUser";

        public const string SELECT_ALL_ADDRESSES = "SelectAllAddresses";
        public const string SELECT_ALL_AUTHORS = "SelectAllAuthors";
        public const string SELECT_ALL_BOOKCATEGORIES = "SelectAllBookCategories";
        public const string SELECT_ALL_BOOKS = "SelectAllBooks";
        public const string SELECT_ALL_COUNTRIES = "SelectAllCountries";
        public const string SELECT_ALL_LANGUAGES = "SelectAllLanguages";
        public const string SELECT_ALL_PUBLISHINGS = "SelectAllPublishings";
        public const string SELECT_ALL_ROLES = "SelectAllRoles";
        public const string SELECT_ALL_USERS = "SelectAllUsers";
        public const string SELECT_BOOK_BY_AUTHOR_ID = "SelectBooksByAuthorId";
        public const string SELECT_BOOK_BY_BOOKCATEGORY_ID = "SelectBooksByBookCategoryId";
        public const string SELECT_BOOK_BY_LANGUAGE_ID = "SelectBooksByLanguageId";
        public const string SELECT_BOOK_BY_PUBLISHING_ID = "SelectBooksByPublishingId";
        public const string SELECT_CITIES_BY_COUNTRY_ID = "SelectCitiesByCountryId";
        public const string SELECT_PUBLISHINGS_BY_COUNTRY_ID = "SelectPublishingsByCountryId";
        public const string SELECT_USERS_BY_ROLE_ID = "SelectUsersByRoleId";

        public const string UPDATE_ADDRESS = "UpdateAddress";
        public const string UPDATE_AUTHOR = "UpdateAuthor";
        public const string UPDATE_BOOKCATEGORY = "UpdateBookCategory";
        public const string UPDATE_BOOK = "UpdateBook";
        public const string UPDATE_CITY = "UpdateCity";
        public const string UPDATE_COUNTRY = "UpdateCountry";
        public const string UPDATE_FILE = "UpdateFIle";
        public const string UPDATE_LANGUAGE = "UpdateLanguage";
        public const string UPDATE_PICTURE = "UpdatePicture";
        public const string UPDATE_PUBLISHING = "UpdatePublishing";
        public const string UPDATE_ROLE = "UpdateRole";
        public const string UPDATE_USER = "UpdateUser";
    }
}
