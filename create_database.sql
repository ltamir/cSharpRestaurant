CREATE TABLE [dbo].[cs_appetizer] (
    [appetizerId] INT           IDENTITY (1, 1) NOT NULL,
    [dishName]    NVARCHAR (50) NOT NULL,
    [dishPrice]   FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_appetizer] PRIMARY KEY CLUSTERED ([appetizerId] ASC)
);

CREATE TABLE [dbo].[cs_dessert] (
    [desertId]  INT           IDENTITY (1, 1) NOT NULL,
    [dishName]  NVARCHAR (50) NOT NULL,
    [dishPrice] FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_cs_dessert] PRIMARY KEY CLUSTERED ([desertId] ASC)
);


CREATE TABLE [dbo].[cs_mainCourse] (
    [mainCourseId] INT           IDENTITY (1, 1) NOT NULL,
    [dishName]     NVARCHAR (50) NOT NULL,
    [dishPrice]    FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_cs_mainCourse] PRIMARY KEY CLUSTERED ([mainCourseId] ASC)
);

CREATE TABLE [dbo].[cs_sideDish] (
    [sideDishId] INT           IDENTITY (1, 1) NOT NULL,
    [dishName]   NVARCHAR (50) NOT NULL,
    [dishPrice]  FLOAT (53)    NOT NULL,
    CONSTRAINT [PK_cs_sideDish] PRIMARY KEY CLUSTERED ([sideDishId] ASC)
);

CREATE TABLE [dbo].[cs_diningTable] (
    [diningTableId] INT IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_cs_diningTable] PRIMARY KEY CLUSTERED ([diningTableId] ASC)
);


CREATE TABLE [dbo].[cs_order] (
    [orderId]       INT IDENTITY (1, 1) NOT NULL,
    [diningTableId] INT NOT NULL,
    [appetizerId]   INT NOT NULL,
    [mainCourseId]  INT NOT NULL,
    [sideDishOneId] INT NOT NULL,
    [sideDishTwoId] INT NOT NULL,
    [dessertOneId]  INT NOT NULL,
    [dessertTwoId]  INT NOT NULL,
    CONSTRAINT [PK_cs_order] PRIMARY KEY CLUSTERED ([orderId] ASC),
    CONSTRAINT [FK_order_appetizer] FOREIGN KEY ([appetizerId]) REFERENCES [dbo].[cs_appetizer] ([appetizerId]),
    CONSTRAINT [FK_cs_order_cs_mainCourse] FOREIGN KEY ([mainCourseId]) REFERENCES [dbo].[cs_mainCourse] ([mainCourseId]),
    CONSTRAINT [FK_cs_order_cs_sideDishOne] FOREIGN KEY ([sideDishOneId]) REFERENCES [dbo].[cs_sideDish] ([sideDishId]),
    CONSTRAINT [FK_cs_order_cs_sideDishTwo] FOREIGN KEY ([sideDishTwoId]) REFERENCES [dbo].[cs_sideDish] ([sideDishId]),
    CONSTRAINT [FK_cs_order_cs_dessertOne] FOREIGN KEY ([dessertOneId]) REFERENCES [dbo].[cs_dessert] ([desertId]),
    CONSTRAINT [FK_cs_order_cs_dessertTwo] FOREIGN KEY ([dessertTwoId]) REFERENCES [dbo].[cs_dessert] ([desertId]),
    CONSTRAINT [FK_cs_order_cs_diningTable] FOREIGN KEY ([diningTableId]) REFERENCES [dbo].[cs_diningTable] ([diningTableId])
);



INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'לא נבחר', 0)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'מרק ירקות', 25.5)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'מרק קטניות', 29.5)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'סלט ירוק', 17)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'חציל קלוי בטחינה', 35)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'אנטיפסטי ', 25.3)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'כבד עם ריבת בצל', 22.3)
INSERT INTO [dbo].[cs_appetizer] ([dishName], [dishPrice]) VALUES (N'כבד בלי ריבת בצל', 22.3)

INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'לא נבחר', 0)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'עוגת גבינה', 35)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'עוגת שוקולד', 33)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'עוגה ביישנית', 34.5)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'עוגה שמחה', 36.5)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'אופטיקאי מדופלם', 25)
INSERT INTO [dbo].[cs_dessert] ([dishName], [dishPrice]) VALUES (N'גלידה עטופה בריבת חלב מקורמלת', 43)

INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'לא נבחר', 0)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'אנטריקוט', 52.5)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'פילה בקר', 48.5)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'פילה סלמון', 60)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'עוף מכובס עם  גזר', 68)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'שניצל שאמא יודעת להכין', 42)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'שניצל שאמא לא יודעת להכין', 38)
INSERT INTO [dbo].[cs_mainCourse] ([dishName], [dishPrice]) VALUES (N'פשטידת ירקות', 41.5)

INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'לא נבחר', 0)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'אורז', 7.5)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'צ''יפס', 12.5)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'לחם צרפתי בגוון איטלקי', 9)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'לחם איטלקי בגוון צרפתי', 9)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'תפו"ד באבק צ''ילי', 8)
INSERT INTO [dbo].[cs_sideDish] ([dishName], [dishPrice]) VALUES (N'משמין חסר טעם', 15)

INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES
INSERT INTO cs_diningTable DEFAULT VALUES


INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (1, 2, 2, 2, 3, 2, 3)
INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (2, 3, 3, 4, 5, 4, 5)
INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (3, 5, 5, 6, 7, 6, 7)
INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (4, 1, 6, 1, 5, 3, 4)
INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (5, 6, 8, 2, 6, 6, 1)
INSERT INTO [dbo].[cs_order] ([diningTableId], [appetizerId], [mainCourseId], [sideDishOneId], [sideDishTwoId], [dessertOneId], [dessertTwoId]) VALUES (6, 6, 4, 3, 5, 2, 5)


