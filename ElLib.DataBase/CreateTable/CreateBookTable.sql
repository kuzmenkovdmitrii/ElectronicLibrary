USE ElLibDataBase
GO

IF OBJECT_ID('Books') IS NOT NULL
DROP TABLE Books
GO

CREATE TABLE Books(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(50) NOT NULL,
	PublishingDate datetime NULL,
	LanguageId int,
	FileId int,
	PictureId int,
);