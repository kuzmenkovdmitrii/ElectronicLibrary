USE ElLibDataBase
GO

CREATE PROC usp_SelectPublishingById
	@Id int
AS
	SELECT p.Id, p.[Name], p.AddressId, a.Country, a.City, a.Street, a.Home FROM Publishings p
	JOIN Addresses a 
		ON a.Id = p.AddressId 
	WHERE p.Id = @Id