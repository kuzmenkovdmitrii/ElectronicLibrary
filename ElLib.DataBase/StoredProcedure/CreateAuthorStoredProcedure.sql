USE ElLibDataBase
GO

CREATE PROC usp_CreateAuthor
	@Name nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Email nvarchar(50)
AS
	INSERT Authors([Name], LastName, MiddleName, Email)
	VALUES
	(@Name, @LastName, @MiddleName, @Email)