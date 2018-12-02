USE ElLibDataBase
GO

CREATE PROC DeleteRole 
	@Id int
AS
	DELETE Roles
		WHERE Id = @id