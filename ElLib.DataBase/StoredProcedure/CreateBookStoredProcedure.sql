USE ElLibDataBase
GO

CREATE PROC CreateBook
	@Name nvarchar(25), 
	@LanguageId nvarchar(25),
	@PublishingDate datetime,
	@PictureId nvarchar(100),
	@FileId nvarchar(100)
AS
	INSERT Books([Name], [LanguageId], PublishingDate, PictureId, FileId)
	VALUES
	(@Name, @LanguageId, @PublishingDate, @PictureId,	@FileId)