USE ElLibDataBase
GO

CREATE PROC CreateCity
	@Name nvarchar(25),
	@CountryId int
AS
	INSERT Cities([Name], CountryId)
	VALUES
	(@Name, @CountryId)