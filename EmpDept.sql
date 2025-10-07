CREATE DATABASE EmpDept;

USE EmpDept;

CREATE TABLE Departments (
    DeptId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Departments PRIMARY KEY (DeptId)
);

CREATE TABLE Employees (
    EmpId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    DeptId INT NOT NULL,
    CONSTRAINT PK_Employees PRIMARY KEY (EmpId),
    CONSTRAINT FK_Employees_Departments FOREIGN KEY (DeptId)
        REFERENCES Departments (DeptId)
        ON UPDATE CASCADE
        ON DELETE NO ACTION
);

INSERT INTO Departments (DeptId, Name) VALUES
(1, 'Marketing'),
(2, 'Accounting'),
(3, 'Finance'),
(4, 'IT');


INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES
(1, 'Mary', 90000.00, 3),
(3, 'John', 90000.00, 1),
(7, 'Brian', 80000.00, 2),
(14, 'Anne', 95000.00, 4),
(32, 'James', 85000.00, 1);

SELECT * FROM Departments;
SELECT * FROM Employees;