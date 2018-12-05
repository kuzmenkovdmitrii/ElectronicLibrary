USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByBookCategoryId
	@BookCategoryId int
AS
	SELECT * FROM Books b
	JOIN BookAndBookCategory bcc 
		ON b.Id = bcc.BookId
	JOIN BookCategories bc
		ON bc.Id = bcc.BookCategoryId
	WHERE bc.Id = @BookCategoryId