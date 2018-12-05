USE ElLibDataBase
GO

CREATE PROC usp_SelectBookCategoryById
	@Id int
AS
	SELECT * FROM BookCategories
	WHERE Id = @Id