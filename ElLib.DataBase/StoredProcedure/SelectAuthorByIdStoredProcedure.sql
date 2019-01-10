USE ElLibDataBase
GO

CREATE PROC usp_SelectAuthorById
	@Id int
AS
	SELECT * FROM Authors
		WHERE Id = @Id