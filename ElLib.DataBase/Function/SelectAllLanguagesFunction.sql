USE ElLibDataBase
GO

CREATE FUNCTION SelectAllLanguages()
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Languages
	)