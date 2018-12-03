USE ElLibDataBase
GO

CREATE PROC CreateFile
	@Link nvarchar(100)
AS
	INSERT Files(Link)
	VALUES
	(@Link)