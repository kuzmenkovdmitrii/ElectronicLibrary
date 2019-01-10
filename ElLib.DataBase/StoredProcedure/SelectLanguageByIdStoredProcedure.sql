USE ElLibDataBase
GO

CREATE PROC usp_SelectLanguageById
	@Id int
AS
	SELECT * FROM Languages
		WHERE Id = @Id