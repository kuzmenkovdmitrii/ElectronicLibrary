USE ElLibDataBase
GO

CREATE PROC DeletePicture 
	@Id int
AS
	DELETE Pictures
		WHERE Id = @id