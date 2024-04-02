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
--EXEC InsertIngredientProc N'Nguyên liệu 5', N'Trung Nguyên';
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
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InsertInventoryProc')
DROP PROCEDURE InsertInventoryProc
GO
CREATE PROCEDURE InsertInventoryProc
    @name VARCHAR(255)
AS
BEGIN
    INSERT INTO Inventory (name)
    VALUES (@name);
END;

--GO
--EXEC InsertInventoryProc N'Phòng 3A03';
-- select * from Inventory
/* Procedure Update vào bảng Inventory */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateInventoryProc')
DROP PROCEDURE UpdateInventoryProc
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

--GO
--EXEC UpdateInventoryProc 'D48642D8-D205-4A1A-ACEE-A934E6A5829F', 'Phòng 2B01';

/* Procedure Delete vào bảng Inventory */

/* Procedure Insert vào bảng RestockBill */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InsertRestockBillProc')
DROP PROCEDURE InsertRestockBillProc
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

--GO
--EXEC InsertRestockBillProc '2/28/2024', @supplierName = 'Bách Hóa Xanh', @totalBill = '100000.00';

/* Procedure Update vào bảng RestockBill */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateRestockBillProc')
DROP PROCEDURE UpdateRestockBillProc
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

--GO
--EXEC UpdateRestockBillProc 'DCEE2B02-6AA9-4F1C-8342-A87DADF34217', '2024-03-14', 'COOP', '200000.00';

/* Procedure Insert vào bảng RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InsertRestockBillDetailsProc')
DROP PROCEDURE InsertRestockBillDetailsProc
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

EXEC InsertRestockBillDetailsProc '441E3AC0-4AB2-4BEF-AF15-95FE84C44EE0', 'DCEE2B02-6AA9-4F1C-8342-A87DADF34217', '2','25000.00'; 

/* Procedure Update vào bảng RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateRestockBillDetailsProc')
DROP PROCEDURE UpdateRestockBillDetailsProc
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

--EXEC UpdateRestockBillDetailsProc '441E3AC0-4AB2-4BEF-AF15-95FE84C44EE0', 'DCEE2B02-6AA9-4F1C-8342-A87DADF34217', '4','30000.00'; 

/* Procedure Delete vào bảng RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DeleteRestockBillDetailsProc')
DROP PROCEDURE DeleteRestockBillDetailsProc
GO
CREATE PROCEDURE DeleteRestockBillDetailsProc
    @ingredientId UNIQUEIDENTIFIER,
    @restockBillId UNIQUEIDENTIFIER
AS
BEGIN
    DELETE FROM RestockBillDetails
    WHERE ingredientId = @ingredientId
    AND restockBillId = @restockBillId;
END;

--EXEC DeleteRestockBillDetailsProc '441E3AC0-4AB2-4BEF-AF15-95FE84C44EE0', 'DCEE2B02-6AA9-4F1C-8342-A87DADF34217'; 



