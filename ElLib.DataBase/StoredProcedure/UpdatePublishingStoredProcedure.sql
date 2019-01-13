USE ElLibDataBase
GO

CREATE PROC usp_UpdatePublishing 
	@Id int, 
	@Name nvarchar(50),
	@Country nvarchar(50), 
	@City nvarchar(50),
	@Street nvarchar(50),
	@Home nvarchar(50)
AS
	UPDATE Publishings
		SET [Name] = @Name
		WHERE Id = @Id

	DECLARE @AddressId int
	SET @AddressId = (SELECT AddressId FROM Publishings WHERE Id = @Id)

	UPDATE Addresses
		SET Country = @Country,
		City = @City,
		Street = @Street,
		Home = @Home
		WHERE Id = @AddressId