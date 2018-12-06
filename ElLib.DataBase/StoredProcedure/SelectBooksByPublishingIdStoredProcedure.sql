USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByPublishingId
	@PublishingId int
AS
	SELECT * FROM Books b
	SELECT 
		b.Id, 
		b.[Name], 
		bc.Id BookCategoryId,
		bc.[Name] BookCategoryName,
		a.Id AuthorId, 
		a.[Name] AuthorName, 
		a.LastName AuthorLastName, 
		a.MiddleName AuthorMiddleName, 
		a.Email AuthorEmail, 
		b.PublishingDate, 
		l.Id LanguageId, 
		l.[Name] LanguageName, 
		p.Id PublishingId,
		p.[Name] PublishingName,
		addr.Id AddressId,
		addr.Id AddressCountry,
		addr.Id AddressCity,
		addr.Id AddressStreet,
		addr.Id AddressHome,
		pict.Link Picture,
		f.Link [File]
	
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

	JOIN Addresses addr
		ON addr.Id = p.AddressId
	WHERE p.Id = @PublishingId