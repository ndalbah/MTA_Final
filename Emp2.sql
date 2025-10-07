CREATE DATABASE emp2;

USE emp2;

CREATE TABLE Employees (
    Id INT NOT NULL,
    Name VARCHAR(70) NOT NULL,
    Age INT NOT NULL,
    Address VARCHAR(90),
    Salary DECIMAL(10, 2),
    CONSTRAINT PK_Employees PRIMARY KEY (Id)
);

INSERT INTO Employees (Id, Name, Age, Address, Salary) VALUES
(1, 'Paul', 32, 'California', 22000),
(2, 'Allen', 25, 'Texas', 15000.00),
(3, 'Teddy', 23, 'Norway', 20000.00),
(4, 'Mark', 25, 'Richmond', 65000);

SELECT * FROM Employees;