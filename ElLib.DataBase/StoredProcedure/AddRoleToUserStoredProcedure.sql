USE ElLibDataBase
GO

CREATE PROC usp_AddRoleToUser
	@UserId int,
	@RoleId int
AS
	INSERT UserAndRole VALUES
	(@UserId, @RoleId)