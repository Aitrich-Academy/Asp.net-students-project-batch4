** CATEGORY***
create table Category(
CatID int primary key identity(1,1),
CatName varchar(50),
Status varchar(50),
CatDate datetime default getdate()
)
***ITEMS***

create   table Items(
ItmID int Primary key Identity(1,1),
CatID int foreign key references Category(CAtID),
ItmName varchar(50) Not Null,
ItmPrice decimal Not null,
ItmImage nvarchar(50),
ItmDiscription nvarchar(256) Not Null,
CookingTime time,
Status varchar(10) Not null,
ItmDate datetime default getdate()
)


***Login***
create table Login (
LoginId int primary key identity(1,1),
UserName varchar(30) Not null,
Password varchar(30) Not NUll ,
UID int foreign key references Users(UID),
Status varchar(10) Not null,
LogDate)

***USER***

CREATE TABLE Users (

UID int primary key identity(1,1),
UName varchar(50) Not Null,
UAddress varchar(256) Not NULL,
UPhone varchar(50) Not NUll,
UPinCode varchar(50) Not NUll,
UEmail varchar(50) Not NUll,
UserName varchar(50) Not Null,
Password varchar(60),
UDate datetime default getdate()
)

***BOOKING****

create table Booking(
BookID int primary key identity(1,1),
ItmID int foreign key references Items(ItmID),
CatID int foreign key references Category(CatID),
UID int foreign key references Users(UID),
Qty int Not null ,
Total decimal Not null,
Status varchar(50) not null,
Bdate datetime default getdate()
)
*******OrderedItems*********

create table OrderedItems (
 OID int primary key identity(1,1),
 UID int foreign key references Users(UID),
 BookID int foreign key references Booking(BookID)
 ODate datetime default getdate()
 )





