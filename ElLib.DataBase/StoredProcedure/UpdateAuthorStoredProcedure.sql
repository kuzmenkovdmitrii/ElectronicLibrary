USE ElLibDataBase
GO

CREATE PROC UpdateAuthor 
	@Id int, 
	@Name nvarchar(25), 
	@LastName nvarchar(25), 
	@MiddleName nvarchar(25), 
	@Email nvarchar(50)
AS
	UPDATE Authors
		SET 
		[Name] = @Name,
		LastName = @LastName,
		MiddleName = @MiddleName,
		Email = @Email
		WHERE Id = @id