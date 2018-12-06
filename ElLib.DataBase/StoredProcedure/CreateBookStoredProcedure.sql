USE ElLibDataBase
GO

CREATE PROC usp_CreateBook
	@Name nvarchar(25), 
	@LanguageId nvarchar(25),
	@PublishingDate datetime,
	@Picture nvarchar(100),
	@File nvarchar(100)
AS	
	DECLARE @FileId int
	INSERT Files(Link)
	VALUES
	(@File)
	SELECT @FileId = IDENT_CURRENT('Files')

	DECLARE @PictureId int
	INSERT Pictures(Link)
	VALUES
	(@Picture)
	SELECT @PictureId = IDENT_CURRENT('Pictures')

	INSERT Books([Name], [LanguageId], PublishingDate, PictureId, FileId)
	VALUES
	(@Name, @LanguageId, @PublishingDate, @PictureId, @FileId)

	

	