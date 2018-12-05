USE ElLibDataBase
GO

CREATE PROC usp_UpdateAddress 
	@Id int,
	@Country nvarchar(25), 
	@City nvarchar(25), 
	@Street nvarchar(25), 
	@Home nvarchar(25) 
AS
	UPDATE Addresses
		SET
		Country = @Country,
		City = @City,
		Street = @Street,
		Home = @Home
		WHERE Id = @id