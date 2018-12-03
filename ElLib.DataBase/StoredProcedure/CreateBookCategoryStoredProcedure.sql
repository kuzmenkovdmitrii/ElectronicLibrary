USE ElLibDataBase
GO

CREATE PROC CreateBookCategory
	@Name nvarchar(25),
	@Description nvarchar(100)
AS
	INSERT BookCategories([Name], [Description])
	VALUES
	(@Name, @Description)