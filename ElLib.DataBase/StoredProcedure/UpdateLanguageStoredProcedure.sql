USE ElLibDataBase
GO

CREATE PROC UpdateLanguage 
	@Id int, 
	@Name nvarchar(25) 
AS
	UPDATE Languages
		SET [Name] = @Name
		WHERE Id = @id