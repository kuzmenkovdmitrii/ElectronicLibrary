USE ElLibDataBase
GO

CREATE PROC usp_SelectAuthorsByBookId
	@Id int
AS
	SELECT 
		Id, 
		[Name], 
		LastName, 
		MiddleName, 
		Email 
	FROM Authors
		JOIN BookAndAuthor ba
			ON ba.AuthorId = Id
		WHERE ba.BookId = @Id
	ORDER BY Id DESC