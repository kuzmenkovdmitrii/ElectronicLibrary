USE ElLibDataBase
GO

CREATE PROC UpdateCity 
	@Id int, 
	@Name nvarchar(25)
AS
	UPDATE Cities
		SET [Name] = @Name
		WHERE Id = @id