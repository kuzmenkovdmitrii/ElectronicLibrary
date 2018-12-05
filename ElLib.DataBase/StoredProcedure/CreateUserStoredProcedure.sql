USE ElLibDataBase
GO

CREATE PROC usp_CreateUser
	@UserName nvarchar(25),
	@Password nvarchar(25),
	@Email nvarchar(50)
AS
	INSERT Users(UserName, [Password], Email)
	VALUES
	(@UserName, @Password, @Email)