USE ElLibDataBase
GO

CREATE PROC usp_CreateUser
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Email nvarchar(50)
AS
	INSERT Users(UserName, [Password], Email)
	VALUES
	(@UserName, @Password, @Email)