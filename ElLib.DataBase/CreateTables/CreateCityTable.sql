﻿USE ElLibDataBase
GO

IF OBJECT_ID('Cities') IS NOT NULL
DROP TABLE Cities
GO

CREATE TABLE Cities(
	Id int PRIMARY KEY IDENTITY,
	[Name] nvarchar(25) NOT NULL,
);