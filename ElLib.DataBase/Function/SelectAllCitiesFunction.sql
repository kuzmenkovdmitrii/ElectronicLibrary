USE ElLibDataBase
GO

CREATE FUNCTION SelectAllCities()
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT 
			counrt.[Name], 
			city.[Name], 
			Street,Home
		FROM Cities c
		JOIN Countries coutry
			ON c.Id = CountryId
	)