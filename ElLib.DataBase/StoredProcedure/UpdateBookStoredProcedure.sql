USE ElLibDataBase
GO

CREATE PROC usp_UpdateBooks
	@Id int, 
	@Name nvarchar(25), 
	@LanguageId nvarchar(25),
	@PublishingDate datetime,
	@Picture nvarchar(100), 
	@File nvarchar(100)
AS
	UPDATE Books
		SET 
		[Name] = @Name,
		LanguageId = @LanguageId,
		PublishingDate = @PublishingDate
	WHERE Id = @id

	DECLARE @FileId int
	SET @FileId = (SELECT FileId FROM Books WHERE Id = @Id)

	UPDATE Files
		SET
		Link = @File
		WHERE Id = @FileId

	DECLARE @PictureId int
	SET @FileId = (SELECT PictureId FROM Books WHERE Id = @Id)

	UPDATE Picture
		SET
		Link = @Picture
	WHERE Id = @PictureId