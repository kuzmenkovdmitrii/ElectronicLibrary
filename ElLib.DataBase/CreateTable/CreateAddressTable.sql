USE ElLibDataBase
GO

IF OBJECT_ID('Addresses') IS NOT NULL
DROP TABLE Addresses
GO

CREATE TABLE Addresses(
	Id int PRIMARY KEY IDENTITY,
	Country nvarchar(50) NOT NULL,
	City nvarchar(50) NULL,
	Street nvarchar(50) NULL,
	Home nvarchar(50) NULL,
);