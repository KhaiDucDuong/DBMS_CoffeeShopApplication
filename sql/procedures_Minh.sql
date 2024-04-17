--PROCEDURES
--@UpdateType là dùng để định chức năng của Procedures
CREATE PROCEDURE AddEmployeeProc
    @FullName NVARCHAR(100),
    @PhoneNumber VARCHAR(15),
    @Address NVARCHAR(255),
    @Email VARCHAR(255),
    @IsWorking BIT
AS
BEGIN
    INSERT INTO Employee (fullName, phoneNumber, address, email, isWorking, joinedAt, updatedAt)
		VALUES (@FullName, @PhoneNumber, @Address, @Email, @IsWorking, GETDATE(), GETDATE());
END;
GO

CREATE PROCEDURE UpdateEmployeeProc
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
	IF @UpdateType = 'update'
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

CREATE PROCEDURE AddAccountProc
	@EmployeeId UNIQUEIDENTIFIER,
	@Passwords VarChar(255),
	@UserName VarChar(255),
	@Role VarChar(20)
AS
BEGIN
	INSERT INTO Account(accountId, username, password, updatedAt, createdAt, role, isDeleted) 
		VALUES (@AccountId, @UserName, @Passwords, GETDATE(), GETDATE(), @Role, 0);
END;
GO
	
CREATE PROCEDURE UpdateAccountProc
	@AccountId UNIQUEIDENTIFIER,
	@EmployeeId UNIQUEIDENTIFIER,
	@Passwords VarChar(255),
	@UserName VarChar(255),
	@Role VarChar(20),
	@UpdateType VarChar(20)
AS
BEGIN
	IF @UpdateType = 'update'
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

CREATE PROCEDURE AddOrderBillProc
	@CustomerId UNIQUEIDENTIFIER,
     	@EmployeeId UNIQUEIDENTIFIER,
	 @RewardPointsUsed DECIMAL(10, 2),
    	@InitialBill DECIMAL(10, 2),
	@FinalBill DECIMAL(10,2)
AS
BEGIN
	INSERT INTO OrderBill (billId, customerId, employeeId, rewardPointsUsed, intialBill, finalBill, createdAt, isDeleted)
		VALUES (@BillId, @CustomerId, @EmployeeId, @RewardPointsUsed, @InitialBill, @FinalBill, GETDATE(), 0);
END;
GO

CREATE PROCEDURE UpdateOrderBillProc
    @CustomerId UNIQUEIDENTIFIER,
    @EmployeeId UNIQUEIDENTIFIER,
    @BillId UNIQUEIDENTIFIER,
    @RewardPointsUsed DECIMAL(10, 2),
    @TotalBill DECIMAL(10, 2),
    @UpdateType VARCHAR(20)
AS
BEGIN
	IF @UpdateType = 'update'
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
		WHERE billId = @BillId;
	END;
END;
GO

CREATE PROCEDURE AddOrderBillDetailsProc
    @ProductId UNIQUEIDENTIFIER,
    @Quantity INT
AS
BEGIN
	INSERT INTO OrderBillDetails (productId, quantity)
	VALUES (@ProductId, @Quantity);
END;
GO

CREATE PROCEDURE UpdateOrderBillDetialsProc
	@BillId UNIQUEIDENTIFIER,
	@ProductId UNIQUEIDENTIFIER,
	@Quantity INT
AS
BEGIN
	UPDATE OrderBillDetails
	SET productId = @ProductId,
	quantity = @quantity
	WHERE billId = @BillId
END;
GO
