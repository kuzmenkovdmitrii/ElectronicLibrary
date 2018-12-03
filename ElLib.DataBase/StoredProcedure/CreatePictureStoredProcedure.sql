USE ElLibDataBase
GO

CREATE PROC CreatePicture
	@Link nvarchar(100)
AS
	INSERT Pictures(Link)
	VALUES
	(@Link)