create table construction(
iid int identity(1,1) primary key,
name varchar(350) not null,
category varchar(350) not null, 
price bigint not null
);

create table employee(
eid int identity(1,1) primary key,
ename varchar(250) not null,
mobile bigint not null,
gender varchar(50) not null,
emailid varchar(120) not null,
username varchar(150) not null,
pass varchar(150) not null

);

select * from construction
select * from employee




