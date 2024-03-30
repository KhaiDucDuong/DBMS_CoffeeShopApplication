use CoffeeShop
GO
/*Trigger 5*/
DROP TRIGGER tr_Employee_AfterInsert
GO
CREATE TRIGGER tr_Employee_AfterInsert
ON Employee
AFTER INSERT
AS
BEGIN
	INSERT INTO Account (employeeId, username, password, role, createdAt, updatedAt, isDeleted)
    SELECT employeeId, email, phoneNumber, 'Employee', CONVERT(DATETIME, GETDATE(), 103), CONVERT(DATETIME, GETDATE(), 103), 0
    FROM inserted
	WHERE isWorking = 1

	INSERT INTO Account (employeeId, username, password, role, createdAt, updatedAt, isDeleted)
    SELECT employeeId, email, phoneNumber, 'Employee', CONVERT(DATETIME, GETDATE(), 103), CONVERT(DATETIME, GETDATE(), 103), 1
    FROM inserted
	WHERE isWorking = 0
END

GO
/*Trigger 6*/
DROP TRIGGER tr_Employee_AfterUpdateIsWorking
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