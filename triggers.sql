use CoffeeShop
GO
/*Trigger 3 Cập nhật điểm của khách hàng khi xuất bill*/
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

/*Trigger 4 Cập nhật điểm của khách khi họ sử dụng điểm để thanh toán */
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
--DROP TRIGGER tr_OrderBill_AfterInsert
--GO
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