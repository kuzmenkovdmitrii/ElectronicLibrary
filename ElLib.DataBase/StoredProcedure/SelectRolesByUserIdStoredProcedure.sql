USE ElLibDataBase
GO

CREATE PROC usp_SelectRolesByUserId
	@Id int 
AS
	SELECT r.Id, r.[Name], r.[Description] FROM Roles r
		JOIN  UserAndRole ur
			ON ur.RoleId = r.Id
		WHERE ur.UserId = @Id
	ORDER BY r.Id DESC