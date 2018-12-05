USE ElLibDataBase
GO

CREATE PROC usp_SelectFileById
	@Id int
AS
	SELECT * FROM Files
	WHERE Id = @Id