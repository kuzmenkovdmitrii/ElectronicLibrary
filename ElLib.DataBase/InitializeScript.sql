USE ElLibDataBase
GO

EXEC usp_CreateLanguage 'Русский';
EXEC usp_CreateLanguage 'Английский';
EXEC usp_CreateLanguage 'Украинский';
EXEC usp_CreateLanguage 'Французский';
EXEC usp_CreateLanguage 'Китайский';
EXEC usp_CreateLanguage 'Арабский';
EXEC usp_CreateLanguage 'Немецкий';
EXEC usp_CreateLanguage 'Португальский';
EXEC usp_CreateLanguage 'Польский';

INSERT Roles([Name],[Description])
VALUES
('Admin', 'Адинистратор сайта может назначать роли другим пользователям, редактировать данные.'),
('Editor', 'Редактор сайта может создавать, редактировать и удалять книги, жанры, языки и так далее.'),
('User', 'Обычный пользователь, который может просматривать всю информацию связанную с книгами');