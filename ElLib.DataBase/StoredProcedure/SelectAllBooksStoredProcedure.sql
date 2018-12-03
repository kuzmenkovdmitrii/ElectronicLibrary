USE ElLibDataBase
GO

CREATE PROC SelectAllBooks
AS
	SELECT 
		b.Id, 
		b.[Name], 
		bc.Id [BookCategoriesId],
		a.Id [AuthorId], 
		b.PublishingDate, 
		l.Id [LanguageId], 
		p.Id[PublishingId],
		pict.Id[PictureId],
		f.Id[FileId]
	
	FROM Books b
		JOIN Languages l
	ON l.Id = LanguageId

	JOIN Pictures pict
		ON pict.Id = PictureId

	JOIN [File] f
		ON f.Id = FileId

	JOIN BookAndAuthor ba 
		ON b.Id = ba.BookId
	JOIN Authors a 
		ON a.Id = ba.AuthorId

	JOIN BookAndBookCategory bc 
		ON b.Id = bc.BookId
	JOIN BookCategories bc
		ON bc.Id = bc.BookCategoryId

	JOIN BookAndPublishing bp 
		ON b.Id = bp.BookId
	JOIN Publishing p 
		ON p.Id = bp.PublishingId