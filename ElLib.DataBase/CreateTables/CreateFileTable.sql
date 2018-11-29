USE ElLibDataBase
GO

CREATE TABLE Files(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	Link nvarchar(max) NOT NULL,
);
GO