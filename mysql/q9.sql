---where clause cannot be used with aggregate function---
|--- where can be used without group by
-- where clause selects row before grouping
-- having is used only with groupby
--it can be used with aggregate functions 
-- having selects rows after grouping
				
select * from Employee where Emp_id=100
				
select avg(Salary) from Employee group by dob having avg(Salary)>15000
