﻿USE ElLibDataBase
GO

CREATE PROC usp_SelectAllAuthors
AS
	SELECT * FROM Authors
	ORDER BY Id DESC