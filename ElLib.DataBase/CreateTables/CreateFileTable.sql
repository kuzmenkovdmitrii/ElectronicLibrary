﻿USE ElLibDataBase
GO

IF OBJECT_ID('Files') IS NOT NULL
DROP TABLE Files
GO

CREATE TABLE Files(
	Id int PRIMARY KEY IDENTITY,
	Link nvarchar(max) NOT NULL,
);