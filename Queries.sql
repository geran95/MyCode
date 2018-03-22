USE ProductANDCategory
GO 

SELECT product.ProductName , product.Category , category.CategoryName 
FROM dbo.Products product
LEFT JOIN dbo.Category category ON product.Category = category.CategoryID
GO

