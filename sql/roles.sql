create role manager;
create role employee;
go

Grant Select, Update, Insert on OrderBill to employee;
Grant Select, Update, Insert on OrderBillDetails to employee;
Grant Select, Update, Insert on RestockBill to employee;
Grant Select, Update, Insert on RestockBillDetails to employee;
Grant Select, Update, Insert on Customer to employee;
Grant Select on Inventory to employee;
Grant Select, Update, Insert on InventoryCheck to employee;
Grant Select, Update, Insert on InventoryCheckDetails to employee;
Grant Select on Product to employee;
Grant Select on Ingredient to employee;
go

Grant Exec, Select, Delete, Update, Insert, Delete on database::CoffeeShop to manager;
go