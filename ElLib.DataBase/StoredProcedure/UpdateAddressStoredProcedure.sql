USE ElLibDataBase
GO

CREATE PROC UpdateAddress 
	@Id int,
	@CountryId int, 
	@CityId int, 
	@Street nvarchar(25), 
	@Home nvarchar(25) 
AS
	UPDATE Addresses
		SET
		CountryId = @CountryId,
		CityId = @CityId,
		Street = @Street,
		Home = @Home
		WHERE Id = @id