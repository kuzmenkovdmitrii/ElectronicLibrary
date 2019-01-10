USE ElLibDataBase
GO

CREATE PROC usp_SelectAllAddresses
AS
	SELECT * FROM Addresses
	ORDER BY Id DESC