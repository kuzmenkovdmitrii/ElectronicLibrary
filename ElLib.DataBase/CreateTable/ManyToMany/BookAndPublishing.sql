USE ElLibDataBase
GO

IF OBJECT_ID('BookAndPublishing') IS NOT NULL
DROP TABLE BookAndPublishing
GO

CREATE TABLE BookAndPublishing(
	BookId int,
	PublishingId int,
);