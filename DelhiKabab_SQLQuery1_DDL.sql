USE MASTER 
GO
DROP DATABASE if exists DelhiKabab
GO

CREATE DATABASE DelhiKabab
GO

USE DelhiKabab
GO

--DDL

CREATE TABLE AdminUser (
UserID int IDENTITY,
UserName Varchar (20) NOT NULL DEFAULT 'user',
UserPassword Varchar (20) NOT NULL DEFAULT 'password',
FirstName Varchar (30) NOT NULL,
LastName Varchar (30) NOT NULL,
DateOfBirth Date,
Email Varchar(30) NOT NULL,
TelephoneNumber Varchar (15),
constraint PK_User PRIMARY KEY (UserID)
);


CREATE TABLE Item (
ItemNumber int IDENTITY,
ItemName Varchar(30) NOT NULL,
StorageName Varchar (30),
Category Varchar (30) NOT NULL,
Brand Varchar (30),
StoreName Varchar (30),
Quantity int NOT NULL,
ExpirationDate Date,
Price Money,
Constraint PK_Item Primary Key (ItemNumber)
);


CREATE TABLE OrderList(
OrderNumber int,
ItemNumber int,
CurrentDate Date,
Quantity int,
Constraint FK_OrderList Foreign Key (ItemNumber) References Item(ItemNumber),
Constraint PK_AdminOrder Primary Key (OrderNumber,ItemNumber)
);


CREATE TABLE LowItemStockLevel(
ItemNumber int,
Quantity int NOT NULL,
Status Varchar (15)
Constraint FK_LowStock Foreign Key (ItemNumber) References Item (ItemNumber),
Constraint PK_LowStock Primary Key (ItemNumber)
);


CREATE TABLE Supplier(
SupplierNumber int IDENTITY,
SupplierName Varchar (30) NOT NULL,
CivicNumber Varchar(20) NOT NULL,
Street Varchar(30) NOT NULL,
City Varchar(30) NOT Null,
Province Varchar(30) NOT NULL DEFAULT 'Quebec',
PostalCode Varchar(7),
ContactPerson Varchar(30) NOT NULL,
TelephonNumber Varchar(15),
Constraint PK_Supplier PRIMARY KEY (SupplierNumber)
);


--DML

INSERT INTO AdminUser VALUES ('Mrana', 'maR6595', 'Masud', 'Rana', '01-Oct-1968', 'myemailactivity@gmail.com', '5149314650'),
							 ('sohalK', 'KhS6472', 'Shohal', 'Kabir', '02-May-1972', 'jeasan0007@gmail.com', '5149996595'),
							 ('ahNf', 'Ahnf1981', 'Ahnaf', 'Khan', '10-Nov-1980', 'ahnaf@gmail.com', '5149393934'),
							 ('frHn', 'Far4610', 'Farhan', 'jony', '21-Feb-1971','jony@yahoo.com', '4509968970'),
							 ('adI', 'Adi7767', 'Adiyat', 'Arfan', '23-Apr-1979', 'arfanA@hotmail.com', '4508715653');

SELECT * FROM AdminUser;


INSERT INTO Item VALUES ('Potato', 'Stock_Room', 'Vegetables', 'Farmer''s Market', 'Costco', 7, DATEADD(DAY, 14,GETDATE()), 2.99),
						('Onion', 'Stock_Room', 'Vegetables', 'Country Fresh','Costco', 6, DATEADD(DAY, 21, GETDATE()), 3.99),
						('Flour', 'Stock_Room', 'General', 'Five Roses', 'Aubut', 2, NULL, 8.99),
						('Apple', 'Freezer', 'Fruits', NULL, 'Costco', 3, DATEADD(DAY,30,GETDATE()), 1.29),
						('Chicken', 'Cooler', 'Meat', NULL, 'Supplier', 3, DATEADD(DAY,180,GETDATE()),389.50 ),
						('Beef', 'Cooler', 'Meat', NULL, 'Supplier', 2, DATEADD(DAY,180,GETDATE()),275),
						('Lamb', 'Cooler', 'Meat', NULL, 'Supplier', 1, DATEADD(DAY,180,GETDATE()), 149.99);

SELECT * FROM Item;


INSERT INTO OrderList VALUES (1, 1, '25-Oct-2022', 4),
							 (1, 2, NULL, 7),
							 (1, 3, NULL, 2),
							 (1, 4, NULL, 3),
							 (2, 1, '07-Nov-2022', 4),
							 (2, 2, NULL, 4),
							 (2, 3, NULL, 2),
							 (2, 4, Null, 4);

SELECT * FROM OrderList;



INSERT INTO Supplier VALUES ('GFS','550', 'Louis-Pasteur', 'Boucherville', 'QC', 'J4B 7Z1', 'Michal Houd', '4506554400'),
							('T-Mart Food Services', '9335', 'Ave. Du Parc', 'Montreal', 'QC', 'H2N 1Z1', 'Hamid', '5148148111'),
							('Can-Am Food Services', '200', 'Deslauriers', 'Saint-Laurent', 'QC', 'H4N 1V8', 'Stephen', '5144881148'),
							('Costco', '9430', 'Taschereau Blvd', 'Brossard', 'QC', 'J4X 2W2', '', '4504444466'),
							('Aubut', '3975', 'St-Ambroise', 'Montreal', 'QC', 'H4C 2E1', '', '5149330939');

SELECT * FROM Supplier;

SELECT * FROM Item;
SELECT * FROM Item WHERE Quantity <=5 AND Category = 'fruits'; 
						