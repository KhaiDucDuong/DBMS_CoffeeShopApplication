-- Create CoffeeShopManagement database
use master;
GO
IF DB_ID('CoffeeShop') IS NOT NULL
DROP DATABASE CoffeeShop;

GO
CREATE DATABASE CoffeeShop;
GO
USE CoffeeShop;

-- Create tables with uniqueidentifier (UUID) primary keys
GO
CREATE TABLE Employee (
    employeeId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    fullName NVARCHAR(100),
    phoneNumber VARCHAR(15),
    address NVARCHAR(255),
    email VARCHAR(255) UNIQUE,
    isWorking BIT,
    joinedAt DATE,
    updatedAt DATETIME,
    isDeleted BIT DEFAULT 0,
);

GO
CREATE TABLE Product (
    productId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    productName NVARCHAR(100),
    productSize NVARCHAR(50),
    productPrice DECIMAL(10, 2),
    createdAt DATETIME,
    updatedAt DATETIME,
    isDeleted BIT DEFAULT 0
);

GO
CREATE TABLE Customer (
    customerId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    customerName NVARCHAR(100),
    phoneNumber VARCHAR(15),
    rewardPoint DECIMAL(10, 2) DEFAULT 0,
    createdAt DATETIME,
    updatedAt DATETIME,
    isDeleted BIT DEFAULT 0
);

GO
CREATE TABLE Ingredient (
    ingredientId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    ingredientName NVARCHAR(100),
    manufacturerName NVARCHAR(50),
    updatedAt DATETIME,
    isDeleted BIT DEFAULT 0
);

GO
CREATE TABLE Inventory (
    inventoryId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    name VARCHAR(255)
);

GO
CREATE TABLE Account (
    accountId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	employeeId UNIQUEIDENTIFIER REFERENCES Employee(employeeId),
    username VARCHAR(255) UNIQUE,
    password VARCHAR(255),
    role VARCHAR(20),
    createdAt DATETIME,
    updatedAt DATETIME,
    isDeleted BIT DEFAULT 0
);



GO
CREATE TABLE OrderBill (
    billId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	rewardPointsUsed DECIMAL(10, 2),
    totalBill DECIMAL(10, 2),
    createdAt DATETIME,
    isDeleted BIT,
    employeeId UNIQUEIDENTIFIER REFERENCES Employee(employeeId),
    customerId UNIQUEIDENTIFIER REFERENCES Customer(customerId)
);

GO
CREATE TABLE RestockBill (
    restockBillId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    date DATE,
	supplierName NVARCHAR(50),
    totalBill DECIMAL(10, 2)
);

GO
CREATE TABLE OrderBillDetails (
    billId UNIQUEIDENTIFIER REFERENCES OrderBill(billId),
    productId UNIQUEIDENTIFIER REFERENCES Product(productId),
    quantity INT,
    PRIMARY KEY (billId, productId)
);

GO
CREATE TABLE InventoryCheck (
	checkId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    employeeId UNIQUEIDENTIFIER REFERENCES Employee(employeeId),
    inventoryId UNIQUEIDENTIFIER REFERENCES Inventory(inventoryId),
    checkDate DATE,
);

GO
CREATE TABLE InventoryCheckDetails (
	checkId UNIQUEIDENTIFIER REFERENCES InventoryCheck(checkId),
	ingredientId UNIQUEIDENTIFIER REFERENCES Ingredient(ingredientId),
    quantity INT,
    PRIMARY KEY (checkId, ingredientId)
);

GO
CREATE TABLE RestockBillDetails (
    ingredientId UNIQUEIDENTIFIER REFERENCES Ingredient(ingredientId),
	restockBillId UNIQUEIDENTIFIER REFERENCES RestockBill(restockBillId),
	PRIMARY KEY (ingredientId, restockBillId),
    quantity INT,
    price DECIMAL(10, 2),
);