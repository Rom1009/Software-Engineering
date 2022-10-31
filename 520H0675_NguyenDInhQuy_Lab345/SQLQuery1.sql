create database Lab345

create table Location (
	locationID varchar(3),
	destination varchar(20),
	Price int,
	startDateTime datetime,
	endDateTime datetime,
	availability int,
	constraint PK_locationID_locationName primary key(locationID),
)
