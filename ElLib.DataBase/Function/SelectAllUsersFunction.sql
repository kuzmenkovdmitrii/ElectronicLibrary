USE ElLibDataBase
GO

CREATE FUNCTION SelectAllUsers() 
	RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			u.Id, 
			u.UserName, 
			u.[Password], 
			u.Email, 
			r.Id [RoleId] 
		FROM Users u
		JOIN UserAndRole ur 
			ON u.Id = ur.UserId
		JOIN Roles r 
			ON r.Id = ur.RoleId
	)