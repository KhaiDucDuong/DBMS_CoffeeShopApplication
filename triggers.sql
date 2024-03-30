use CoffeeShop
GO
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
/* Trigger 7 Cập nhật số tiền tổng của OrderBill khi thêm/sửa/xóa một sản phẩm trong OrderBillDetails */
--DROP TRIGGER tr_OrderBill_AfterInsert
--GO
CREATE TRIGGER tr_OrderBill_AfterInsert
ON OrderBillDetails
AFTER INSERT
AS
BEGIN
	--Get data to calculate the new initial bill and final bill
	DECLARE @billId UNIQUEIDENTIFIER, @productId UNIQUEIDENTIFIER, @productPrice DECIMAL(10, 2), @productQuantity INT;
	SELECT @billId = billId, @productId = productId, @productQuantity = quantity FROM inserted
	SELECT @productPrice = productPrice FROM Product WHERE productId = @productId

	UPDATE OrderBill
	SET initialBill = initialBill + (@productPrice * @productQuantity),
		finalBill = initialBill - rewardPointsUsed
	WHERE billId = @billId
END;

/*Trigger cập nhật số điểm thưởng của khách hàng khi thêm một Order Bill - trường hợp trừ điểm thưởng vì đã sử dụng khấu phần hóa đơn*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi thêm một Order Bill - trường hợp cộng điểm thưởng cho hóa đơn*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi cập nhật finalBill của một Order Bill*/

/*Trigger cập nhật số điểm thưởng của khách hàng khi xóa một Order Bill*/