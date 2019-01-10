USE ElLibDataBase
GO

CREATE PROC usp_UpdateUser 
	@Id int, 
	@UserName nvarchar(50),
	@Email nvarchar(50)
AS
	UPDATE Users
		SET 
		UserName = @UserName,
		Email = @Email
	WHERE Id = @id