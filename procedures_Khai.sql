USE CoffeeShop
/* Procedure insert vào bảng Ingredient*/
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InsertIngredientProc')
DROP PROCEDURE InsertIngredientProc
GO
CREATE PROCEDURE InsertIngredientProc
    @ingredientName NVARCHAR(100),
    @manufacturerName NVARCHAR(50)
AS
BEGIN
    INSERT INTO Ingredient (ingredientName, manufacturerName, updatedAt)
    VALUES (@ingredientName, @manufacturerName, GETDATE());
END;

--GO
--EXEC InsertIngredientProc N'Cà phê Legend gói 1kg', N'Trung Nguyên';
--Go
--select * from Ingredient

/* Procedure update vào bảng Ingredient*/
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateIngredientProc')
DROP PROCEDURE UpdateIngredientProc
GO
CREATE PROCEDURE UpdateIngredientProc
    @ingredientId UNIQUEIDENTIFIER,
    @ingredientName NVARCHAR(100),
    @manufacturerName NVARCHAR(50),
	@isDeleted BIT
AS
BEGIN
    UPDATE Ingredient
    SET ingredientName = @ingredientName,
        manufacturerName = @manufacturerName,
        updatedAt = GETDATE(),
		isDeleted = @isDeleted
    WHERE ingredientId = @ingredientId;
END;

--GO
EXEC UpdateIngredientProc '5EE8A239-92ED-499F-9E69-9113FBA03A8A',N'Bột năng', N'Trung Nguyên', 0;
--Go
select * from Ingredient

/* Procedure delete vào bảng Ingredient */

/* Procedure Insert vào bảng Inventory */
GO
CREATE PROCEDURE InsertInventoryProc
    @name VARCHAR(255)
AS
BEGIN
    INSERT INTO Inventory (name)
    VALUES (@name);
END;

/* Procedure Update vào bảng Inventory */
GO
CREATE PROCEDURE UpdateInventoryProc
    @inventoryId UNIQUEIDENTIFIER,
    @name VARCHAR(255)
AS
BEGIN
    UPDATE Inventory
    SET name = @name
    WHERE inventoryId = @inventoryId;
END;

/* Procedure Delete vào bảng Inventory */

/* Procedure Insert vào bảng RestockBill */
GO
CREATE PROCEDURE InsertRestockBillProc
    @date DATE,
    @supplierName NVARCHAR(50),
    @totalBill DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO RestockBill (date, supplierName, totalBill)
    VALUES (@date, @supplierName, @totalBill);
END;

/* Procedure Update vào bảng RestockBill */
GO
CREATE PROCEDURE UpdateRestockBillProc
    @restockBillId UNIQUEIDENTIFIER,
    @date DATE,
    @supplierName NVARCHAR(50),
    @totalBill DECIMAL(10, 2)
AS
BEGIN
    UPDATE RestockBill
    SET date = @date,
        supplierName = @supplierName,
        totalBill = @totalBill
    WHERE restockBillId = @restockBillId;
END;

/* Procedure Insert vào bảng RestockBillDetails */
GO
CREATE PROCEDURE InsertRestockBillDetailsProc
    @ingredientId UNIQUEIDENTIFIER,
    @restockBillId UNIQUEIDENTIFIER,
    @quantity INT,
    @price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO RestockBillDetails (ingredientId, restockBillId, quantity, price)
    VALUES (@ingredientId, @restockBillId, @quantity, @price);
END;

/* Procedure Update vào bảng RestockBillDetails */
GO
CREATE PROCEDURE UpdateRestockBillDetailsProc
    @ingredientId UNIQUEIDENTIFIER,
    @restockBillId UNIQUEIDENTIFIER,
    @quantity INT,
    @price DECIMAL(10, 2)
AS
BEGIN
    UPDATE RestockBillDetails
    SET quantity = @quantity,
        price = @price
    WHERE ingredientId = @ingredientId
    AND restockBillId = @restockBillId;
END;

/* Procedure Delete vào bảng RestockBillDetails */



