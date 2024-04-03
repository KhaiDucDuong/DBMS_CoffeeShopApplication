--PROCEDURES
--@UpdateType là dùng để định chức năng của Procedures
CREATE PROCEDURE UpdateEmployee
    @EmployeeId UNIQUEIDENTIFIER,
    @FullName NVARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @Address NVARCHAR(255),
    @Email VARCHAR(255),
    @Role VARCHAR(20),
    @IsWorking BIT,
    @UpdateType VarChar(20)
AS
BEGIN
    SET NOCOUNT ON;
	IF @UpdateType = 'add'
	BEGIN
		INSERT INTO Employee (fullName, phoneNumber, address, email, isWorking, joinedAt, updatedAt)
		VALUES (@FullName, @PhoneNumber, @Address, @Email, @IsWorking, GETDATE(), GETDATE());

		-- Lấy ID của Employee mới thêm
		SET @EmployeeId = SCOPE_IDENTITY();

		INSERT INTO Account (employeeId, username, password, role, createdAt, updatedAt)
		VALUES (@EmployeeId, @Email, 'defaultpassword', @Role, GETDATE(), GETDATE());
	END;
    -- Cập nhật trạng thái IsWorking của Employee
	ELSE IF @UpdateType = 'update'
		BEGIN
			UPDATE Employee
			SET isWorking = @IsWorking,
				updatedAt = GETDATE()
			WHERE employeeId = @EmployeeId;
		-- Nếu IsWorking là False, đánh dấu Account tương ứng là đã xóa
		IF @IsWorking = 0
		BEGIN
			UPDATE Account
			SET isDeleted = 1,
				updatedAt = GETDATE()
			WHERE employeeId = @EmployeeId;
		END;
	END;
END;
GO

CREATE PROCEDURE UpdateAccount
	@AccountId UNIQUEIDENTIFIER,
	@EmployeeId UNIQUEIDENTIFIER,
	@Passwords VarChar(255),
	@UserName VarChar(255),
	@Role VarChar(20),
	@UpdateType VarChar(20)
As
Begin
	IF @UpdateType = 'add'
	BEGIN
		INSERT INTO Account(accountId, username, password, updatedAt, createdAt, role, isDeleted) 
		VALUES (@AccountId, @UserName, @Passwords, GETDATE(), GETDATE(), @Role, 0);
	END;
	ELSE IF @UpdateType = 'update'
	BEGIN
		UPDATE Account
		SET password = @Passwords,
			updatedAt = GETDATE()
		WHERE accountId = @AccountId;
	END;
	ELSE
	BEGIN
		UPDATE Account
		SET isDeleted = 1
		WHERE accountId = @AccountId;
	END;
END;
GO

CREATE PROCEDURE UpdateOrderBill
    @CustomerId UNIQUEIDENTIFIER,
    @EmployeeId UNIQUEIDENTIFIER,
    @BillId UNIQUEIDENTIFIER,
    @RewardPointsUsed DECIMAL(10, 2),
    @TotalBill DECIMAL(10, 2),
    @UpdateType VARCHAR(20)
AS
BEGIN
	IF @UpdateType = 'add'
	BEGIN
		INSERT INTO OrderBill (billId, customerId, employeeId, rewardPointsUsed, totalBill, createdAt, isDeleted)
		VALUES (@BillId, @CustomerId, @EmployeeId, @RewardPointsUsed, @TotalBill, GETDATE(), 0);
	END;
	ELSE IF @UpdateType = 'update'
	BEGIN
	UPDATE OrderBill
	SET customerId = @CustomerId, 
		employeeId = @EmployeeId, 
		rewardPointsUsed = @RewardPointsUsed, 
		totalBill = @TotalBill
	Where billId = @BillId;
	END;
	ELSE
	BEGIN
		UPDATE OrderBill
		set isDeleted = 1
		WHERE billId =@BillId;
	END;
END;
GO

CREATE PROCEDURE AddOrderBillDetails
    @BillId UNIQUEIDENTIFIER,
    @ProductId UNIQUEIDENTIFIER,
    @Quantity INT,
    @UpdateType VarChar(20)
AS
BEGIN
    SET NOCOUNT ON;

	IF @UpdateType = 'add'
	BEGIN
		INSERT INTO OrderBillDetails (billId, productId, quantity)
		VALUES (@BillId, @ProductId, @Quantity);
	END;
	ELSE IF @UpdateType = 'update'
	BEGIN
		UPDATE OrderBillDetails
		SET quantity = @Quantity
		WHERE billId = @BillId AND productId = @ProductId;
	END;
END;
GO
