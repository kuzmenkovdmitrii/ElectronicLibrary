USE ElLibDataBase
GO

CREATE PROC usp_SelectAllBookCategories
AS
	SELECT * FROM BookCategories
	ORDER BY Id DESC