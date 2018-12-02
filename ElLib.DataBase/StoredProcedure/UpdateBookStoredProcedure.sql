USE ElLibDataBase
GO

CREATE PROC UpdateBooks
	@Id int, 
	@Name nvarchar(25), 
	@Language nvarchar(25),
	@PublishingDate datetime,
	@Picture nvarchar(100),
	@File nvarchar(100)
AS

	DECLARE @LanguageId int;
	SELECT @LanguageId = Languages.Id 
		FROM Languages 
		WHERE [Name] = @Language;

	DECLARE @PublishingId int;
	SELECT @PublishingId = Publishings.Id 
		FROM Publishings 
		WHERE [Name] = @Country;

	UPDATE Books
		SET 
		[Name] = @Name,
		LanguageId = @LanguageId,
		Publishing = @PublishingId,
		PublishingDate = @PublishingDate
		WHERE Id = @id