USE ElLibDataBase
GO

CREATE FUNCTION SelectBooksByPublishingId(@PublishingId int) 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Books b
		JOIN BookAndPublishing bp 
			ON b.Id = bp.BookId
		JOIN Publishing p 
			ON p.Id = bp.PublishingId
		WHERE p.Id = @PublishingId
	)