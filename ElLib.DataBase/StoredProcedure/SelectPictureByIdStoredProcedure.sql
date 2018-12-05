USE ElLibDataBase
GO

CREATE PROC usp_SelectPictureById
	@Id int
AS
	SELECT * FROM Pictures
	WHERE Id = @Id