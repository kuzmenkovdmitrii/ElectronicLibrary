USE ElLibDataBase
GO

CREATE PROC DeleteCountry 
	@Id int
AS
	DELETE Countries
		WHERE Id = @id