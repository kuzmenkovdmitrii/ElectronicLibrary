USE ElLibDataBase
GO

CREATE PROC usp_DeleteBookCategory
	@Id int
AS
	DELETE BookCategories
		WHERE Id = @id