USE ElLibDataBase
GO

IF OBJECT_ID('Countries') IS NOT NULL
DROP TABLE Countries
GO

CREATE TABLE Countries(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] nvarchar(25) NOT NULL,
);