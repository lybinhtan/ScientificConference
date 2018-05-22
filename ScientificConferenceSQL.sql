CREATE DATABASE ScientificConference
USE ScientificConference
GO
CREATE TABLE Staff(
	id INT IDENTITY PRIMARY KEY,
	UserName VARCHAR(50),
	PassWord Varchar(50),
	Name VARCHAR(50) NOT NULL DEFAULT N'Chưa có tên',
	BirthDay DATETIME,
	Address VARCHAR(50),
	PhoneNumber VARCHAR(50),
	NationalId VARCHAR(50),
	DateIn  DATETIME,
	Email VARCHAR(50),
	Level int,
)
GO

insert into Staff(
	UserName, PassWord, Name, BirthDay, Address, PhoneNumber, NationalId, DateIn, Email, Level
)
values(
	N'namnh97',N'1',N'Nam', '11/15/1997',N'CampusB',N'92387432',N'347594', '2/4/2015', N'dakfj', N'1'
)


CREATE TABLE Instructor(
	id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	BirthDay DATETIME,
	Address VARCHAR(50),
	PhoneNumber VARCHAR(50),
	Email VARCHAR(50),
	Topic VARCHAR(50),
	Country VARCHAR(50),
	RegistrationDate DATETIME,
	Fee int,
	Checkk int,
	Point int,
)
GO

insert into Instructor(
	Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, Checkk, Point
)
values(
	N'Nam', '11/15/2037', N'dakf', N'4329578283', N'ds', N'djafads', N'djafd', '2/4/2017', 2000, 1, 4
)


CREATE TABLE Guest(
	id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	BirthDay VARCHAR(50),
	Address VARCHAR(50),
	PhoneNumber VARCHAR(50),
	Topic VARCHAR(50),
	Email VARCHAR(50),
	Checkk INT,
	Country VARCHAR(50),
)
GO



CREATE TABLE Audience(
	id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	BirthDay VARCHAR(50),
	Address VARCHAR(50),
	PhoneNumber VARCHAR(50),
	Topic VARCHAR(50),
	Email VARCHAR(50),
	Checkk INT,
	Country VARCHAR(50),
	Fee int,
)
GO

select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val

create table CheckJoin(
	val int,
	status varchar(50),
)
go

insert into CheckJoin values(1,N'Tham gia')

insert into CheckJoin values(0,N'Chưa biết')

insert into CheckJoin values(2,N'Không tham gia')


/*
CREATE TABLE ProgramDetail(
	Id INT IDENTITY PRIMARY KEY,
	Datee DATETIME,
	Topic VARCHAR(50), 
	Location VARCHAR(50),
	idITR INT,
	FOREIGN KEY (idITR) REFERENCES INSTRUCTOR(id)
)
GO

CREATE TABLE Room(
	id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(50),
	Place VARCHAR(50),
	Amount INT,
	Checkk INT
)
GO

CREATE TABLE Ticket(
	id INT IDENTITY PRIMARY KEY,
	Datee DATETIME,
	Location VARCHAR(50),
	Price INT,
	idPR INT,
	idRoom INT,
	FOREIGN KEY (idPR) REFERENCES ProgramDetail(id),
	FOREIGN KEY (idRoom) REFERENCES Room(id)
)
GO

CREATE TABLE Report(
	id INT IDENTITY PRIMARY KEY,
	Topic VARCHAR(50),
	idITR INT,
	Point INT,
	Checkk INT,
	FOREIGN KEY (idITR) REFERENCES INSTRUCTOR(id),
)
GO


