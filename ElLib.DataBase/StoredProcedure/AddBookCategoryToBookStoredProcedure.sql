USE ElLibDataBase
GO

CREATE PROC usp_AddBookCategoryToBook
	@BookId int,
	@PublishingId int
AS
	INSERT BookAndBookCategory VALUES
	(@BookId, @PublishingId)