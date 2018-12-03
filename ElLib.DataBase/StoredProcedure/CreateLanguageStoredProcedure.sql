USE ElLibDataBase
GO

CREATE PROC CreateLanguage
	@Name nvarchar(25)
AS
	INSERT Languages([Name])
	VALUES
	(@Name)