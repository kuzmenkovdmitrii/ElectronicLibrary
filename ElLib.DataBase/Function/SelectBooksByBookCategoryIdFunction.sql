USE ElLibDataBase
GO

CREATE FUNCTION SelectBooksByBookCategoryId(@BookCategoryId int) 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Books b
		JOIN BookAndBookCategory bc 
			ON b.Id = bc.BookId
		JOIN BookCategories bc
			ON bc.Id = bc.BookCategoryId
		WHERE bc.Id = @BookCategoryId
	)