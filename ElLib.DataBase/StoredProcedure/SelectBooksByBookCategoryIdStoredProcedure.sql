USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByBookCategoryId
	@Id int
AS
	SELECT 
		b.Id, 
		b.[Name], 
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

	JOIN BookAndBookCategory bc
		ON bc.BookId = b.Id
	WHERE bc.BookCategoryId = @Id