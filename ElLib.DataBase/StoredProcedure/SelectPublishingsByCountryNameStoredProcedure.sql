USE ElLibDataBase
GO

CREATE PROC usp_SelectPublishingsByCountryName
	@Country nvarchar(25)
AS
	SELECT * FROM Publishing p
	JOIN Addresses a 
		ON a.Id = p.AddressId 
	WHERE a.Country = @Country