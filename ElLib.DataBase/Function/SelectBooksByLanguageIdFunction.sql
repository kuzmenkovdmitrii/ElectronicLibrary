USE ElLibDataBase
GO

CREATE FUNCTION SelectBooksByLanguageId(@LanguageId int) 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Books
		JOIN Languages l
			ON l.Id = LanguageId
		WHERE l.Id = @LanguageId
	)