USE ElLibDataBase
GO

CREATE PROC usp_UpdateUserPassword
	@Id int, 
	@Password nvarchar(50)
AS
	UPDATE Users
		SET 
		[Password] = @Password
	WHERE Id = @id