USE ElLibDataBase
GO

CREATE PROC DeleteBook 
	@Id int 
AS
	DELETE Books
		WHERE Id = @id