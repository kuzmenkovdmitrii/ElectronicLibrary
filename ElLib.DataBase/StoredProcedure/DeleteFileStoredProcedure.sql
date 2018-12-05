USE ElLibDataBase
GO

CREATE PROC usp_DeleteFile 
	@Id int 
AS
	DELETE Files
		WHERE Id = @id