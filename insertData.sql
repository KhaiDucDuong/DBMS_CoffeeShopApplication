use CoffeeShop

GO
INSERT INTO Employee (fullName, phoneNumber, address, email, isWorking, joinedAt, updatedAt)
VALUES
	(N'Huy Ngố', '0933344455', N'2 Võ Văn Ngân, TP.HCM', 'huy@gmail.com', 1, CONVERT(DATE, '11/02/2024', 103), CONVERT(DATETIME, GETDATE(), 103)),
	(N'Tiến Gié', '0987654321', N'1 Võ Văn Ngân, TP.HCM', 'tien@gmail.com', 1, CONVERT(DATE, GETDATE(), 103), CONVERT(DATETIME, GETDATE(), 103)),
	(N'Minh Ngố', '0988877766', N'3 Võ Văn Ngân, TP.HCM', 'minh@gmail.com', 0, CONVERT(DATE, '30/11/2023', 103), CONVERT(DATETIME, GETDATE(), 103)),
	(N'Khẻ Dương', '0933355577', N'4 Võ Văn Ngân, TP.HCM', 'khai@gmail.com', 0, CONVERT(DATE, '12/09/2023', 103), CONVERT(DATETIME, GETDATE(), 103)),
	(N'Nhi Nhỉ', '0911144400', N'5 Võ Văn Ngân, TP.HCM', 'nhi@gmail.com', 1, CONVERT(DATE, '23/03/2023', 103), CONVERT(DATETIME, GETDATE(), 103));

GO
UPDATE Employee
SET isWorking = 1
WHERE employeeId = '92C976BA-50F3-4C8D-B91E-288C385B37A6';


