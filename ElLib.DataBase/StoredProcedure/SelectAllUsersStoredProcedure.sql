USE ElLibDataBase
GO

CREATE PROC usp_SelectAllUsers
AS
	SELECT 
		u.Id, 
		u.UserName, 
		u.[Password], 
		u.Email
	FROM Users u