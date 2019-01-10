USE ElLibDataBase
GO

CREATE PROC usp_SelectPublishingById
	@Id int
AS
	SELECT 
		p.Id,
		p.[Name], 
		a.Country AddressCountry, 
		a.City AddressCity, 
		a.Street AddressStreet, 
		a.Home AddressHome
	FROM Publishings p
		JOIN Addresses a 
			ON a.Id = p.AddressId 
		WHERE p.Id = @Id