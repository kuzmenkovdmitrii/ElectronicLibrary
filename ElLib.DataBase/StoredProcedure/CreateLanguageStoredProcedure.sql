USE ElLibDataBase
GO

CREATE PROC usp_CreateLanguage
	@Name nvarchar(50)
AS
	INSERT Languages([Name])
	VALUES
	(@Name)