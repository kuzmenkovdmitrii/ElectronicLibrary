USE ElLibDataBase
GO

CREATE PROC SelectAllAddresses
AS
	SELECT coutry.[Name] CountryName, city.[Name] CityName, Street, Home
	FROM Addresses [address]
	JOIN Countries coutry
		ON [address].Id = CountryId
	JOIN Cities city
		ON city.Id = CityId