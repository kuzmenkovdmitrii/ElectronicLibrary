USE ElLibDataBase
GO

CREATE FUNCTION SelectAllUsers(@RoleId int) 
	RETURNS TABLE
AS
	RETURN
	(
		SELECT * FROM Users u
		JOIN UserAndRole ur 
			ON u.Id = ur.UserId
		JOIN Roles r 
			ON r.Id = ur.RoleId
		WHERE r.Id = @RoleId
	)