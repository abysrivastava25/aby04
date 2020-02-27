--view is used to make temporary or virtual tables which can be used
--to do manipulations on some preferred data. View are used for security purpose in the database.

create view [Employee abhishek] as select * from Employee where EmpName='abhishek'

select * from [Employee abhishek]