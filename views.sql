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

--select * from GetOrderBillDetailsView where createdAt between CAST(CONVERT(VARCHAR,GETDATE(),102) AS DATETIME) and CAST(CONVERT(VARCHAR,GETDATE() + 1,102) AS DATETIME)

/* Câu 5 - Xem các bill bán hàng trong ngày hôm nay */
GO
if exists(select 1 from sys.views where name='GetTodayOrderBillsView' and type='v')
drop view GetTodayOrderBillsView;
GO
CREATE VIEW GetTodayOrderBillsView AS
SELECT *
FROM OrderBill
WHERE FORMAT(createdAt, 'dd-MM-yyyy') BETWEEN FORMAT(GETDATE(), 'dd-MM-yyyy') AND FORMAT(GETDATE() + 1, 'dd-MM-yyyy');