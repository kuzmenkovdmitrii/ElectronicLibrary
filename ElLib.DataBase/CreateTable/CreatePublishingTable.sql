USE ElLibDataBase
GO

IF OBJECT_ID('Publishings') IS NOT NULL
DROP TABLE Publishings
GO

CREATE TABLE Publishings(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(25) NOT NULL,
	AddressId int NOT NULL,
);