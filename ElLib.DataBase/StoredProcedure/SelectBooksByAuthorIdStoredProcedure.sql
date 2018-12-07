USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByAuthorId
	@Id int 
AS
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

	JOIN BookAndAuthor ba
		ON ba.BookId = b.Id
	WHERE ba.AuthorId = @Id