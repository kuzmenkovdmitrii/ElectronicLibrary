﻿USE ElLibDataBase
GO

CREATE PROC usp_UpdateRole 
	@Id int, 
	@Name nvarchar(25), 
	@Description nvarchar(100)
AS
	UPDATE Roles
		SET 
		[Name] = @Name, 
		[Description] = @Description
		WHERE Id = @id