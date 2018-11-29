USE ElLibDataBase
GO

IF OBJECT_ID('Addresses') IS NOT NULL
DROP TABLE Addresses
GO

CREATE TABLE Addresses(
	Id int PRIMARY KEY IDENTITY,
	CountryId int NOT NULL,
	CityId int NULL,
	Street nvarchar(25) NULL,
	Home nvarchar(25) NULL,
);