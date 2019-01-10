USE ElLibDataBase
GO

CREATE PROC usp_CreatePublishing
	@Name nvarchar(50),
	@Country nvarchar(50), 
	@City nvarchar(50),
	@Street nvarchar(50),
	@Home nvarchar(50)
AS
	DECLARE @AddressId int

	INSERT Addresses VALUES
	(@Country, @City, @Street, @Home)
	SELECT @AddressId = IDENT_CURRENT('Addresses')

	INSERT Publishings([Name], AddressId)
	VALUES
	(@Name, @AddressId)