sqlcmd -S.\SQLEXPRESS -E -i %InitializationScript.sql


sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateAddressTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateAuthorTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateBookCategoryTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateBookTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateCityTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateCountryTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateFileTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateLanguageTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreatePictureTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreatePublishingTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateRoleTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/CreateUserTable.sql



sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/ManyToMany/BookAndAuthor.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/ManyToMany/BookAndBookCategory.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/ManyToMany/BookAndPublishing.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/ManyToMany/UserAndRole.sql





sqlcmd -S.\SQLEXPRESS -E -i %Relationship/CreateAllDependencies.sql





sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/AddAuthorToBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/AddBookCategoryToBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/AddPublishingToBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/AddRoleToUserStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateAddressStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateBookCategoryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateCityStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateCountryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateFileStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateLanguageStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreatePictureStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreatePublishingStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateRoleStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/CreateUserStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteAuthorStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteBookCategoryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteCityStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteCountryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteFileStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteLanguageStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeletePictureStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeletePublishingStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteRoleStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/DeleteUserStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllAddressesStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllAuthorsStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllBookCategoriesStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllBooksStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllCountriesStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllLanguagesStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllPublishingsStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllRolesStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectAllUsersStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectBooksByAuthorIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectBooksByBookCategoryIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectBooksByLanguageIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectBooksByPublishingIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectCitiesByCountryIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectPublishingsByCountryIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/SelectUsersByRolesIdStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateAddressStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateAuthorStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateBookCategoryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateBookStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateCityStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateCountryStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateFIleStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateLanguageStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdatePictureStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdatePublishingStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateRoleStoredProcedure.sql

sqlcmd -S.\SQLEXPRESS -E -i %StoredProcedure/UpdateUserStoredProcedure.sql

PAUSE