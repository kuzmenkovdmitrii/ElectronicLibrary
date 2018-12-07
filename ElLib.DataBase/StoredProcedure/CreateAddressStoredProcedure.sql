USE ElLibDataBase
GO

CREATE PROC usp_CreateAddress
	@Country nvarchar(25), 
	@City nvarchar(25),
	@Street nvarchar(25),
	@Home nvarchar(25)
AS
	INSERT Addresses VALUES
	(@Country, @City, @Street, @Home)