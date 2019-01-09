USE ElLibDataBase
GO

CREATE PROC usp_DeleteBookReferences
	@Id int 
AS
	DELETE BookAndAuthor
		WHERE BookId = @id

	DELETE BookAndBookCategory
		WHERE BookId = @id

	DELETE BookAndPublishing
		WHERE BookId = @id