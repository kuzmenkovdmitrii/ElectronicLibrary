﻿USE ElLibDataBase
GO

IF OBJECT_ID('Pictures') IS NOT NULL
DROP TABLE Pictures
GO

CREATE TABLE Pictures(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	Link nvarchar(max) NOT NULL,
);