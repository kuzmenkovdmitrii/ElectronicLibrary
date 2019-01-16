USE ElLibDataBase
GO

CREATE PROC usp_AddPublishingToBook
	@BookId int,
	@PublishingId int
AS
	INSERT BookAndPublishing VALUES
	(@BookId, @PublishingId)