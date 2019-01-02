USE ElLibDataBase
GO

CREATE PROC usp_SelectUserByUserName
	@UserName nvarchar(50)
AS
	SELECT Id, UserName, Email FROM Users
	WHERE UserName = @UserName