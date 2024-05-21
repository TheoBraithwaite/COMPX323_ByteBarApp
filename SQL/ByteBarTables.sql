--Drop Tables
--Drop table Product;
--Drop table Beer;
--Drop table Orders;
--Drop table RequestOrders;

--Creating Tables
CREATE TABLE Product (
    Name VARCHAR(100),
    Quantity VARCHAR(20),
    Cost NUMERIC(10, 2),
    Reorder_level INT,
    Sale_price NUMERIC(10, 2),
    Weight NUMERIC(10, 2),
    PRIMARY KEY (Name, Quantity)
);

CREATE TABLE Beer (
    Name VARCHAR(100),
    Quantity VARCHAR(20),
    Style VARCHAR(50),
    Vessel VARCHAR(50),
    Alc_percent NUMERIC(5, 2),
    PRIMARY KEY (Name, Quantity),
    FOREIGN KEY (Name, Quantity) REFERENCES Product(Name, Quantity)
);


CREATE TABLE Orders (
    OrderNumber INT,
    Date_Placed DATE,
    Total_Cost NUMERIC(10, 2),
    PRIMARY KEY (OrderNumber)
);

CREATE TABLE OrderRequests (
    Name VARCHAR(100),
    Quantity VARCHAR(20),
    OrderNumber INT,
    PRIMARY KEY (Name, Quantity, OrderNumber),
    FOREIGN KEY (Name, Quantity) REFERENCES Product(Name, Quantity),
    FOREIGN KEY (OrderNumber) REFERENCES Orders(OrderNumber)
);

-- Inserting data into Product table (including beer)
INSERT INTO Product VALUES ('Apple Juice', '500ml', 1.50, 100, 2.00, 0.1);
INSERT INTO Product VALUES ('Orange Juice', '500ml', 2.00, 80, 3.00, 0.15);
INSERT INTO Product VALUES ('Soda', '330ml', 1.50, 90, 2.00, 0.2);
INSERT INTO Product VALUES ('IPA', '330ml', 2.50, 80, 4.00, 0.3);
INSERT INTO Product VALUES ('Stout', '500ml', 3.00, 70, 5.00, 0.4);
INSERT INTO Product VALUES ('Lager', '330ml', 2.00, 90, 3.50, 0.3);
INSERT INTO Product VALUES ('Pilsner', '330ml', 2.20, 85, 3.80, 0.3);
INSERT INTO Product VALUES ('Wheat Beer', '500ml', 2.80, 75, 4.50, 0.4);


-- Inserting data into Orders table
INSERT INTO Orders VALUES (1, TO_DATE('2023-12-01', 'YYYY-MM-DD'), 15.50);
INSERT INTO Orders VALUES (2, TO_DATE('2024-03-13', 'YYYY-MM-DD'), 8.00);
INSERT INTO Orders VALUES (3, TO_DATE('2024-03-15', 'YYYY-MM-DD'), 18.00);
INSERT INTO Orders VALUES (4, TO_DATE('2024-04-02', 'YYYY-MM-DD'), 16.00);
INSERT INTO Orders VALUES (6, TO_DATE('2024-04-02', 'YYYY-MM-DD'), 80.00);

-- Inserting data into RequestOrders table
INSERT INTO OrderRequests VALUES ('Apple Juice', '500ml', 1);
INSERT INTO OrderRequests VALUES ('Soda', '330ml', 3);
INSERT INTO OrderRequests VALUES ('IPA', '330ml', 2);
INSERT INTO OrderRequests VALUES ('Stout', '500ml', 6);
INSERT INTO OrderRequests VALUES ('Orange Juice', '500ml', 4);

-- Inserting data into Beer table
INSERT INTO Beer VALUES ('IPA', '330ml', 'Pale Ale', 'Bottle', 6.5);
INSERT INTO Beer VALUES ('Stout', '500ml', 'Stout', 'Can', 7.0);
INSERT INTO Beer VALUES ('Lager', '330ml', 'Lager', 'Bottle', 5.0);
INSERT INTO Beer VALUES ('Pilsner', '330ml', 'Pilsner', 'Can', 4.8);
INSERT INTO Beer VALUES ('Wheat Beer', '500ml', 'Wheat', 'Bottle', 5.2);



-- Select Statements
Select *
From Orders
Where DATE_PLACED = '02/04/2024';

Select *
From OrderRequests 
Where OrderNumber > 3;

Select *
From Beer
Where Vessel = 'Can';

Select * 
From Product
Where Cost BETWEEN 1.50 AND 2.80;