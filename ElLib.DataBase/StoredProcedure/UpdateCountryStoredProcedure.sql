USE ElLibDataBase
GO

CREATE PROC UpdateCountry 
	@Id int, 
	@Name nvarchar(25) 
AS
	UPDATE Countries
		SET [Name] = @Name
		WHERE Id = @id