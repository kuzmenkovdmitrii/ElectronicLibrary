﻿USE ElLibDataBase
GO

CREATE PROC usp_SelectAllRoles
AS
	SELECT * FROM Roles
	ORDER BY Id DESC