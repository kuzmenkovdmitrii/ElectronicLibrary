USE ElLibDataBase
GO

CREATE PROC usp_CreateRole
	@Name nvarchar(25),
	@Description nvarchar(100)
AS
	INSERT Roles([Name], [Description])
	VALUES
	(@Name, @Description)