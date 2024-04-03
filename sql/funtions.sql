USE CoffeeShop
/* 1. Function findIngredientByName */
GO
CREATE FULLTEXT CATALOG CoffeeShopFTCatalog WITH Accent_sensitivity = OFF --Create a catalog for the database, pls don't create a second one
--GO
--CREATE UNIQUE INDEX ui_ukIngredient ON Ingredient(ingredientId); 
GO
CREATE FULLTEXT INDEX ON Ingredient
(  
		ingredientName               --Full-text index column name   
        Language 1066                --1066 is for Vietnamese 
)  

KEY INDEX PK_Ingredient ON CoffeeShopFTCatalog --Unique index  
WITH CHANGE_TRACKING AUTO            --Population type;  
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'FindIngredientByNameFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION FindIngredientByNameFunction
GO
CREATE FUNCTION FindIngredientByNameFunction
(
	@ingredientName NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
	SELECT ingredientId, ingredientName, manufacturerName, updatedAt
	FROM Ingredient
	WHERE isDeleted = 0 and FREETEXT(ingredientName, @ingredientName)
);

--GO
--EXEC InsertIngredientProc N'Cà phê rang', N'Trung Nguyên';
--EXEC InsertIngredientProc N'Bơ rang', N'Lò Cai';
--EXEC InsertIngredientProc N'Bánh Mì', N'Tiệm bánh Mỹ Tâm';
--EXEC InsertIngredientProc N'hảo Hảo', N'Acecook';

--GO
--SELECT * FROM Ingredient
--GO
--SELECT * FROM FindIngredientByNameFunction('Bo')