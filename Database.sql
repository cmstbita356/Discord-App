create database Discord
go
use Discord
go
create table Users 
(
	Id int identity(1,1) primary key,
	Username varchar(50),
	Password varchar(50)
);
create table Rooms
(
	Id int identity(1,1) primary key,
	MasterId int,
	Name nvarchar(50)
);
create table Channels
(
	Id int identity(1,1) primary key,
	RoomId int,
	Name nvarchar(50)
);

create table RoomMembership
(
	RoomId int,
	UserId int,
	primary key(RoomId, UserId)
);
create table PrivateMessages
(
	Id int identity(1,1) primary key,
	SenderId int,
	RecieverId int,
	Content nvarchar(255),
	Timestamp DateTime
);
create table GroupMessages
(
	Id int identity(1,1) primary key,
	SenderId int,
	ChannelId int,
	Content nvarchar(255),
	Timestamp datetime
);

drop database Discord