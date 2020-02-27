create function get_name1(@EMP_ID int)
returns  varchar(30)
as
begin
	return(select EmpName from Employee where @EMP_ID=Emp_id)
end 

print dbo.get_name1(100)
	