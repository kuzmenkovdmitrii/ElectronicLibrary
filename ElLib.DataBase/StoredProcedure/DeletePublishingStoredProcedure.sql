USE ElLibDataBase
GO

CREATE PROC DeletePublishing 
	@Id int
AS
	DELETE Publishings
		WHERE Id = @id