USE CoffeeShop
GO
-- 1. Function findEmployeeByName
IF OBJECT_ID(N'findEmployeeByNameFunction', 'FN') IS NOT NULL
    DROP FUNCTION findEmployeeByNameFunction
GO

CREATE FUNCTION findEmployeeByNameFunction 
( 
    @EmployeeName NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM Employee WHERE fullName = @EmployeeName
);
GO

-- 2. Function findOrderBillById
IF OBJECT_ID(N'findOrderBillByIdFunction', 'FN') IS NOT NULL
    DROP FUNCTION findOrderBillByIdFunction
GO

CREATE FUNCTION findOrderBillByIdFunction 
( 
    @OrderBillId UNIQUEIDENTIFIER
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM GetOrderBillDetailsView WHERE billId = @OrderBillId
);
GO

-- 3. Function findCustomerByPhoneNumber
IF OBJECT_ID(N'findCustomerByPhoneNumberFunction', 'FN') IS NOT NULL
    DROP FUNCTION findCustomerByPhoneNumberFunction
GO

CREATE FUNCTION findCustomerByPhoneNumberFunction 
( 
    @PhoneNumber VARCHAR(15)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM Customer WHERE phoneNumber = @PhoneNumber
);
GO

-- 4. Function findProductByName
IF OBJECT_ID(N'FindProductByNameFunction', 'FN') IS NOT NULL
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

-- 5. Function findInventoryByName
IF OBJECT_ID(N'FindInventoryByNameFunction', 'FN') IS NOT NULL
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

-- 6. Function findInventoryCheckByDate
IF OBJECT_ID(N'FindInventoryCheckByDateFunction', 'FN') IS NOT NULL
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

-- 7. Function findIngredientByName
IF OBJECT_ID(N'FindIngredientByNameFunction', 'FN') IS NOT NULL
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
    WHERE isDeleted = 0 AND FREETEXT(ingredientName, @ingredientName)
);
GO

-- 8. Function CalculateShopRevenueFunction
IF OBJECT_ID(N'CalculateShopRevenueFunction', 'FN') IS NOT NULL
    DROP FUNCTION CalculateShopRevenueFunction
GO

CREATE FUNCTION CalculateShopRevenueFunction
(
    @startDate DATE,
    @endDate DATE
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @revenue DECIMAL(10, 2)

    SET @revenue = (SELECT ISNULL(SUM(finalBill), 0)
    FROM OrderBill
    WHERE CONVERT(DATE, createdAt) BETWEEN @startDate AND @endDate)

    RETURN @revenue
END

-- 9. Function CalculateRestockCostFunction
IF OBJECT_ID(N'CalculateRestockCostFunction', 'FN') IS NOT NULL
    DROP FUNCTION CalculateRestockCostFunction
GO

CREATE FUNCTION CalculateRestockCostFunction
(
    @startDate DATE,
    @endDate DATE
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @cost DECIMAL(10, 2)
    SET @cost = 0

    SET @cost = (SELECT ISNULL(SUM(finalBill), 0)
    FROM OrderBill
    WHERE CONVERT(DATE, createdAt) BETWEEN @startDate AND @endDate)

    RETURN @cost
END
