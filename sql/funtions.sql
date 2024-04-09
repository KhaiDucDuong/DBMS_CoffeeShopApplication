USE CoffeeShop
	 
--1. Function findEmployeeByName
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'findEmployeeByNameFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION findEmployeeByNameFunction
GO
CREATE FUNCTION findEmployeeByNameFunction 
( 
	 @EmployeeName NVARCHAR(100)
)
RETURN TABLE
RETURN (
    SELECT * FROM Employee WHERE fullName = @EmployeeName
);
--2. Function findOrderBillById
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'findOrderBillByIdFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION findOrderBillByIdFunction
GO
CREATE FUNCTION findOrderBillByIdFunction 
( 
	 @OrderBillId uniqueidentifier
)
RETURN TABLE
RETURN (
    SELECT * FROM GetOrderBillDetailsView WHERE billId = @OrderBilId
);
--3. Function findCustomerByPhoneNumber
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'findCustomerByPhoneNumberFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION findCustomerByPhoneNumberFunction
GO
CREATE FUNCTION findCustomerByPhoneNumberFunction 
( 
	 @PhoneNumber VARCHAR(15)
)
RETURN TABLE
RETURN (
    SELECT * FROM Customer WHERE phoneNumber = @PhoneNumber
);
/* 4. Function findProductByName*/
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'FindProductByNameFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION FindProductByNameFunction
GO
CREATE FUNCTION FindProductByNameFunction
(
    @productName NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT productId, productName, productSize, productPrice, createdAt, updatedAt
    FROM Product
    WHERE productName LIKE '%' + @productName + '%' AND isDeleted = 0
);

/* 5. Function findIventoryByName*/
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'FindInventoryByNameFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION FindInventoryByNameFunction
GO
CREATE FUNCTION FindInventoryByNameFunction
(
    @inventoryName NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT inventoryId, name
    FROM Inventory
    WHERE name LIKE '%' + @inventoryName + '%'
);
/* 6. Function findInventoryCheckByDate*/
GO
IF EXISTS (
    SELECT * FROM sysobjects WHERE id = object_id(N'FindInventoryCheckByDateFunction') 
    AND xtype IN (N'FN', N'IF', N'TF')
)
    DROP FUNCTION FindInventoryCheckByDateFunction
GO
CREATE FUNCTION FindInventoryCheckByDateFunction
(
    @checkDate DATE
)
RETURNS TABLE
AS
RETURN
(
    SELECT checkId, employeeId, inventoryId, checkDate
    FROM InventoryCheck
    WHERE CAST(checkDate AS DATE) = CAST(@checkDate AS DATE)
);

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
