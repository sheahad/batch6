CREATE DATABASE CoffeeShop
--DROP DATABASE CoffeeShop
USE CoffeeShop

CREATE TABLE Items(
ID INT IDENTITY(1,1)  PRIMARY KEY,
Name VARCHAR(50),
Price FLOAT
)

--DROP TABLE Items

INSERT INTO Items (ID, Name, Price) Values (1,'Black', 120)
INSERT INTO Items (ID, Name, Price) Values (2,'Black', 120)
INSERT INTO Items ( Name, Price, ID) Values ('Cold', 100, 3)

--INSERT INTO Item Values ('Hot', 120, 4)
INSERT INTO Items Values (4,'Hot', 120)

--INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Regular', 80)
INSERT INTO Items (Name, Price) Values ('Cold', 100)
INSERT INTO Items (Name, Price) Values ('Hot', 90)


SELECT * FROM Items

DELETE FROM Items WHERE ID = 3

UPDATE Items
SET 
Name =  'Reguler' ,
Price = 80
WHERE ID = 2

UPDATE Items
SET 
Name =  'Cuppuchino' ,
Price = 200
WHERE ID = 3

SELECT Name, Price FROM Items
WHERE Price >=100

SELECT Name, Price FROM Items
ORDER BY Name, Price DESC


CREATE TABLE Customers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
[Address] VARCHAR(200),
Contact VARCHAR(50),
)

--DROP TABLE Customers
INSERT INTO Customers VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers VALUES ('Rafi', 'BNorisal' ,'01811369369')

SELECT * FROM Items
SELECT * FROM Customers

CREATE TABLE Orders
(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerId INT REFERENCES Customers (Id),
ItemId INT REFERENCES Items (Id),
Quantity INT,
TotalPrice FLOAT,
)

--DROP TABLE Orders
INSERT INTO Orders VALUES (1, 1 , 5, 600)
INSERT INTO Orders VALUES (1, 2 , 3, 240)
INSERT INTO Orders VALUES (1, 3 , 2, 200)

INSERT INTO Orders VALUES (2, 2 , 2, 160)
INSERT INTO Orders VALUES (2, 3 , 3, 300)
INSERT INTO Orders VALUES (2, 4 , 4, 400)

INSERT INTO Orders VALUES (4, 3 , 2, 200)
INSERT INTO Orders VALUES (3, 4 , 2, 200)

DELETE FROM Customers WHERE ID =3
SELECT * FROM Items
SELECT * FROM Customers
SELECT * FROM Orders

SELECT o.Id, CustomerId, c.Name AS Customer, ItemId, i.Name AS Item, Quantity, TotalPrice FROM Orders As o
LEFT JOIN Customers as c ON c.Id = o.CustomerId 
LEFT JOIN Items as i ON i.ID = o.ItemId

DELETE FROM Orders WHERE ID =9
