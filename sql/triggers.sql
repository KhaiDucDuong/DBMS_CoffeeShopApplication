use CoffeeShop
GO

--Trigger update giờ làm việc của nhân viên dựa trên vai trò
--CREATE TRIGGER upt_position 
--ON Employee
--AFTER INSERT, UPDATE
--AS
--BEGIN
--    SET NOCOUNT ON;

--    IF EXISTS (SELECT 1 FROM INSERTED)
--    BEGIN
--        -- Update existing records
--        UPDATE Employee
--        SET hourRate = 
--            CASE 
--                WHEN INSERTED.position = 'employee' THEN 25
--                WHEN INSERTED.position = 'manager' THEN 50
--            END
--        FROM Employee
--        INNER JOIN INSERTED ON Employee.PrimaryKey = INSERTED.PrimaryKey;

--        PRINT 'Updated records';
--    END
--    ELSE
--    BEGIN
--        -- Handle insert operations
--        INSERT INTO Employee (PrimaryKey, hourRate)
--        SELECT PrimaryKey, 
--               CASE 
--                   WHEN position = 'A' THEN 25
--                   WHEN position = 'B' THEN 50
--               END
--        FROM INSERTED;

--        PRINT 'Inserted records';
--    END
--END;
--GO

--Trigger Update ngày lễ dựa

--CREATE TRIGGER trg_UpdateHolidayWeekend
--ON RegisterSchedule
--AFTER INSERT, UPDATE
--AS
--BEGIN
--    SET NOCOUNT ON;

--    -- Update isHoliday and isWeekend based on the inserted or updated date
--    UPDATE RS
--    SET isHoliday = 
--        CASE 
--            WHEN DATENAME(dw, inserted.date) IN ('Saturday', 'Sunday') THEN 'true'
--            ELSE 'false'
--        END,
--        isWeekend = 
--        CASE 
--            WHEN DATENAME(dw, inserted.date) IN ('Saturday', 'Sunday') THEN 'true'
--            ELSE 'false'
--        END
--    FROM RegisterSchedule RS
--    INNER JOIN inserted ON RS.PrimaryKey = inserted.PrimaryKey;

--    PRINT 'Updated isHoliday and isWeekend columns';
--END;
--GO

/*Trigger 3 Cập nhật điểm của khách hàng khi xuất bill*/

IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_Customer_UpdateRewardPoint' AND [type] = 'TR')
	DROP TRIGGER [dbo].[tr_Customer_UpdateRewardPoint];
GO
CREATE TRIGGER tr_Customer_UpdateRewardPoint
ON OrderBill
AFTER INSERT
AS
BEGIN
    -- Update reward points for each customer based on the bill
    DECLARE @customerId UNIQUEIDENTIFIER, @totalSpent DECIMAL(10, 2), @rewardPoints DECIMAL(10, 2);

    -- Calculate total spent for each customer in the inserted orders
    SELECT @customerId = customerId, @totalSpent = SUM(initialBill - finalBill) FROM inserted GROUP BY customerId;

    -- Calculate reward points based on total spent
    SET @rewardPoints = @totalSpent * 0.1; -- Assuming 1 reward point for every $10 spent

    -- Update reward points for the customer
    UPDATE Customer
    SET rewardPoint = rewardPoint + @rewardPoints
    WHERE customerId = @customerId;
END;

GO
/*Trigger 4 Cập nhật điểm của khách khi họ sử dụng điểm để thanh toán */
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_Customer_UseRewardPoint' AND [type] = 'TR')
	DROP TRIGGER [dbo].[tr_Customer_UseRewardPoint];
GO
CREATE TRIGGER tr_Customer_UseRewardPoint
ON OrderBill
AFTER UPDATE
AS
BEGIN
    -- Update reward points for each customer when they use points for payment
    DECLARE @customerId UNIQUEIDENTIFIER, @usedPoints DECIMAL(10, 2);

    -- Calculate total used points for each customer in the updated orders
    SELECT @customerId = customerId, @usedPoints = SUM(rewardPointsUsed) FROM inserted GROUP BY customerId;

    -- Deduct used points from the customer's reward points
    UPDATE Customer
    SET rewardPoint = CASE
                            WHEN rewardPoint - @usedPoints >= 0 THEN rewardPoint - @usedPoints
                            ELSE 0
                      END
    WHERE customerId = @customerId;
END;
/*Trigger 5 Tự tạo tài khoản cho nhân viên khi thêm một nhân viên */
--DROP TRIGGER tr_Employee_AfterInsert
--GO
GO
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_Employee_AfterInsert' AND [type] = 'TR')
	DROP TRIGGER [dbo].[tr_Employee_AfterInsert];
GO
CREATE TRIGGER tr_Employee_AfterInsert
ON Employee
AFTER INSERT
AS
BEGIN
	--Create accounts for employees who ARE working, accounts are ENABLED
	INSERT INTO Account (employeeId, username, password, role, createdAt, updatedAt, isDeleted)
    SELECT employeeId, email, phoneNumber, 'Employee', CONVERT(DATETIME, GETDATE(), 103), CONVERT(DATETIME, GETDATE(), 103), 0
    FROM inserted
	WHERE isWorking = 1

	--Create accounts for employees who ARE NOT working, accounts are DISABLED
	INSERT INTO Account (employeeId, username, password, role, createdAt, updatedAt, isDeleted)
    SELECT employeeId, email, phoneNumber, 'Employee', CONVERT(DATETIME, GETDATE(), 103), CONVERT(DATETIME, GETDATE(), 103), 1
    FROM inserted
	WHERE isWorking = 0
END

GO
/*Trigger 6 Khóa/Mở tài khoản của nhân viên khi cập nhật trạng thái đang làm việc của nhân viên đấy */
--DROP TRIGGER tr_Employee_AfterUpdateIsWorking
--GO
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_Employee_AfterUpdateIsWorking' AND [type] = 'TR')
	DROP TRIGGER [dbo].[tr_Employee_AfterUpdateIsWorking];
GO
CREATE TRIGGER tr_Employee_AfterUpdateIsWorking
ON Employee
AFTER UPDATE
AS
BEGIN
    -- Check if isWorking is updated in any row
    IF UPDATE(isWorking)
    BEGIN
        DECLARE @employeeId UNIQUEIDENTIFIER;

        -- Get the employeeId and isWorking value for each updated row
        SELECT @employeeId = employeeId FROM inserted;

        DECLARE @isWorking BIT;
        SELECT @isWorking = isWorking FROM inserted;

        -- Update isDeleted for the corresponding account
        UPDATE Account
        SET isDeleted = CASE 
                            WHEN @isWorking = 1 THEN 0
                            ELSE 1
                        END
        WHERE employeeId = @employeeId;
    END;
END;

GO
/* Trigger 7 Cập nhật số tiền tổng của OrderBill khi thêm một sản phẩm trong OrderBillDetails */

IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_OrderBill_AfterInsert' AND [type] = 'TR')
	DROP TRIGGER [dbo].[tr_OrderBill_AfterInsert];
GO
CREATE TRIGGER tr_OrderBill_AfterInsert
ON OrderBillDetails
AFTER INSERT
AS
BEGIN
	--Get billId and calculate the new price we need to add to the OrderBill
	DECLARE @billId UNIQUEIDENTIFIER, @addedPrice DECIMAL(10, 2);
	SELECT @billId = billId, @addedPrice = SUM(quantity * productPrice) FROM inserted inner join Product on inserted.productId = Product.productId GROUP BY billId

	--Update the initialBill in the OrderBill
	UPDATE OrderBill
	SET initialBill = initialBill + @addedPrice
	WHERE billId = @billId

	--Update the finalBill in the OrderBill
	UPDATE OrderBill
	SET finalBill = initialBill - rewardPointsUsed
	WHERE billId = @billId
END;

/* Trigger 8 Cập nhật số tiền tổng của OrderBill khi sửa một sản phẩm trong OrderBillDetails */

/* Trigger 9 Cập nhật số tiền tổng của OrderBill khi xóa một sản phẩm trong OrderBillDetails */

/*Trigger cập nhật số điểm thưởng của khách hàng khi thêm một Order Bill - trường hợp trừ điểm thưởng vì đã sử dụng khấu phần hóa đơn*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi thêm một Order Bill - trường hợp cộng điểm thưởng cho hóa đơn*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi cập nhật finalBill của một Order Bill*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi xóa một Order Bill*/

/* Trigger Cập nhật số tiền tổng của RestockBill khi thêm một sản phẩm trong RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_RestockBill_AfterInsert' AND [type] = 'TR')
	DROP TRIGGER [dbo].tr_RestockBill_AfterInsert;
GO
CREATE TRIGGER tr_RestockBill_AfterInsert
ON RestockBillDetails
AFTER INSERT
AS
BEGIN
	--Get billId and calculate the new price we need to add to the OrderBill
	DECLARE @restockBillId UNIQUEIDENTIFIER, @addedPrice DECIMAL(10, 2);
	SELECT @restockBillId = restockBillId, @addedPrice = SUM(quantity * price) FROM inserted GROUP BY restockBillId

	--Update the totalBill in the RestockBill
	UPDATE RestockBill
	SET totalBill = totalBill + @addedPrice
	WHERE restockBillId = @restockBillId
END;
GO

/* Trigger Cập nhật số tiền tổng của RestockBill khi sửa một sản phẩm trong RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_RestockBill_AfterUpdate' AND [type] = 'TR')
	DROP TRIGGER [dbo].tr_RestockBill_AfterUpdate;
GO
CREATE TRIGGER tr_RestockBill_AfterUpdate
ON RestockBillDetails
AFTER UPDATE
AS
BEGIN
	--Get billId and calculate the new price we need to add to the OrderBill
	DECLARE @restockBillId UNIQUEIDENTIFIER, @oldAmount DECIMAL(10, 2), @newAmount DECIMAL(10, 2), @amountDifference DECIMAL(10, 2);
	SELECT @restockBillId = deleted.restockBillId, 
	@oldAmount = deleted.quantity * deleted.price,
    @newAmount = inserted.quantity * inserted.price 
	FROM deleted
    JOIN inserted ON deleted.ingredientId = inserted.ingredientId AND deleted.restockBillId = inserted.restockBillId;

	-- Calculate the difference in amount
    SET @amountDifference = @newAmount - @oldAmount;

	--Update the totalBill in the RestockBill
	UPDATE RestockBill
	SET totalBill = totalBill + @amountDifference
	WHERE restockBillId = @restockBillId
END;
GO

/* Trigger Cập nhật số tiền tổng của RestockBill khi xóa một sản phẩm trong RestockBillDetails */
GO
IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'tr_RestockBill_AfterDelete' AND [type] = 'TR')
	DROP TRIGGER [dbo].tr_RestockBill_AfterDelete;
GO
CREATE TRIGGER tr_RestockBill_AfterDelete
ON RestockBillDetails
AFTER DELETE
AS
BEGIN
	--Get billId and calculate the new price we need to add to the OrderBill
	DECLARE @restockBillId UNIQUEIDENTIFIER, @subtractedAmount DECIMAL(10, 2);
	SELECT @restockBillId = restockBillId, @subtractedAmount = SUM(quantity * price) FROM deleted GROUP BY restockBillId

	--Update the totalBill in the RestockBill
	UPDATE RestockBill
	SET totalBill = totalBill - @subtractedAmount
	WHERE restockBillId = @restockBillId
END;
GO
