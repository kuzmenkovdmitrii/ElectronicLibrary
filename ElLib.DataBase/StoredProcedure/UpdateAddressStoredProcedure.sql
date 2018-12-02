USE ElLibDataBase
GO

CREATE PROC UpdateAddress 
	@Id int,
	@Country nvarchar(25), 
	@Sity nvarchar(25), 
	@Street nvarchar(25), 
	@Home nvarchar(25) 
AS
	DECLARE @CountryId int;
	SELECT @CountryId = Countries.Id 
		FROM Countries 
		WHERE [Name] = @Country;

	DECLARE @CityId int;
	SELECT @CityId = Cities.Id 
		FROM Cities
		WHERE [Name] = @City;

	UPDATE Addresses
		SET
		CountryId = @CountryId,
		CityId = @CityId,
		Street = @Street,
		Home = @Home
		WHERE Id = @id