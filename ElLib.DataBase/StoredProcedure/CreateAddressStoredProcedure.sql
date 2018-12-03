USE ElLibDataBase
GO

CREATE PROC CreateAuthor
	@CountryId int, 
	@CityId int,
	@Street nvarchar(25),
	@Home nvarchar(25)
AS
	INSERT Authors VALUES
	(@CountryId, @CityId, @Street, @Home)