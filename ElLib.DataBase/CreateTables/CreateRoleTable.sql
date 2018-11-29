﻿USE ElLibDataBase
GO

IF OBJECT_ID('Roles') IS NOT NULL
DROP TABLE Roles
GO

CREATE TABLE Roles(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] nvarchar(25) NOT NULL,
	[Description] nvarchar(100) NULL,
);