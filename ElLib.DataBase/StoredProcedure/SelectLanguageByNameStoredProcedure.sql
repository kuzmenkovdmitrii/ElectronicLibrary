USE ElLibDataBase
GO

CREATE PROC usp_SelectLanguageByName
	@Name nvarchar(50)
AS
	SELECT * FROM Languages
		WHERE [Name] = @Name