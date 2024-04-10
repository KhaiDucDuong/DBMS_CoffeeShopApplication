USE CoffeeShop

/* Câu 1 - Xem tất cả các OrderBill bao gồm OrderBillDetails */
GO
if exists(select 1 from sys.views where name='GetOrderBillDetailsView' and type='v')
drop view GetOrderBillDetailsView;
GO
CREATE VIEW GetOrderBillDetailsView AS
SELECT ob.billId, ob.rewardPointsUsed, ob.initialBill , ob.finalBill, ob.createdAt, ob.employeeId, ob.customerId, STRING_AGG(CONCAT(p.productName,' (',p.productSize, ') *', obd.quantity, ': ', p.productPrice, ' Total: ',  CAST((obd.quantity * p.productPrice) as nvarchar(1000))  ), '; ' ) as Products
FROM OrderBill ob 
join OrderBillDetails obd on ob.billId = obd.billId
join Product p on obd.productId = p.productId
GROUP BY ob.billId, ob.rewardPointsUsed, ob.initialBill, ob.finalBill, ob.createdAt, ob.employeeId, ob.customerId

-- câu 2 restockbill 
GO
if exists(select 1 from sys.views where name='GetRestockBillView' and type='v')
drop view GetRestockBillView;
GO
CREATE VIEW GetRestockBillView AS
SELECT rb.restockBillId, rb.date, i.ingredientName,rbd.quantity, rbd.price
FROM RestockBill rb
JOIN RestockBillDetails rbd on rb.restockBillId = rbd.restockBillId
JOIN Ingredient i ON rbd.ingredientId = i.ingredientId

--GO
--select * from GetRestockBillView ORDER BY restockBillId
--select * from GetOrderBillDetailsView where createdAt between CAST(CONVERT(VARCHAR,GETDATE(),102) AS DATETIME) and CAST(CONVERT(VARCHAR,GETDATE() + 1,102) AS DATETIME)
/*Câu 3 - Xem thông tin nhân viên đang làm việc (có thể xem dựa trên role của nhân viên)*/
GO
IF exists(SELECT 1 FROM sys.views WHERE name='GetWorkingEmployeesView' AND type='v')
DROP VIEW GetWorkingEmployeesView;
GO
CREATE VIEW GetWorkingEmployeesView AS
SELECT * FROM Employee WHERE isWorking = 1;
/*Câu 4 - Xem chi tiết số lượng hàng trong một đợt kiểm tra kho*/
GO
IF EXISTS(SELECT 1 FROM sys.views WHERE name='GetInventoryCheckDetailsView' AND type='v')
DROP VIEW GetInventoryCheckDetailsView;
GO
CREATE VIEW GetInventoryCheckDetailsView AS
SELECT icd.checkId, icd.ingredientId, i.ingredientName, icd.quantity
FROM InventoryCheckDetails icd
JOIN Ingredient i ON icd.ingredientId = i.ingredientId;
/* Câu 5 - Xem các bill bán hàng trong ngày hôm nay */
GO
if exists(select 1 from sys.views where name='GetTodayOrderBillsView' and type='v')
drop view GetTodayOrderBillsView;
GO
CREATE VIEW GetTodayOrderBillsView AS
SELECT *
FROM OrderBill
WHERE FORMAT(createdAt, 'dd-MM-yyyy') BETWEEN FORMAT(GETDATE(), 'dd-MM-yyyy') AND FORMAT(GETDATE() + 1, 'dd-MM-yyyy');
