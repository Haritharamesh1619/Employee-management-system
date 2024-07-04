create database emp_management
use emp_management
create table login(username varchar(50), password varchar (20))
insert into login (username,password) values('admin','123')
select*from login
create procedure sp_Log 
(
   @uname varchar(50),
   @password varchar(20)
)
as begin
   select count(1) from tbl_register
    where uname=@uname and Password=@password
end
select*from sp_login
-----------------------------------------------------------
create table tbl_register
(
        name varchar(50),
		dob datetime,
		gender varchar(20),
		uname varchar(50),
		password varchar(50),
		confrimpassword varchar(50)
)
delete from tbl_register

insert into register (name,dob,gender,uname,password,confrim_password )
 values('lakshitha','19-02-2001','female','lakshi 123','lakshi 123')





create procedure sp_reg 
(
        @name varchar(50),
		@dob datetime,
		@gender varchar(20),
		@uname varchar(50),
		@password varchar(50),
		@confrimpassword varchar(50)
)
as begin
insert into tbl_register (name,dob,gender,uname,password,confrimpassword)
   values (@name,@dob,@gender,@uname,@password,@confrimpassword)
end
exec sp_reg 'lakshitha','19-02-2002','female','lakshi 123','lakshi 123'

select convert (datetime,RIGHT('25122023',4)+LEFT('25122023',2)+SUBSTRING('25122023',3,2))




create table tbl_empdetail(
emp_id int,
emp_name varchar(50),
emp_gender varchar(50),
emp_dob varchar(50),
emp_address varchar(50),
emp_position varchar(50),
emp_edu varchar(50),
emp_phone varchar (50)

)

create procedure sp_employee(

@emp_id int,
@emp_name varchar(50),
@emp_gender varchar(50),
@emp_dob varchar(50),
@emp_address varchar(50),
@emp_position varchar(50),
@emp_edu varchar(50),
@emp_phone varchar (50)
)

as begin
insert into tbl_empdetail values(@emp_id,@emp_name,@emp_gender,@emp_dob,@emp_address,@emp_position,@emp_edu,@emp_phone)
end



create procedure sp_update(

@emp_id int,
@emp_name varchar(50),
@emp_gender varchar(50),
@emp_dob varchar(50),
@emp_address varchar(50),
@emp_position varchar(50),
@emp_edu varchar(50),
@emp_phone varchar (50)
)

as begin
update tbl_empdetail set
emp_name=@emp_name,
emp_gender=@emp_gender,
emp_dob=@emp_dob,
emp_address=@emp_address,
emp_position=@emp_position,
emp_edu=@emp_edu,
emp_phone=@emp_phone where emp_id=@emp_id
end


alter procedure sp_delete(
@emp_id int
)
as begin
delete from tbl_empdetail where emp_id=@emp_id
end

create procedure sp_search
(
        @emp_id int
)
as begin
select * from tbl_empdetail where emp_id=@emp_id
end


create procedure sp_fetch
as begin
select * from tbl_empdetail
end