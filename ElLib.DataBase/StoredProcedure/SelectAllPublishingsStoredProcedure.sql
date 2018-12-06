USE ElLibDataBase
GO

CREATE PROC usp_SelectAllPublishings 
AS
	SELECT 
	p.Id, 
	p.[Name], 
	a.Id AddressId,
	a.Country AddressCountry,
	a.City AddressCity,
	a.Street AddressStreet,
	a.Home AddressHome
	FROM Publishings p
	JOIN Addresses a
		ON a.Id = p.AddressId