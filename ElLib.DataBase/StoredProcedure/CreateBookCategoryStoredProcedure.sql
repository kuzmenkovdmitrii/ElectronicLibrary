USE ElLibDataBase
GO

CREATE PROC usp_CreateBookCategory
	@Name nvarchar(25),
	@Description nvarchar(100)
AS
	INSERT BookCategories([Name], [Description])
	VALUES
	(@Name, @Description)