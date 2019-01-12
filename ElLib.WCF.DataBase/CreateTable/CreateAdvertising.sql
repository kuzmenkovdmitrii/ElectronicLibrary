USE ElLibWCFDataBase
GO

IF OBJECT_ID('Advertising') IS NOT NULL
DROP TABLE Advertising
GO

CREATE TABLE Advertising(
	Id int PRIMARY KEY IDENTITY,
	Title nvarchar(50) NOT NULL,
	[Url] nvarchar(200) NOT NULL,
	Picture nvarchar (200) NOT NULL
);