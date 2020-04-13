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

// QUES 7:  Write LINQ to perform the Grouping operation.



from t in Employees
group t by t.Emp_id 

Employees.GroupBy(t=>t.Emp_id)   //LAMBDA EXPRESSION

from t in Sal_Details
group t by t.Sal_id


Sal_Details.GroupBy(t=>t.Sal_id)    //LAMBDA EXPRESSION