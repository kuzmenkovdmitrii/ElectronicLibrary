USE ElLibDataBase
GO

CREATE PROC usp_DeleteLanguage 
	@Id int 
AS
	DELETE Languages
		WHERE Id = @id