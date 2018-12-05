USE ElLibDataBase
GO

CREATE PROC usp_UpdatePublishing 
	@Id int, 
	@Name nvarchar(25) 
AS
	UPDATE Publishings
		SET [Name] = @Name
		WHERE Id = @id