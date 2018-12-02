USE ElLibDataBase
GO

CREATE PROC DeleteFile 
	@Id int 
AS
	DELETE Files
		WHERE Id = @id