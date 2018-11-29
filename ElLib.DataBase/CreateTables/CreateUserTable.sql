USE ElLibDataBase
GO

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	UserName nvarchar(25) NOT NULL,
	[Password] nvarchar(25) NOT NULL,
	Email nvarchar(50) NOT NULL,
);