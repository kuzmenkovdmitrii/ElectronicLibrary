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

sqlcmd -S.\SQLEXPRESS -E -i %CreateTable/ManyToMany/CountryAndCity.sql



sqlcmd -S.\SQLEXPRESS -E -i %Relationship/CreateAllDependencies.sql

PAUSE