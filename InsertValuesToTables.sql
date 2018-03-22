--Заполняем наши таблицы данными
USE ProductANDCategory
GO 
-- Продукты
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (1,'Apple',10,NULL)
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (2,'Pear',15,1)
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (3,'Watermelon',140,1)
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (4,'Wrench',400,2)
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (5,'ClowHammer',500,NULL)
INSERT dbo.Products (ProductID,ProductName,Price,Category)
	VALUES (6,'InsulatingTape',20,2)

-- Категории
INSERT dbo.Category (CategoryID,CategoryName)
	VALUES (1,'Fruits')
INSERT dbo.Category (CategoryID,CategoryName)
	VALUES (2,'Tools')