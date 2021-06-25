CREATE TABLE Directors
(
	Id int PRIMARY KEY IDENTITY(1,1),
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) not null,
	Nationality varchar(255),
	Birth int
)