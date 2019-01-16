USE ElLibDataBase
GO

CREATE PROC usp_CreateBook
	@Name nvarchar(50), 
	@LanguageId int,
	@PublishingDate datetime,
	@Picture nvarchar(200),
	@File nvarchar(200)
AS	
	DECLARE @FileId int,
			@PictureId int

	INSERT Files(Link)
	VALUES
	(@File)
	SELECT @FileId = IDENT_CURRENT('Files')

	INSERT Pictures(Link)
	VALUES
	(@Picture)
	SELECT @PictureId = IDENT_CURRENT('Pictures')

	INSERT Books([Name], [LanguageId], PublishingDate, PictureId, FileId)
	VALUES
	(@Name, @LanguageId, @PublishingDate, @PictureId, @FileId)

	SELECT 
		b.Id, 
		b.[Name], 
		b.PublishingDate, 
		l.Id LanguageId, 
		l.[Name] LanguageName, 
		pict.Link Picture,
		f.Link [File]
	
	FROM Books b
		JOIN Languages l
	ON l.Id = LanguageId

	JOIN Pictures pict
		ON pict.Id = PictureId

	JOIN Files f
		ON f.Id = FileId

	WHERE b.Id = IDENT_CURRENT('Books')