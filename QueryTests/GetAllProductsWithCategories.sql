CREATE PROCEDURE [dbo].[GetAllProductsWithCategories]
	as
	select * from dbo.Products as P
	join [dbo].Category as C 
	ON P.CategoryId = c.Id
RETURN 0
