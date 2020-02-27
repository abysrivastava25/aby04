--stored procedure not always return a value 
--user defined function always return a value

create function get_name1(@EMP_ID int)
returns  varchar(30)
as
begin
	return(select EmpName from Employee where @EMP_ID=Emp_id)
end 

print dbo.get_name1(100)
	

create procedure change_name1
as
begin 
update Employee
set EmpName='himanshu'
where Emp_id=100
end

exec change_name1