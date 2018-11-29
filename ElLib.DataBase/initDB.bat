sqlcmd -S.\SQLEXPRESS -E -i %InitializationScript.sql


sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateAddressTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateAuthorTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateBookCategoryTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateBookTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateCityTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateCountryTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateFileTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateLanguageTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreatePictureTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreatePublishingTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateRoleTable.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/CreateUserTable.sql



sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/ManyToMany/BookAndAuthor.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/ManyToMany/BookAndBookCategory.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/ManyToMany/BookAndPublishing.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/ManyToMany/UserAndRole.sql

sqlcmd -S.\SQLEXPRESS -E -i %CreateTables/ManyToMany/CountryAndCity.sql



sqlcmd -S.\SQLEXPRESS -E -i %Dependencies/CreateAllDependencies.sql

PAUSE