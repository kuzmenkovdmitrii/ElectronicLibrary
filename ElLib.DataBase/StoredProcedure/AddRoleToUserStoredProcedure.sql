USE ElLibDataBase
GO

CREATE PROC usp_AddRoleToUser
	@RoleId int,
	@UserId int
AS
	INSERT BookAndAuthor VALUES
	(@RoleId, @UserId)