USE ElLibDataBase
GO

CREATE PROC usp_DeletePicture 
	@Id int
AS
	DELETE Pictures
		WHERE Id = @id