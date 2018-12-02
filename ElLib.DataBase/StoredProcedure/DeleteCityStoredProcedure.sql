USE ElLibDataBase
GO

CREATE PROC DeleteCity 
	@Id int 
AS
	DELETE Cities
		WHERE Id = @id