USE ElLibDataBase
GO

CREATE PROC usp_SelectUserById
	@Id int
AS
	SELECT Id, UserName, Email FROM Users
		WHERE Id = @Id