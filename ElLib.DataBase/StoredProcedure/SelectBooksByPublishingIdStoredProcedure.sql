USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByPublishingId
	@PublishingId int
AS
	SELECT * FROM Books b
	JOIN BookAndPublishing bp 
		ON b.Id = bp.BookId
	JOIN Publishing p 
		ON p.Id = bp.PublishingId
	WHERE p.Id = @PublishingId