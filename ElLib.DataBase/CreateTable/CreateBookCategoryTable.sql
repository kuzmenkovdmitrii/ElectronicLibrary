﻿USE ElLibDataBase
GO

IF OBJECT_ID('BookCategories') IS NOT NULL
DROP TABLE BookCategories
GO

CREATE TABLE BookCategories(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(25) NOT NULL,
	[Description] nvarchar(300) NULL,
);