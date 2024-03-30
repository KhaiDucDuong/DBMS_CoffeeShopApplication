use CoffeeShop

GO
INSERT INTO Employee (fullName, phoneNumber, address, email, isWorking, joinedAt, updatedAt)
VALUES
	(N'Huy Ngố', '0933344455', N'2 Võ Văn Ngân, TP.HCM', 'huy@gmail.com', 1, CONVERT(DATE, '11/02/2024', 103), GETDATE()),
	(N'Tiến Gié', '0987654321', N'1 Võ Văn Ngân, TP.HCM', 'tien@gmail.com', 1, CONVERT(DATE, GETDATE(), 103), GETDATE()),
	(N'Minh Ngố', '0988877766', N'3 Võ Văn Ngân, TP.HCM', 'minh@gmail.com', 0, CONVERT(DATE, '30/11/2023', 103), GETDATE()),
	(N'Khẻ Dương', '0933355577', N'4 Võ Văn Ngân, TP.HCM', 'khai@gmail.com', 0, CONVERT(DATE, '12/09/2023', 103), GETDATE()),
	(N'Nhi Nhỉ', '0911144400', N'5 Võ Văn Ngân, TP.HCM', 'nhi@gmail.com', 1, CONVERT(DATE, '23/03/2023', 103), GETDATE());

GO
INSERT INTO Customer (customerName, phoneNumber, createdAt, updatedAt)
VALUES 
    (N'Trúc Nga', '123456789', GETDATE(), GETDATE()),
    (N'Thanh Tuấn', '987654321', GETDATE(), GETDATE()),
	(N'Ngọc Mai', '089876656', GETDATE(), GETDATE()),
    (N'Cao Kha', '09083636', GETDATE(), GETDATE()),
	(N'Trúc Nga', '098878767', GETDATE(), GETDATE()),
    (N'Điệp Khúc', '096126322', GETDATE(), GETDATE()),
    (N'Hiệp', '555123456', GETDATE(), GETDATE());

GO
INSERT INTO Product (productName, productSize, productPrice, createdAt, updatedAt)
VALUES 
    (N'Cà phê đen', N'Nhỏ', 20.000, GETDATE(), GETDATE()),
    (N'Cà phê đen', N'Vừa', 25.000, GETDATE(), GETDATE()),
    (N'Cà phê sữa', N'Nhỏ', 25.000, GETDATE(), GETDATE()),
    (N'Cà phê sữa', N'Vừa', 30.000, GETDATE(), GETDATE()),
    (N'Bạc Sĩu', N'Nhỏ', 25.000, GETDATE(), GETDATE()),
    (N'Bạc Sĩu', N'Vừa', 30.000, GETDATE(), GETDATE()),
	(N'Sinh tố Bơ', N'Vừa', 35.000, GETDATE(), GETDATE()),
    (N'Sinh tố Bơ', N'Lớn', 40.000, GETDATE(), GETDATE()),
	(N'Sinh tố Dâu', N'Vừa', 35.000, GETDATE(), GETDATE()),
    (N'Sinh tố Dâu', N'Lớn', 40.000, GETDATE(), GETDATE());

-- Chạy từng câu và sửa employeeeId và customerId lại
GO
INSERT INTO OrderBill (rewardPointsUsed, createdAt, employeeId, customerId)
VALUES (10.000 , GETDATE(), '66D54193-59AC-4BB6-94DB-C8A67CCB9556', '0A975999-A77B-40C6-8A2C-4B3C4461FB9C'),
		(0, GETDATE(), '66D54193-59AC-4BB6-94DB-C8A67CCB9556', '0A975999-A77B-40C6-8A2C-4B3C4461FB9C'),
		(0, GETDATE(), '66D54193-59AC-4BB6-94DB-C8A67CCB9556', '0A975999-A77B-40C6-8A2C-4B3C4461FB9C');
GO
INSERT INTO OrderBillDetails (billId, productId, quantity)
VALUES ('D1CD38B9-475F-4727-A0BB-85950CBE990D', '9B7C677F-D5E9-482B-B945-19DA9FB96671', 2)
		('D1CD38B9-475F-4727-A0BB-85950CBE990D', '23A8B850-3DD1-464E-94E9-99BF9198986C', 2);

GO
INSERT INTO OrderBillDetails (billId, productId, quantity)
VALUES ('5A90332C-3CB8-490D-B31F-7F85029F45D8', 'CE11C252-6467-455E-91AE-53799CBB1000', 2),
		('5A90332C-3CB8-490D-B31F-7F85029F45D8', '54F6086D-4ACB-4C65-B7CA-D3C79F2FC675', 1),
		('5A90332C-3CB8-490D-B31F-7F85029F45D8', '8F363253-64DC-4D64-9727-6FB607B38DE5', 3),
		('5A90332C-3CB8-490D-B31F-7F85029F45D8', '23A8B850-3DD1-464E-94E9-99BF9198986C', 2);

GO
INSERT INTO OrderBillDetails (billid, productId, quantity)
VALUES ('87416E28-C3D8-4BC2-B3BF-4860D8B8B1DA', 'CE11C252-6467-455E-91AE-53799CBB1000', 3);

