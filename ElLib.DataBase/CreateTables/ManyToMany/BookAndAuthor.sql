USE ElLibDataBase
GO

IF OBJECT_ID('BookAndAuthor') IS NOT NULL
DROP TABLE BookAndAuthor
GO

CREATE TABLE BookAndAuthor(
	BookId int,
	AuthorId int,
);