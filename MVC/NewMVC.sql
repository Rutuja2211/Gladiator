create database dbDiscShop
use dbDiscShop

create table movies
(id int identity(1,1) primary key,
name varchar(100) not null,
duration float)

create table disc
(id int identity(101,1) primary key,
movie_id int constraint fk_mid foreign key references movies(id),
rental_cost float)

alter proc proc_insert_movie(@name varchar(100),@dur float)
as
   insert into movies(name,duration) values(@name,@dur)

exec proc_insert_movie 'MI3',121.1
exec proc_insert_movie 'Rio',99.3
exec proc_insert_movie 'How to train your dragon 1',111.1

alter proc proc_insert_disc(@mid int,@cost float)
as
   insert into disc(movie_id,rental_cost) values(@mid,@cost)

exec proc_insert_disc 1,100
exec proc_insert_disc 1,100
exec proc_insert_disc 2,150

select * from movies
select * from disc

alter table movies add pic varchar(1000)

update movies set pic = '../resources/1.jpg'



create table Employee
(
Id int identity(101,1) primary key,
Name varchar(50),
Salary int,
Pic varchar(1000),
Age int
)

insert into Employee(Name,Salary,Pic,Age) values('Rutuja', 50000,'../resources/1.jpg',21);
