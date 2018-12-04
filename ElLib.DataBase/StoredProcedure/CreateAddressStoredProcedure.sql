USE ElLibDataBase
GO

CREATE PROC CreateAddress
	@CountryId int, 
	@CityId int,
	@Street nvarchar(25),
	@Home nvarchar(25)
AS
	INSERT Authors VALUES
	(@CountryId, @CityId, @Street, @Home)