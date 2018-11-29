USE ElLibDataBase
GO

IF OBJECT_ID('Books') IS NOT NULL
DROP TABLE Books
GO

CREATE TABLE Books(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] nvarchar(50) NULL,
	PublishingDate datetime NOT NULL,
	LanguageId int NULL,
	FileId int NOT NULL,
	PictureId int NULL,
);