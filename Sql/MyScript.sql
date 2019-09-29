CREATE DATABASE CoffeeShop
USE CoffeeShop

CREATE TABLE Items(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
Price FLOAT
)

DROP TABLE Item

INSERT INTO Items (ID, Name, Price) Values (1,'Black', 120)
INSERT INTO Items (ID, Name, Price) Values (2,'Black', 120)
INSERT INTO Items ( Name, Price, ID) Values ('Cold', 100, 3)

--INSERT INTO Item Values ('Hot', 120, 4)
INSERT INTO Items Values (4,'Hot', 120)


INSERT INTO Items (Name, Price) Values ('Black', 120)
INSERT INTO Items (Name, Price) Values ('Black', 120)
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




