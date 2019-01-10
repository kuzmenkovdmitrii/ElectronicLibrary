USE ElLibDataBase
GO

CREATE PROC usp_SelectPasswordByUserId
	@Id int
AS
	SELECT [Password] FROM Users
		WHERE Id = @Id