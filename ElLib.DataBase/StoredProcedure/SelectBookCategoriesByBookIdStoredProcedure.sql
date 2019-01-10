USE ElLibDataBase
GO

CREATE PROC usp_SelectBookCategoriesByBookId
	@Id int
AS
	SELECT Id, [Name], [Description] FROM BookCategories
		JOIN BookAndBookCategory bbc
			ON bbc.BookCategoryId = Id
		WHERE bbc.BookId = @Id