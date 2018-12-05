USE ElLibDataBase
GO

CREATE PROC usp_DeleteAuthor 
	@Id int
AS
	DELETE Authors
		WHERE Id = @id