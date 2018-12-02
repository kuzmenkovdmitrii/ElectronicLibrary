USE ElLibDataBase
GO

CREATE PROC UpdateFile 
	@Id int, 
	@Link nvarchar(100)
AS
	UPDATE Files
		SET Link = @Link
		WHERE Id = @id