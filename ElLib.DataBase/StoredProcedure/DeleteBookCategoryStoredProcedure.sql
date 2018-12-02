USE ElLibDataBase
GO

CREATE PROC DeleteBookCategory
	@Id int
AS
	DELETE BookCategories
		WHERE Id = @id