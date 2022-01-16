create table Product 
(
	id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Price money not null default 0
)

create table Customer 
(
	id int primary key identity(1,1),
	Name nvarchar(50)  not null,
	Address nvarchar(100) null
)

create table CustomerOrder 
(
	id int primary key identity(1,1),
	CustomerId int not null
)

create table OrderDetails 
(
	id int primary key identity(1,1),
	OrderId int not null,
	ProductId int not null,
	Quantity int not null
)



select sales.id, p1.name, sales.total from 
(select p.id,   sum(od.quantity*p.price) as total from OrderDetails od 
join Product P
on od.ProductId = p.Id
group by p.id) sales
join product p1
on sales.id=p1.id


create view vw_OrderView
as

select c.id as Id,Max(c.Name) as Name ,Sum(od.quantity*p.price) as TotalSales from orderdetails od 
join product p
on od.productid=p.id
join customerorder co
on od.orderid=co.id
join customer c
on co.customerid=c.id

group by c.id


select * from vw_OrderView





alter table orderdetails
add foreign key (ProductId) References Product(id) 

alter table orderdetails
add foreign key (OrderId) References CustomerOrder(id) 

alter table CustomerOrder
add foreign key (CustomerId) References Customer(id) 

--on delete cascade

select * from orderdetails 
select * from product 

delete from product where id=2

