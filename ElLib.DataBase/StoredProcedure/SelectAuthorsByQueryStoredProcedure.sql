USE ElLibDataBase
GO

CREATE PROC usp_SelectAuthorsByQuery
	@Query nvarchar(50)
AS
	SELECT 
		Id, 
		[Name], 
		LastName, 
		MiddleName, 
		Email 
	FROM Authors
		WHERE [Name]
			LIKE '%' + @Query + '%'
		OR
		LastName
			LIKE '%' + @Query + '%'
		OR
		MiddleName
			LIKE '%' + @Query + '%'
		OR
		Email
			LIKE '%' + @Query + '%'
	ORDER BY Id DESC