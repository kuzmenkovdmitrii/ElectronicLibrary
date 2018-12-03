USE ElLibDataBase
GO

CREATE PROC SelectPublishingsByCountryId
	@CountryId int
AS
	SELECT * FROM Publishing p
	JOIN Addresses a 
		ON a.Id = p.AddressId 
	WHERE a.CountryId = @CountryId