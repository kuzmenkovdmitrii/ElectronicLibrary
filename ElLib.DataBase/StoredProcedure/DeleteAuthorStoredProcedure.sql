USE ElLibDataBase
GO

CREATE PROC DeleteAuthor 
	@Id int
AS
	DELETE Authors
		WHERE Id = @id