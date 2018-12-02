USE ElLibDataBase
GO

CREATE FUNCTION SelectAllPublishings() 
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Publishings
	)