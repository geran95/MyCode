USE master;  
GO  

--Создаем базу данных  
IF EXISTS(SELECT * from sys.databases WHERE name='ProductANDCategory')  
BEGIN  
    DROP DATABASE ProductANDCategory;  
END  


CREATE DATABASE ProductANDCategory;  
 