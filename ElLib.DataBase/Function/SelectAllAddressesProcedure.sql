USE ElLibDataBase
GO

CREATE FUNCTION SelectAllAddresses()
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT coutrt.[Name], city.[Name], Street, Home
		FROM Addresses [address]
		JOIN Countries coutry
			ON [address].Id = CountryId
		JOIN Cities city
			ON city.Id = CityId
	)