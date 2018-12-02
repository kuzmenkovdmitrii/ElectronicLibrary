USE ElLibDataBase
GO

CREATE FUNCTION SelectPublishingsByCountryId(@CountryId int)
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Publishing p
		JOIN Addresses a ON a.Id = p.AddressId AND a.CountryId = @CountryId
	)