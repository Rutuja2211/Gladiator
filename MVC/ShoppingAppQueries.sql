create table Users
(
Id int identity(1,1) primary key,
UName varchar(100),
Email varchar(100),
Phone varchar(100),
UAddress varchar(1000),
UPassword varchar(100)
)

create table Products
(
PId int identity(101,1) primary key,
PName varchar(100),
Price float,
Quantity int,
Img varchar(1000)
)

create table Orders
(
OId int identity(1000,1000) primary key,
UserId int foreign key references Users(Id),
TotalPrice float
)

create table OrderDetails
(
OrderId int foreign key references Orders(OId),
ProductId int foreign key references Products(PId),
Quantity int,
UnitPrice float,
primary key(OrderId,ProductId)
)


create table Cart
(
UserId int foreign key references Users(Id),
ProductId int foreign key references Products(PId),
Quantity int,
primary key(UserId,ProductId)
)



create proc proc_signup(@name varchar(100),@email varchar(100),@phone varchar(100),@addr varchar(1000),@password varchar(100))
as
begin
	insert into Users (UName,Email,Phone,UAddress,UPassword) values(@name,@email,@phone,@addr,@password);
end


select * from users

create proc proc_verify_details(@username varchar(100),@password varchar(100))
as
select * from Users where Email=@username and UPassword=@password

create proc proc_insert_products(@name varchar(100),@price float,@quantity int,@img varchar(1000))
as
begin
	insert into Products (PName,Price,Quantity,Img) values(@name,@price,@quantity,@img);
end

exec proc_insert_products Chair,499.99,10,'../Resources/chair.jpg'
exec proc_insert_products RoundTable,699.99,10,'../Resources/table.jpg'
exec proc_insert_products Fridge,20000,5,'../Resources/fridge.jpg'
exec proc_insert_products Fan,1000,15,'../Resources/fan.jpg'
exec proc_insert_products SofaSet,50000,5,'../Resources/sofaset.jpg'
exec proc_insert_products Bed,30000,5,'../Resources/bed.jpg'
exec proc_insert_products Lamp,1200,10,'../Resources/lamp.jpg'
exec proc_insert_products TV,50000,3,'../Resources/tv.jpg'

select * from Products

create proc insert_into_cart(@userid int,@productid int,@quantity int)
as
insert into Cart values(@userid,@productid,@quantity)

create proc delete_from_cart(@userid int,@productid int)
as
delete from cart where UserId=@userid and ProductId=@productid

create proc on_cart_checkout(@userid int)
as
declare @tbl table
set @tbl = select c.ProductId,p.Price as Price,c.Quantity as Quantity, (c.Quantity*p.Price) as ProductTotal from Cart c, Products p where c.UserId=@userid and c.ProductId=p.PId 


insert into Orders(UserId,TotalPrice) select (UserId) from ()



create proc insert_into_orders()
as

insert into Orders(UserId,TotalPrice) values()

select c.ProductId,p.Price as Price,c.Quantity as Quantity, (c.Quantity*p.Price) as ProductTotal from Cart c, Products p where c.UserId=1 and c.ProductId=p.PId

select sum(ProductTotal)as Total from (select c.ProductId,p.Price as Price,c.Quantity as Quantity, (c.Quantity*p.Price) as ProductTotal from Cart c, Products p where c.UserId=1 and c.ProductId=p.PId) as tbl