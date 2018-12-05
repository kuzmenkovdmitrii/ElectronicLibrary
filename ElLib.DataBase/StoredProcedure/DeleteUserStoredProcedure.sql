USE ElLibDataBase
GO

CREATE PROC usp_DeleteUser 
	@Id int
AS
	DELETE Users
		WHERE Id = @id