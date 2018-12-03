USE ElLibDataBase
GO

CREATE PROC SelectUsersByRoleId
	@RoleId int
AS
	SELECT * FROM Users u
	JOIN UserAndRole ur 
		ON u.Id = ur.UserId
	JOIN Roles r 
		ON r.Id = ur.RoleId
	WHERE r.Id = @RoleId