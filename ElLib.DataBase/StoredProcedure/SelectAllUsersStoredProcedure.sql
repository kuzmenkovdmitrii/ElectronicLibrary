USE ElLibDataBase
GO

CREATE PROC usp_SelectAllUsers
AS
	SELECT Id, UserName, Email FROM Users