USE ElLibDataBase
GO

IF OBJECT_ID('CountryAndCity') IS NOT NULL
DROP TABLE CountryAndCity
GO

CREATE TABLE CountryAndCity(
	CountryId int,
	CityId int,
);