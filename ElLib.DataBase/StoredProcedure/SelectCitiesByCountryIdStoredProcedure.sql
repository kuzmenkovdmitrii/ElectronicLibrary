USE ElLibDataBase
GO

CREATE PROC SelectCitiesByCountryId
	@CountryId int
AS
	SELECT coutry.[Name] CountryName, city.[Name] CityName
	FROM Cities city
	JOIN Countries coutry
		ON coutry.Id = CountryId
	WHERE coutry.Id = @CountryId