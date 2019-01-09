USE ElLibDataBase
GO

CREATE PROC usp_RemovePublishingFromBook
	@BookId int,
	@PublishingId int
AS
	DELETE BookAndBookCategory
		WHERE BookId = @BookId 
		AND PublishingId = @PublishingId