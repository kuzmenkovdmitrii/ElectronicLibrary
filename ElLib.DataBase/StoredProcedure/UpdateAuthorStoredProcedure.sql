USE ElLibDataBase
GO

CREATE PROC usp_UpdateAuthor 
	@Id int, 
	@Name nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50),
	@Email nvarchar(50) = NULL
AS
	UPDATE Authors
		SET 
		[Name] = @Name,
		LastName = @LastName,
		MiddleName = @MiddleName,
		Email = @Email
		WHERE Id = @id