USE ElLibDataBase
GO

CREATE PROC usp_SelectPublishingsByBookId
	@Id int
AS
	SELECT 
		p.Id, 
		p.[Name], 
		p.AddressId,
		a.Country AddressCountry,
		a.City AddressCity,
		a.Street AddressStreet,
		a.Home AddressHome
	FROM Publishings p
	JOIN Addresses a
		ON AddressId = a.Id

	JOIN BookAndPublishing bp
		ON bp.PublishingId = p.Id
	WHERE bp.BookId = @Id