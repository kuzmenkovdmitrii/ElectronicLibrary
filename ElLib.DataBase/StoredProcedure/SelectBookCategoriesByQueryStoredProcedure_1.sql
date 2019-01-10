USE ElLibDataBase
GO

CREATE PROC usp_SelectBookCategoriesByQuery
	@Query nvarchar(50)
AS
	SELECT 
		Id, 
		[Name], 
		[Description] 
	FROM BookCategories
		WHERE [Name]
			LIKE '%' + @Query + '%'
	ORDER BY Id DESC