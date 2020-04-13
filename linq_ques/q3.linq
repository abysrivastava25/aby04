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

// QUES 3:  Write LINQ to get the top two records from the table and perform sorting in descending order.



(from t in Employees
orderby t.Emp_id descending
select t).Take(2)