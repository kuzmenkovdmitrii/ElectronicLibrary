USE ElLibDataBase
GO

IF OBJECT_ID('Addresses') IS NOT NULL
DROP TABLE Addresses
GO

CREATE TABLE Addresses(
	Id int PRIMARY KEY IDENTITY,
	Country nvarchar(25) NOT NULL,
	City nvarchar(25) NULL,
	Street nvarchar(25) NULL,
	Home nvarchar(25) NULL,
);