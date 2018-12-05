USE ElLibDataBase
GO

CREATE PROC usp_CreateLanguage
	@Name nvarchar(25)
AS
	INSERT Languages([Name])
	VALUES
	(@Name)