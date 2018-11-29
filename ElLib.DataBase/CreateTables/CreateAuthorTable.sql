USE ElLibDataBase
GO

IF OBJECT_ID('Authors') IS NOT NULL
DROP TABLE Authors
GO

CREATE TABLE Authors(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(25) NOT NULL,
	LastName nvarchar(25) NOT NULL,
	MiddleName nvarchar(25) NOT NULL,
	Email nvarchar(50) NULL,
);