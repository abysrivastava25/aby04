
alter table Employee add salary int
create table Sal_Details
(
Sal_id int primary key,
E_id int,
sal_month varchar(20),
amount int
)

--drop table Employee
create table Employee
(
Emp_id int identity(100,1) primary key ,
EmpName varchar(30),
mob_no bigint check(mob_no between 1000000000 and 9999999999),
DOB DateTime2(3),
ZIP_Code int check(ZIP_Code between 100000 and 999999),
IsActive bit default 0,
created_date DateTime2(3),
modified_date dateTime2(3),
Salary money
)
insert into Employee
values('abhishek',1234567890,'1998-08-02',123456,1,GETDATE(),NULL,NULL)
select * from Employee

insert into Employee
values('azeem',1234567888,'1996-01-15',223456,1,GETDATE(),NULL,NULL)
insert into Employee
values('neha',1234565890,'1995-07-07',156456,1,GETDATE(),NULL,NULL)
insert into Employee
values('vijay',1236547890,'1995-04-01',133456,1,GETDATE(),NULL,NULL)
insert into Employee
values('vishesh',5234456789,'1997-09-09',178456,1,GETDATE(),NULL,NULL)
insert into Employee
values('arpit',6784678907,'1996-08-07',123499,1,GETDATE(),NULL,NULL)


select * from Employee

alter table Sal_Details add foreign key(E_id) references Employee(Emp_id)

insert into Sal_Details
values(1,100,'january',20000)

insert into Sal_Details
values(2,100,'febraury',20000)
insert into Sal_Details
values(3,100,'march',20000)

insert into Sal_Details
values(4,101,'january',25000)
insert into Sal_Details
values(5,101,'febraury',25000)
insert into Sal_Details
values(6,101,'march',25000)

insert into Sal_Details
values(7,102,'january',20000)
insert into Sal_Details
values(8,102,'febraury',20000)
insert into Sal_Details
values(9,102,'march',20000)

insert into Sal_Details
values(10,103,'january',22000)
insert into Sal_Details
values(11,103,'febraury',22000)
insert into Sal_Details
values(12,103,'march',22000)

insert into Sal_Details
values(13,104,'january',30000)
insert into Sal_Details
values(14,104,'febraury',30000)
insert into Sal_Details
values(15,104,'march',30000)

insert into Sal_Details
values(16,105,'january',21000)
insert into Sal_Details
values(17,105,'febraury',21000)
insert into Sal_Details
values(18,105,'march',21000)

-- procedure for adding the salary 
alter PROCEDURE SUM_SALARY_2 @e_id bigint, @output int output
AS
begin
 set @output= (select sum(amount) from Sal_Details where E_id=@e_id)
 return @output
end
-- main procedure for setting the value of salary
alter procedure Sal_sum9
as
BEGIN
	DECLARE @Total varchar(10),@INITIALIZER varchar(5)
	SET @Total= (SELECT COUNT(*)FROM Employee)
	SET @INITIALIZER=1
	
	
	--CREATE TABLE EMPLOYEES_ID (emp_id int)
	--INSERT INTO EMPLOYEES_ID(emp_id) SELECT Emp_id FROM EMPLOYEE

	DEclare @EMPLOYEES_ID as table
	(
		id int
	)
	INSERT INTO @EMPLOYEES_ID(id) SELECT Emp_id FROM EMPLOYEE
--	insert into @empId select Emp_id from Employee ;--reshhhddh

	WHILE @INITIALIZER<=@Total
		BEGIN
		declare @result int
			DECLARE @EMP_ID int
			SET @EMP_ID= (select top 1 id from @EMPLOYEES_ID )
			  EXEC SUM_SALARY_2 @EMP_ID, @result output
			update Employee set Salary= @result where Emp_id=@EMP_ID;
			print @result
			DELETE  @EMPLOYEES_ID Where id =@EMP_ID;
			set @INITIALIZER=@INITIALIZER+1;
			set @result=0;
		END
END
GO


--exec Sal_sum9

--select * from Employee