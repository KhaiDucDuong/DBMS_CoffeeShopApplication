use CoffeeShop
GO

create role manager;
create role employee;
go
Grant Select, Update, Insert on OrderBill to employee;
Grant Select, Update, Insert on OrderBillDetails to employee;
Grant Select, Update, Insert on RestockBill to employee;
Grant Select, Update, Insert on RestockBillDetails to employee;
Grant Select, Update, Insert on Customer to employee;
Grant Select on Inventory to employee;
Grant Select on Employee to employee;
Grant Select, Update, Insert on InventoryCheck to employee;
Grant Select, Update, Insert on InventoryCheckDetails to employee;
Grant Select on Product to employee;
Grant Select on Ingredient to employee;

Grant EXEC on AddOrderBillDetailsProc to employee;
Grant EXEC on AddOrderBillProc to employee;
Grant EXEC on InsertCustomerProc to employee;
Grant EXEC on InsertInventoryCheckProc to employee;
Grant EXEC on InsertInventoryCheckDetailsProc to employee;
Grant EXEC on InsertRestockBillProc to employee;
Grant EXEC on InsertRestockBillDetailsProc to employee;

Grant EXEC on UpdateCustomerProc to employee;
Grant EXEC on UpdateInventoryCheckDetailsProc to employee;
Grant EXEC on UpdateInventoryCheckProc to employee;
Grant EXEC on UpdateRestockBillDetailsProc to employee;
Grant EXEC on UpdateRestockBillProc to employee;

Grant EXEC on DeleteRestockBillDetailsProc to employee;
Grant EXEC on DeleteInventoryCheckDetailsProc to employee;

go

Grant Exec, Select, Delete, Update, Insert, Delete on database::CoffeeShop to manager WITH GRANT OPTION;
go
