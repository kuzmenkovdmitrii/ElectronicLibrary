USE ElLibDataBase
GO

CREATE PROC usp_AddPublishingToBook
	@PublishingId int,
	@BookId int
AS
	INSERT BookAndPublishing VALUES
	(@PublishingId, @BookId)