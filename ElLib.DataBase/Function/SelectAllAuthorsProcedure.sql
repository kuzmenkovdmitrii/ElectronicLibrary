﻿USE ElLibDataBase
GO

CREATE FUNCTION SelectAllAuthors()
	RETURNS TABLE 
AS
	RETURN
	(
		SELECT * FROM Authors
	)