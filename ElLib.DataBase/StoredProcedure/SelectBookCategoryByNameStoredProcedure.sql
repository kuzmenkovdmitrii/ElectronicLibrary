USE ElLibDataBase
GO

CREATE PROC usp_SelectBookCategoryByName
	@Name nvarchar(50)
AS
	SELECT * FROM BookCategories
		WHERE [Name] = @Name