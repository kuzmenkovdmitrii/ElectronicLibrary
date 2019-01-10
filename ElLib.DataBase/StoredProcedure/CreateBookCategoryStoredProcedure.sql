USE ElLibDataBase
GO

CREATE PROC usp_CreateBookCategory
	@Name nvarchar(50),
	@Description nvarchar(300)
AS
	INSERT BookCategories([Name], [Description])
	VALUES
	(@Name, @Description)