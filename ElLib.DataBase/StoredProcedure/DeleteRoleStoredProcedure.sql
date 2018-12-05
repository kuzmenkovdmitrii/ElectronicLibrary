USE ElLibDataBase
GO

CREATE PROC usp_DeleteRole 
	@Id int
AS
	DELETE Roles
		WHERE Id = @id