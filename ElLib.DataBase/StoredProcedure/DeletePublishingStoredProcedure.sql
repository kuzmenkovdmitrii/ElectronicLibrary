USE ElLibDataBase
GO

CREATE PROC usp_DeletePublishing 
	@Id int
AS
	DELETE Publishings
		WHERE Id = @id