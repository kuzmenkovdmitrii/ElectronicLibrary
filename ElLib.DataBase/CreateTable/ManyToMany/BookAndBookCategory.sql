USE ElLibDataBase
GO

IF OBJECT_ID('BookAndBookCategory') IS NOT NULL
DROP TABLE BookAndBookCategory
GO

CREATE TABLE BookAndBookCategory(
	BookId int,
	BookCategoryId int,
);