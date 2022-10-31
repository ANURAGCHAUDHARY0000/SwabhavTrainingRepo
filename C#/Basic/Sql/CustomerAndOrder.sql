CREATE TABLE Customer
(
CustomerID int PRIMARY KEY NOT NULL,
FullName varchar(255),
Address varchar(255),
City varchar(255)
);


CREATE TABLE CustomerOrder
(
OrderID int PRIMARY KEY NOT NULL,
OrderName varchar(255),
Price int,
CustomerId int FOREIGN KEY REFERENCES Customer(CustomerId),
);

INSERT INTO Customer VALUES('01','ANURAG','UP','GHAZIPUR')
INSERT INTO Customer VALUES('02','ANU','UP','VARANSHI')
INSERT INTO Customer VALUES('03','RAM','UP','VARANSHI')
INSERT INTO Customer VALUES('04','Mohan','UP','VARANSHI')

SELECT * FROM Customer

INSERT INTO CustomerOrder VALUES('11','Cookies','120',1)
INSERT INTO CustomerOrder VALUES('12','Chocolate','500',2)
INSERT INTO CustomerOrder VALUES('13','Maggi','150',1)
INSERT INTO CustomerOrder VALUES('14','Biscuit','180',4)

SELECT * FROM CustomerOrder

SELECT CustomerOrder.OrderID, CustomerOrder.OrderName, CustomerOrder.Price, Customer.FullName
FROM CustomerOrder, Customer
WHERE Customer.FullName = 'ANURAG' and Customer.CustomerID = CustomerOrder.CustomerId;


SELECT Customer.FullName,CustomerOrder.OrderID, CustomerOrder.OrderName, CustomerOrder.Price
FROM  Customer , CustomerOrder
WHERE Customer.CustomerID = CustomerOrder.CustomerId;