USE ElLibDataBase
GO

CREATE PROC usp_SelectBookById
	@Id int
AS
	SELECT * FROM Books
	WHERE Id = @Id