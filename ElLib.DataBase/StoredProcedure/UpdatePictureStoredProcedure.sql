USE ElLibDataBase
GO

CREATE PROC usp_UpdatePicture 
	@Id int, 
	@Link nvarchar(100) 
AS
	UPDATE Pictures
		SET Link = @Link
		WHERE Id = @id