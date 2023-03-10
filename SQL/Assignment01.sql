1st Assignment:

create table Customer(
Id int Primary key,
FirstName nvarchar(40),
LastName nvarchar(40),
City nvarchar(40),
Country nvarchar(40),
Phone nvarchar(20)
);
select * from Customer

create table Orders(
Id int Primary key,
OrderDate datetime,
OrderNumber nvarchar(10),
CustomerId int Foreign key references Customer(Id),
TotalAmount decimal(12,2)
);
select * from Orders

create table Product(
Id int Primary key,
ProductName nvarchar(50),
UnitPrice decimal(12,2),
Package nvarchar(30),
IsDiscontinued bit
);
select * from Product

create table OrderItem(
Id int Primary key,
OrderId int Foreign key references Orders(Id),
ProductId int Foreign key references Product(Id),
UnitPrice decimal(12,2),
Quantity int
);



insert into Customer values(1, 'Amruta', 'Kulkarni', 'Dhule', 'India', '8877991122' );
insert into Customer values(2, 'Bhakti', 'Takane', 'Amalner', 'India', '6677991133' );
insert into Customer values(3, 'Srishti', 'Patil', 'Dallas', 'America', '8877990092' );
insert into Customer values(4, 'Raksha', 'Gujrathi', 'seoul', 'Korea', '8876591122' );
insert into Customer values(5, 'Shiny', 'Majumdar', 'Sydney', 'Australia', '030-0074321' );
insert into Customer values(6, 'Shirley', 'William', 'London', 'UK', '7722991123');
insert into Customer values(7, 'Ruchika', 'Mali', 'Paris', 'France', '7214991429', '');

alter table Customer add FaxNumber nvarchar(10);
update Customer set Country = 'Germany', City='Berlin' where Id = 4;
update Customer set FaxNumber = '4210' where Id = 1;
update Customer set FaxNumber = '3219' where Id = 4;

5. Select * from Customer

6. Select Country from Customer where Country like 'A%' OR Country like 'I%' order by Country

7. select FirstName from Customer where FirstName like '__i%'


insert into Orders values(100, '2020/10/23 10:21:43:121', 5, 1, 749.00 )
insert into Orders values(101, '2021/10/28 05:34:55:222', 2, 5, 599.00 )
insert into Orders values(102, '2022/05/02 02:52:11:452', 4, 2, 379.00 )
insert into Orders values(103, '2023/01/05 22:13:44:233', 6, 1, 800.00 )
insert into Orders values(104, '2020/12/09 12:33:56:123', 3, 3, 237.00 )
select * from Orders

delete from Orders where TotalAmount = 699.00;
alter table Orders add ShipName nvarchar(40);
alter table Orders add ShipCompany nvarchar(40);

update Orders set OrderDate = '2020/10/23 10:21:43:121' where Id = '100';
update Orders set OrderDate = '2021/10/28 05:34:55:222' where Id = '101';
update Orders set OrderDate = '2022/05/02 02:52:11:452' where Id = '102';
update Orders set OrderDate = '2023/01/05 22:13:44:233' where Id = '103';
update Orders set OrderDate = '2020/12/09 12:33:56:123' where Id = '104';
update Orders set ShipName = 'La corne d abondance' where Id = '104';
update Orders set ShipCompany = 'France' where Id = '104';


insert into Product values(200, 'Chips', 50.00, 'Lays', 0);
insert into Product values(201, 'Chai', 30.00, 'Taj', 1);
insert into Product values(203, 'Coffee', 40.00, 'Bru', 0);
insert into Product values(202, 'Biscuits', 60.00, 'Burborn', 0);
insert into Product values(204, 'Popcorn', 20.00, 'Caramel', 1);
insert into Product values(205, 'Mojito', 130.00, 'Exotic Liquid', 1, 'Refreshing Drink');

select * from Product

insert into OrderItem values(10, 100, 200, 649.00, 3);
insert into OrderItem values(12, 103, 201, 449.00, 5);
insert into OrderItem values(13, 102, 202, 549.00, 3);
insert into OrderItem values(14, 101, 203, 749.00, 2);
insert into OrderItem values(15, 104, 204, 349.00, 6);
insert into OrderItem values(16, 103, 205, 50.00, 6);
delete from OrderItem where ProductId = 205;

update OrderItem set UnitPrice = 15 where OrderId = 103
update OrderItem set UnitPrice = 12 where OrderId = 101
select * from OrderItem;

Assignment 03:

1. select * from Orders where CustomerId = (select Id from Customer where Phone = '030-0074321');

alter table Product add Category nvarchar(40);
update Product set Category = 'Refreshing Drink' where Id = '201';
update Product set Category = 'Snacks' where Id = '200';
update Product set Category = 'Snacks' where Id = '202';
update Product set Category = 'Seafood', ProductName = 'Fish' where Id = '204';
update Product set Category = 'Refreshing Drink' where Id = '203';
update Product set Package = 'Lays' where Id = '200';

2. select * from Product where Category = 'Seafood';
3. Select * from Orders inner join Customer on Orders.CustomerId = Customer.id where Customer.City!='London';
4. select * from OrderItem where ProductId = (Select Id from Product where ProductName ='Chai');

Create table Employee(
FirstName nvarchar(40),
LastName nvarchar(40),
Department nvarchar(40),
Manager nvarchar(40),
Rating int,
Salary int);

alter table Employee add JoiningDate datetime;
insert into Employee values('Amruta', 'Kulkarni','CSE', 'Rashmi', 5, 25000);
insert into Employee values('Apurva', 'Gondkar','Civil', 'Rashmi', 6, 2300);
insert into Employee values('Rutuja', 'Thombre','Civil', 'Rashmi', 5, 26000);
insert into Employee values('Nikita', 'Punde','Entc', 'Rashmi', 5, 35000);
insert into Employee values('Gauri', 'Devahdrao','Civil', 'Rashmi', 6, 22000);
update Employee set JoiningDate = '2022-12-08' where FirstName = 'Amruta';
update Employee set JoiningDate = '2022-12-05' where FirstName = 'Apurva';
update Employee set JoiningDate = '2022-12-31' where FirstName = 'Rutuja';
update Employee set JoiningDate = '2022-12-21' where FirstName = 'Nikita';
update Employee set JoiningDate = '2022-12-10' where FirstName = 'Gauri';

5. select * from Employee;

select * from Product
select * from OrderItem
select * from Orders

2nd Assignment:

1. select * from Customer where Country = 'Germany';
2. select concat(FirstName,' ',LastName) AS FullName from Employee;
3. select * from Customer where FaxNumber Is Not Null;
4. select * from Customer where FirstName like '_u%'
5. select * from OrderItem where UnitPrice Between 10 AND 20
6. select * from Orders order by OrderDate
7. select * from Orders where ShipName = 'La corne d abondance' AND OrderDate between '2020-09-29' AND '2021-01-01' 
8. select * from Product where Package = 'Exotic Liquid'
9. select Product.Id, Product.ProductName, avg(Quantity) from OrderItem inner join Product on OrderItem.ProductID = Product.Id group by Product.Id , Product.ProductName
10. select ShipName, ShipCompany from Orders
11. select * from Employee where Manager is Not Null

4th Assignment:


2. select * from Employee order by JoiningDate
3. select * from Employee order by JoiningDate desc
5. select * from Product where IsDiscontinued = 0
10. select Id from Customer where FirstName like '%RA%'