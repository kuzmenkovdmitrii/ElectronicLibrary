USE ElLibDataBase
GO

CREATE PROC CreateCountry
	@Name nvarchar(25)
AS
	INSERT Countries([Name])
	VALUES
	(@Name)