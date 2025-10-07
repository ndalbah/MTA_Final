# Multi-Tier Applications - Final
## Instructions
Using Visual Studio 2017, 2019 or 2022, create a solution name
**FinalExam** and, for each question, create a solution named **QuestionN**, where N is the
number of the question.
## Question 1
Create a list of integers named baselist with the following numbers:<br>
```12, 35, 105, 250, 12, 77, 35, 70, 9, 10```

1. Using **LINQ method syntax**, get the total of all the numbers in the baselist.<br>
2. Using **LINQ method syntax**, obtain the average of all the numbers in the baselist.<br>
3. Using **LINQ method syntax**, produce a list of items from the baselist that are greater
than 30, ordered in ascending order.<br>
4. Using **LINQ query syntax**, produce a list of items from the baselist that are greater than
30, ordered in ascending order.<br>
5. Using **LINQ method syntax**, obtain the list of numbers, without repetition, that are in the
baselist.<br>

> [!IMPORTANT]
> The result of each item above must be written to the console.

## Question 2
Write the code to create an implicitly typed functional variable having as value a function defined
by an anonymous "delegate" (Func <>) to return the index of the largest element of an array of
integers. ("delegates" and Lambda expression).<br><br>
Use the arrays ```[12, 35, 10, 250, 12, -77, 35, 7, 9, 10]``` and ```[12, -5, 250, 17, 12, -5, 250, 35, 10]```
to test you code.

## Question 3
1. Create an **Emp2.sql** script for SQL Server to create an emp2 database containing the table described below:

"Employees" with columns: 
  - ```"Id" INT NOT NULL```
  - ```"Name" VARCHAR (70) NOT NULL```
  - ```"Age" INT NOT NULL```
  - ```"Address" VARCHAR(90)```
  - ```"Salary" DECIMAL(10.2)```

The primary key of the "Employees" table is "Id".<br><br>
**Your Emp2.sql script must also insert the following data (at a minimum):**
- ```(1, 'Paul', 32, 'California', 22000)```
- ```(2, 'Allen', 25, 'Texas', 15000.00)```
- ```(3, 'Teddy', 23, 'Norway', 20000.00)```
- ```(4, 'Mark', 25, 'Richmond', 65000)```

Run your script to create this database and its table.

2. Using **SQLClient** and **SQLDataReader** (in **connected** mode), write a small C# ADO.NET program to read this table and print the data to the console.
3. Using **SQLClient** and **SQLAdapter** (in **disconnected** mode), write a small C# ADO.NET program to read this table and print the data to the console.
4. Using **Entity Framework**, write a small C# ADO.NET program to read this table and print the data to the console, sorted in ascending order of salary.


## Question 4
1. Create a EmpDept.sql script for SQL Server to create an EmpDept database containing two tables described below:
- "Departments" table with columns:
  - ```"DeptId" INT NOT NULL```
  - ```"Name" VARCHAR (50) NOT NULL```
- "Employees" table with columns:
    - ```"EmpId" INT NOT NULL```
    - ```"Name" VARCHAR (50) NOT NULL```
    - ```"Salary" DECIMAL (10,2) NOT NULL```
    - ```"DeptId" INT NOT NULL```

The primary key of the "Departments" table is "DeptId" and the primary key of the "Employees" table is "EmpId".
<br><br>In addition, the attribute "DeptId" in the "Employees" table is a foreign key that references the attribute "DeptId" of the "Departments" table. 
<br><br>This foreign key must not allow us to delete a department if there are employees assigned to that department. However, updates in Department table (DeptId) must be propagated to the Employees table. 
<br><br>
**Your EmpDept.sql script must also insert the following data (at a minimum):**
- ```Department (1, 'Marketing')```
- ```Department (2, 'Accounting')```
- ```Department (3, 'Finance')```
- ```Department (4, 'IT')```
- ```Employees (1, 'Mary', 90000.00, 3)```
- ```Employees (3, 'John', 90000.00, 1)```
- ```Employees (7, 'Brian', 80000.00, 2)```
- ```Employees (14, 'Anne', 95000.00, 4)```
- ```Employees (32, 'James', 85000.00, 1)```

Run your script to create this database and its tables.

2. Using Entity Framework and LINQ “to Entities”, write a C# application with Windows Forms (.NET Framework), 3 tiers (3 layers) with two options at the main menu of the window for:
    - Show a DataGridView linked to the "Departments" table, which allows you to view table data, add new rows, modify rows and delete them (deleting multiple rows), directly from the DataGridview.
    - Show a DataGridView linked to the "Employees" table, which allows you to see the data in the table, add new orders, modify rows and delete them (deleting several rows), directly from the DataGridview.
    - Your application must also implement the following business rule: Salaries must be greater or equal 15000.00
  
> [!NOTE]
> To correctly handle the deletion of multiple lines in the case of restriction by the foreign key, you must use "try-catch".
