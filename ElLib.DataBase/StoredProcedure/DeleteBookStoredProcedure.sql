USE ElLibDataBase
GO

CREATE PROC usp_DeleteBook 
	@Id int 
AS
	DELETE Books
		WHERE Id = @id