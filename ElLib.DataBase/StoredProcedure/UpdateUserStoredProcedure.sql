USE ElLibDataBase
GO

CREATE PROC UpdateUser 
	@Id int, 
	@UserName nvarchar(25),
	@Password nvarchar(25), 
	@Email nvarchar(50)
AS
	UPDATE Users
		SET 
		UserName = @UserName,
		[Password] = @Password,
		Email = @Email
		WHERE Id = @id