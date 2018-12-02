USE ElLibDataBase
GO

CREATE PROC DeleteLanguage 
	@Id int 
AS
	DELETE Languages
		WHERE Id = @id