USE ElLibDataBase
GO

CREATE PROC AddRoleToUser
	@RoleId int,
	@UserId int
AS
	INSERT BookAndAuthor VALUES
	(@RoleId, @UserId)