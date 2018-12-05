USE ElLibDataBase
GO

CREATE PROC usp_SelectUserById
	@Id int
AS
	SELECT * FROM Users
	WHERE Id = @Id