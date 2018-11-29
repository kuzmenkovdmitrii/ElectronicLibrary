USE ElLibDataBase
GO

CREATE TABLE Publishings(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] nvarchar(25) NOT NULL,
	AddressId int NOT NULL,
);