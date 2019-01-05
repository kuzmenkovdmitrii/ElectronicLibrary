USE ElLibDataBase
GO

CREATE PROC usp_AddBookCategoryToBook
	@BookId int,
	@PublishingId int
AS
	INSERT BookAndPublishing VALUES
	(@BookId, @PublishingId)