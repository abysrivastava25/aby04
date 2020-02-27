create table Employee_copy
( name varchar(20),
id int )

insert into Employee_copy(name,id) select EmpName,Emp_id from Employee 

select * from Employee_copy