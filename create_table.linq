<Query Kind="SQL" />

CREATE TABLE Listen
(
	id     int not null primary key IDENTITY(1,1),
	utime  bigint not null,
	ltime  datetime not null,
	artist nvarchar(200),
	album  nvarchar(200),
	song   nvarchar(200),
	armbid nvarchar(36),
	almbid nvarchar(36),
	sombid nvarchar(36)
)