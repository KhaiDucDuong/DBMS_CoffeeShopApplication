USE CoffeeShop
/* 7. Function findIngredientByName */
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

/* 8. Function CalculateShopRevenueFunction */
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'CalculateShopRevenueFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION CalculateShopRevenueFunction
GO
CREATE FUNCTION CalculateShopRevenueFunction
(
	@startDate Date,
	@endDate Date
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
	DECLARE @revenue DECIMAL(10, 2)

	SET @revenue = (SELECT SUM(finalBill)
	FROM OrderBill
	WHERE CONVERT(Date, createdAt) between @startDate and @endDate)

	IF @revenue IS NULL
		RETURN 0.00

	RETURN @revenue
END

--GO
--select dbo.CalculateShopRevenueFunction('4/5/2024', '4/6/2024') as revenue

/* 9. Function calculateRestockCost */
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'CalculateRestockCostFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION CalculateRestockCostFunction
GO
CREATE FUNCTION CalculateRestockCostFunction
(
	@startDate Date,
	@endDate Date
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
	DECLARE @cost DECIMAL(10, 2)
	SET @cost = 0
	
	SET @cost = (SELECT SUM(finalBill)
	FROM OrderBill
	WHERE CONVERT(Date, createdAt) between @startDate and @endDate)

	IF @cost IS NULL
	SET @cost = 0

	RETURN @cost
END

--SELECT dbo.CalculateRestockCostFunction('4/5/2024', '4/7/2024') as 'restock cost'