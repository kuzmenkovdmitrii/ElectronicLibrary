USE ElLibDataBase
GO

CREATE PROC UpdateBookCategory 
	@Id int, 
	@Name nvarchar(25), 
	@Description nvarchar(100)
AS
	UPDATE BookCategories
		SET 
		[Name] = @Name, 
		[Description] = @Description
		WHERE Id = @id