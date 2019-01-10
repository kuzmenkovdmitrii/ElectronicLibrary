USE ElLibDataBase
GO

CREATE PROC usp_SelectUsersByQuery
	@Query nvarchar(50)
AS
	SELECT Id, UserName, Email FROM Users
		WHERE UserName
			LIKE '%' + @Query + '%'
		OR
		Email
			LIKE '%' + @Query + '%'
	ORDER BY Id DESC