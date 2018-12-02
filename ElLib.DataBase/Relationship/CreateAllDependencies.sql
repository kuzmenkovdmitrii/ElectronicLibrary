USE ElLibDataBase
GO

--one to many

ALTER TABLE Books
ADD CONSTRAINT FK_Book_Language FOREIGN KEY(LanguageId) 
    REFERENCES Languages(Id);

ALTER TABLE Books
ADD CONSTRAINT FK_Book_Picture FOREIGN KEY(PictureId) 
    REFERENCES Pictures(Id);

ALTER TABLE Books
ADD CONSTRAINT FK_Book_File FOREIGN KEY(FileId) 
    REFERENCES Files(Id);

ALTER TABLE Publishings
ADD CONSTRAINT FK_Publishing_Addresse FOREIGN KEY(AddressId) 
    REFERENCES Addresses(Id);

ALTER TABLE Addresses
ADD CONSTRAINT FK_Addresse_Country FOREIGN KEY(CountryId) 
    REFERENCES Countries(Id);

ALTER TABLE Addresses
ADD CONSTRAINT FK_Addresse_City FOREIGN KEY(CityId) 
    REFERENCES Cities(Id);

ALTER TABLE Cities
ADD CONSTRAINT FK_City_Country FOREIGN KEY(CountryId) 
    REFERENCES Countries(Id);

--many to many

ALTER TABLE BookAndAuthor
ADD CONSTRAINT FK_Book_AuthorId FOREIGN KEY(BookId)
        REFERENCES Books(Id),
	CONSTRAINT FK_Author_BookId FOREIGN KEY(AuthorId)
		REFERENCES Authors(Id);

ALTER TABLE BookAndBookCategory
ADD CONSTRAINT FK_Book_BookCategoryId FOREIGN KEY(BookId)
        REFERENCES Books(Id),
	CONSTRAINT FK_BookCategory_BookId FOREIGN KEY(BookCategoryId)
		REFERENCES BookCategories(Id);

ALTER TABLE BookAndPublishing
ADD CONSTRAINT FK_Book_PublishingId FOREIGN KEY(BookId)
        REFERENCES Books(Id),
	CONSTRAINT FK_Publishing_BookId FOREIGN KEY(PublishingId)
		REFERENCES Publishings(Id);

ALTER TABLE UserAndRole
ADD CONSTRAINT FK_User_RoleId FOREIGN KEY(UserId)
        REFERENCES Users(Id),
	CONSTRAINT FK_Role_UserId FOREIGN KEY(RoleId)
		REFERENCES Roles(Id);