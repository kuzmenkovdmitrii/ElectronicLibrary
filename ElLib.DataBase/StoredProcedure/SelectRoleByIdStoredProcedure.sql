USE ElLibDataBase
GO

CREATE PROC usp_SelectRoleById
	@Id int
AS
	SELECT * FROM Roles
		WHERE Id = @Id