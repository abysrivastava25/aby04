<Query Kind="Expression">
  <Connection>
    <ID>463bc32d-fbaa-42da-b627-052612b097d8</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-RBCTDT8\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAClNl7+2WLEWzltkSlPwgcwAAAAACAAAAAAAQZgAAAAEAACAAAADTmgm3qb6Ipn5Xk5f8jaQDzKYciFxL+s8y6fDNELpKZgAAAAAOgAAAAAIAACAAAAB3A5CDI+a/cZmrKAD52jS+NqNZ8yF7jg3lAN4pASOrtBAAAACP2PEfW1ts9eCEX43mLfBPQAAAAB+E+ZgOopZ8ta/ZPtLgX7CkP1mBh4/9oV59ORrqMvMnkeUGRnn/6sY9HGkxrZjy9LnSUNtHX4dpndVqNTD/7fs=</Password>
    <Database>assign_db</Database>
  </Connection>
</Query>

// QUES 6:  Write LINQ to perform aggregate function Count, Max, Min, Average on the table.



(from e in Employees,
select e.EmpName).Count()

(from e in Employees
select e.Salary).Max()

Employees.Max(e=>e.Salary)   //LAMBDA EXPRESSION

(from e in Employees
select e.Salary).Min()

Employees.Min(e=>e.Salary)   //LAMDA EXPRESSION

(from e in Employees
select e.Salary).Average()

Employees.Average(e=>e.Salary)