USE ElLibDataBase
GO

--создание авторов
EXEC usp_CreateAuthor 'Софи', 'Оксанен','Уилсен','sofioksanen@gmail.com';
EXEC usp_CreateAuthor 'Михаил', 'Ульянов','Васильевич','ulianovmihail@yandex.ru';
EXEC usp_CreateAuthor 'Александр', 'Пушкин','Сергеевич', NULL;
EXEC usp_CreateAuthor 'Лев', 'Толстой','Николаевич', NULL;

--создание жанров
EXEC usp_CreateBookCategory 'Детектив', 'Преимущественно литературный жанр, произведения которого описывают процесс исследования загадочного происшествия с целью выяснения его обстоятельств и раскрытия загадки.';
EXEC usp_CreateBookCategory 'Комедия', 'вид драматургического произведения. Отображает все уродливое и нелепое, смешное и несуразное, высмеивает пороки общества.';
EXEC usp_CreateBookCategory 'Мелодрама', 'Вид драмы, действующие лица которой резко делятся на положительных и отрицательных.';
EXEC usp_CreateBookCategory 'Роман', 'Большая форма; произведение, в событиях которого обычно принимает участие много действующих лиц, чьи судьбы переплетаются. Романы бывают философские, приключенческие, исторические, семейно-бытовые, социальные.';

--создание издательств
EXEC usp_CreatePublishing 'Альграфияпресс', 'Беларусь','Минск', 'Смолячкова','9 (415)';
EXEC usp_CreatePublishing 'Capital Print', 'Беларусь','Минск', 'Скорины','40 (215)';
EXEC usp_CreatePublishing 'Best издательство', 'Украина','Киев', 'Центральная','9б';
EXEC usp_CreatePublishing 'DC', 'Россия','Смоленск', 'Строительная','1г';

--создание книги
EXEC usp_CreateBook 'When the doves disappeared', 4,'20180105', 'https://404store.com/2017/08/12/55b747bd197da.jpg','https://www.adidas-group.com/media/filer_public/2013/07/31/adidas_gb_2012_en_booklet_en.pdf';
EXEC usp_CreateBook 'Nike', 6,'20180213', 'https://book24.ua/upload/iblock/cbd/cbd736cb981c46511850229c29156414.jpg','https://niketeam.nike.com/niketeamsports/content/pdf/catalog_thumbs/SP17_M_Soccer_Team.pdf';
EXEC usp_CreateBook 'Евгений онегин', 1,'20180529', 'https://litergazeta.ru/static/post_img/knigavuhe/04839c1f96a73ec568e7ae3013ba5384.jpg','http://www.kharkivosvita.net.ua/files/evgenij-onegin.pdf';
EXEC usp_CreateBook 'Война и мир', 1,'20181221', 'http://top10a.ru/wp-content/uploads/2016/01/%C2%AB%D0%92%D0%BE%D0%B9%D0%BD%D0%B0-%D0%B8-%D0%BC%D0%B8%D1%80%C2%BB-%D0%9B.-%D0%9D.-%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9.jpg','http://www.lysychansk-gymnasium.edukit.lg.ua/Files/downloads/%D0%A2%D0%BE%D0%BB%D1%81%D1%82%D0%BE%D0%B9%D0%92%D0%BE%D0%B9%D0%BD%D0%B0%D0%98%D0%9C%D0%B8%D1%80To%D0%BC_1_2..pdf';
EXEC usp_CreateBook 'Нибывалые былицы', 3,'20190103', 'https://img-gorod.ru/upload/iblock/85f/85f7e7876a6e951605794b4c6a947126.jpg','http://www.dou75.ru/68/images/stories/detskay/chitaem_vmeste/pisateli/r_12.pdf';

--привзяка авторов к книге
EXEC usp_AddAuthorToBook 1, 1;
EXEC usp_AddAuthorToBook 2, 2;
EXEC usp_AddAuthorToBook 3, 3;
EXEC usp_AddAuthorToBook 4, 4;
EXEC usp_AddAuthorToBook 5, 1;
EXEC usp_AddAuthorToBook 5, 2;

--привзяка жанров к книге
EXEC usp_AddBookCategoryToBook 1, 1;
EXEC usp_AddBookCategoryToBook 1, 3;
EXEC usp_AddBookCategoryToBook 2, 4;
EXEC usp_AddBookCategoryToBook 3, 1;
EXEC usp_AddBookCategoryToBook 3, 3;
EXEC usp_AddBookCategoryToBook 3, 4;
EXEC usp_AddBookCategoryToBook 4, 1;
EXEC usp_AddBookCategoryToBook 4, 4;
EXEC usp_AddBookCategoryToBook 5, 2;
EXEC usp_AddBookCategoryToBook 5, 3;

--привзяка издательств к книге
EXEC usp_AddPublishingToBook 1, 2;
EXEC usp_AddPublishingToBook 1, 3;
EXEC usp_AddPublishingToBook 2, 1;
EXEC usp_AddPublishingToBook 2, 4;
EXEC usp_AddPublishingToBook 3, 1;
EXEC usp_AddPublishingToBook 4, 3;
EXEC usp_AddPublishingToBook 5, 1;


--создание пользователей
EXEC usp_CreateUser 'first', '205114qa', 'first@mail.ru'
EXEC usp_CreateUser 'second', '205114qa', 'second@mail.ru'
EXEC usp_CreateUser 'admin', '205114qa', 'admin@mail.ru'
EXEC usp_CreateUser 'editor', '205114qa', 'editor@mail.ru'

--привязка ролей к пользователю
EXEC usp_AddRoleToUser 1,3;
EXEC usp_AddRoleToUser 2,3;
EXEC usp_AddRoleToUser 3,3;
EXEC usp_AddRoleToUser 3,2;
EXEC usp_AddRoleToUser 3,1;
EXEC usp_AddRoleToUser 4,3;
EXEC usp_AddRoleToUser 4,2;