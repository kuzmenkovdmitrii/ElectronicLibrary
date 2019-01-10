USE ElLibDataBase
GO

CREATE PROC usp_SelectUserByEmail
	@Email nvarchar(50)
AS
	SELECT Id, UserName, Email FROM Users
		WHERE Email = @Email