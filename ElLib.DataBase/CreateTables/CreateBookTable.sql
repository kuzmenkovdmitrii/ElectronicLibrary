USE ElLibDataBase
GO

IF OBJECT_ID('Books') IS NOT NULL
DROP TABLE Books
GO

CREATE TABLE Books(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(50) NULL,
	PublishingDate datetime NOT NULL,
	LanguageId int UNIQUE,
	FileId int UNIQUE,
	PictureId int UNIQUE,
);