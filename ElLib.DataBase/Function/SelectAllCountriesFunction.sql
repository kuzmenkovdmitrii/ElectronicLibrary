USE ElLibDataBase
GO

CREATE FUNCTION SelectAllCountries() 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Countries
	)