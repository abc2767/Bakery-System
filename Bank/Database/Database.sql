create database "Bakery-System"
use "Bakery-System"

create table User (
    MemberId varchar(25) PRIMARY KEY,
    Password varchar(20) Not Null,
    Name varchar(25) Not Null,
    Age Int Not Null,
    TotalBalance int Not Null default 0,
    
)

create table Bread(
    Name varchar(25) Not Null,
    Price int(7) Not Null,
    LeftNum int(7) Not Null default 0,
)

create table Cart(
    UserId varchar(25) references User (MemberId),
    BreadName varchar(25) references Bread (Name),
    count int(7) Not Null,
)

select * from User
select * from Bread