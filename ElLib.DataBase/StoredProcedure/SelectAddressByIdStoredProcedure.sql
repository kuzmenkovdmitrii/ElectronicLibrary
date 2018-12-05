USE ElLibDataBase
GO

CREATE PROC usp_SelectAddressById
	@Id int
AS
	SELECT * FROM Addresses
	WHERE Id = @Id