USE ElLibDataBase
GO

CREATE TABLE Addresses(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	CountryId int NOT NULL,
	CityId int NOT NULL,
	Street nvarchar(25) NULL,
	Home nvarchar(25) NULL,
);