USE ElLibDataBase
GO

CREATE PROC AddPublishingToBook
	@PublishingId int,
	@BookId int
AS
	INSERT BookAndPublishing VALUES
	(@PublishingId, @BookId)