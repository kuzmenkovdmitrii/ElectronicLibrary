USE ElLibDataBase
GO

CREATE PROC usp_SelectRoleByName
	@Name nvarchar(50) 
AS
SELECT * FROM Roles
WHERE [Name] = @Name
