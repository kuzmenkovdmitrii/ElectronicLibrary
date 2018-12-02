USE ElLibDataBase
GO

IF OBJECT_ID('Users') IS NOT NULL
DROP TABLE Users
GO

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY,
	UserName nvarchar(25) UNIQUE,
	[Password] nvarchar(25) NOT NULL,
	Email nvarchar(50) UNIQUE,
);