USE ElLibDataBase
GO

CREATE PROC UpdateBooks
	@Id int, 
	@Name nvarchar(25), 
	@LanguageId nvarchar(25),
	@PublishingDate datetime
AS
	UPDATE Books
		SET 
		[Name] = @Name,
		LanguageId = @LanguageId,
		PublishingDate = @PublishingDate
		WHERE Id = @id