-- Создаем таблицы для нашей базы данных
USE ProductANDCategory
GO 
CREATE TABLE dbo.Products  
   (ProductID int PRIMARY KEY NOT NULL,  
    ProductName nvarchar(50) NOT NULL,  
    Price money NULL,
	Category int NULL)
GO  
CREATE TABLE dbo.Category  
   (CategoryID int PRIMARY KEY NOT NULL,  
    CategoryName nvarchar(50) NOT NULL) 
    
GO  

