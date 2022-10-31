CREATE table Departments
(
  ID int primary key identity,
  Name nvarchar(50),
  Location nvarchar (50)
)

CREATE table tblEmployees
(
  ID int primary key identity,
  FirstName nvarchar(50),
  LastName nvarchar(50),
  Gender nvarchar(50),
  Salary int,
  DepartmentId int foreign key references Departments(Id)
)

Insert into Departments values('IT','New York')
Insert into Departments values('HR', 'London')
Insert into Departments values('Payroll', 'Sydney')

Insert into tblEmployees values ('Mark', 'Hastings', 'Male',60000, 1)
Insert into tblEmployees values ('Steve', 'pound', 'Male',45000, 3)
Insert into tblEmployees values ('Ben', 'Hoskins', 'Male',70000, 1)
Insert into tblEmployees values ('Philip', 'Hastings', 'Male',30000, 2)
Insert into tblEmployees values ('Mary', 'Lambeth', 'Female',70000, 2)

SELECT * from tblEmployees
SELECT * from Departments 