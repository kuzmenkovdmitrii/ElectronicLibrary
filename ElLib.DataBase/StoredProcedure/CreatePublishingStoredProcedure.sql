USE ElLibDataBase
GO

CREATE PROC CreatePublishing
	@Name nvarchar(25),
	@AddressId int
AS
	INSERT Publishings([Name], AddressId)
	VALUES
	(@Name, @AddressId)