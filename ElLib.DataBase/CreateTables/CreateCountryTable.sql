USE ElLibDataBase
GO

CREATE TABLE Countries(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] nvarchar(25) NOT NULL,
);