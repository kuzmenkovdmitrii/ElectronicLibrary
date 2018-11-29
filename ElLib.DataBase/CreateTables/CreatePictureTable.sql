USE ElLibDataBase
GO

CREATE TABLE Pictures(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	Link nvarchar(max) NOT NULL,
);