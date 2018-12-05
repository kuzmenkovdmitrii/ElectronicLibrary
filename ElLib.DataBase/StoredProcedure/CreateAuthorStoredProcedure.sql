USE ElLibDataBase
GO

CREATE PROC usp_CreateAuthor
	@Name nvarchar(25),
	@LastName nvarchar(25),
	@MiddleName nvarchar(25),
	@Email nvarchar(50)
AS
	INSERT Authors([Name], LastName, MiddleName, Email)
	VALUES
	(@Name, @LastName, @MiddleName, @Email)