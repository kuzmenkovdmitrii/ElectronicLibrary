USE ElLibDataBase
GO

IF OBJECT_ID('Languages') IS NOT NULL
DROP TABLE Languages
GO

CREATE TABLE Languages(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(25) NOT NULL,
);