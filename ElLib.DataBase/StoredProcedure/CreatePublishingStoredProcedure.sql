USE ElLibDataBase
GO

CREATE PROC usp_CreatePublishing
	@Name nvarchar(25),
	@AddressId int
AS
	INSERT Publishings([Name], AddressId)
	VALUES
	(@Name, @AddressId)