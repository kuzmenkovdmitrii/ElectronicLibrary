USE ElLibWCFDataBase
GO

CREATE PROC usp_SelectRandomAdvertisingByCount
	@Count int
AS
	SELECT TOP (@Count) * FROM Advertising
	ORDER BY NEWID() 