USE ElLibDataBase
GO

CREATE PROC usp_SelectBooksByLanguageId
	@LanguageId int
AS
	SELECT * FROM Books
	JOIN Languages l
		ON l.Id = LanguageId
	WHERE l.Id = @LanguageId