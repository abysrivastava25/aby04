CREATE DATABASE [assign_db]
USE [assign_db]
GO
/****** Object:  UserDefinedFunction [dbo].[get_name]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[get_name](@EMP_ID int)
returns  varchar(30)
as
begin
	return(select EmpName from Employee)
end
GO
/****** Object:  UserDefinedFunction [dbo].[get_name1]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[get_name1](@EMP_ID int)
returns  varchar(30)
as
begin
	return(select EmpName from Employee where @EMP_ID=Emp_id)
end 
GO
/****** Object:  UserDefinedFunction [dbo].[Sal_Sum]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Sal_Sum](@id int)
returns int
as
begin
	return (select sum(amount) from Sal_Details where E_id=@id)
end
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_id] [int] IDENTITY(100,1) NOT NULL,
	[EmpName] [varchar](30) NULL,
	[mob_no] [bigint] NULL,
	[DOB] [datetime2](3) NULL,
	[ZIP_Code] [int] NULL,
	[IsActive] [bit] NULL,
	[created_date] [datetime2](3) NULL,
	[modified_date] [datetime2](3) NULL,
	[Salary] [money] NULL,
	[Std_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Employee abhishek]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Employee abhishek] as select * from Employee where EmpName='abhishek'
GO
/****** Object:  Table [dbo].[demo_1]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[demo_1](
	[e_name] [varchar](20) NULL,
	[Roll_no] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Roll_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dhshdsd]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dhshdsd](
	[emp_id] [int] IDENTITY(100,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_copy]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_copy](
	[name] [varchar](20) NULL,
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sal_Details]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sal_Details](
	[Sal_id] [int] NOT NULL,
	[E_id] [int] NULL,
	[sal_month] [varchar](20) NULL,
	[amount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[st_id] [int] IDENTITY(100,1) NOT NULL,
	[stName] [varchar](30) NULL,
	[DOB] [datetime2](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[st_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[demo_1] ([e_name], [Roll_no]) VALUES (N'abhishek', 1)
GO
INSERT [dbo].[demo_1] ([e_name], [Roll_no]) VALUES (N'abhay', 2)
GO
SET IDENTITY_INSERT [dbo].[dhshdsd] ON 
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (100)
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (101)
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (102)
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (103)
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (104)
GO
INSERT [dbo].[dhshdsd] ([emp_id]) VALUES (105)
GO
SET IDENTITY_INSERT [dbo].[dhshdsd] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (100, N'himanshu', 1234567890, CAST(N'1998-08-02T00:00:00.0000000' AS DateTime2), 123456, 1, CAST(N'2020-02-26T22:51:00.8730000' AS DateTime2), NULL, 60000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (101, N'azeem', 1234567888, CAST(N'1996-01-15T00:00:00.0000000' AS DateTime2), 223456, 1, CAST(N'2020-02-26T22:51:00.8830000' AS DateTime2), NULL, 75000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (102, N'neha', 1234565890, CAST(N'1995-07-07T00:00:00.0000000' AS DateTime2), 156456, 1, CAST(N'2020-02-26T22:51:00.8830000' AS DateTime2), NULL, 60000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (103, N'vijay', 1236547890, CAST(N'1995-04-01T00:00:00.0000000' AS DateTime2), 133456, 1, CAST(N'2020-02-26T22:51:00.8830000' AS DateTime2), NULL, 66000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (104, N'vishesh', 5234456789, CAST(N'1997-09-09T00:00:00.0000000' AS DateTime2), 178456, 1, CAST(N'2020-02-26T22:51:00.8830000' AS DateTime2), NULL, 90000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (105, N'arpit', 6784678907, CAST(N'1996-08-07T00:00:00.0000000' AS DateTime2), 123499, 1, CAST(N'2020-02-26T22:51:00.8830000' AS DateTime2), NULL, 63000.0000, NULL)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (106, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 100)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (107, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 101)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (108, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 102)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (109, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 103)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (110, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 104)
GO
INSERT [dbo].[Employee] ([Emp_id], [EmpName], [mob_no], [DOB], [ZIP_Code], [IsActive], [created_date], [modified_date], [Salary], [Std_id]) VALUES (111, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, 105)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'abhishek', 100)
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'azeem', 101)
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'neha', 102)
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'vijay', 103)
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'vishesh', 104)
GO
INSERT [dbo].[Employee_copy] ([name], [id]) VALUES (N'arpit', 105)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (1, 100, N'january', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (2, 100, N'febraury', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (3, 100, N'march', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (4, 101, N'january', 25000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (5, 101, N'febraury', 25000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (6, 101, N'march', 25000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (7, 102, N'january', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (8, 102, N'febraury', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (9, 102, N'march', 20000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (10, 103, N'january', 22000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (11, 103, N'febraury', 22000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (12, 103, N'march', 22000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (13, 104, N'january', 30000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (14, 104, N'febraury', 30000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (15, 104, N'march', 30000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (16, 105, N'january', 21000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (17, 105, N'febraury', 21000)
GO
INSERT [dbo].[Sal_Details] ([Sal_id], [E_id], [sal_month], [amount]) VALUES (18, 105, N'march', 21000)
GO
SET IDENTITY_INSERT [dbo].[student] ON 
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (100, N'abhay', CAST(N'1998-08-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (101, N'adil', CAST(N'1992-04-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (102, N'anas', CAST(N'1998-02-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (103, N'taha', CAST(N'1994-08-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (104, N'mohit', CAST(N'1997-03-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[student] ([st_id], [stName], [DOB]) VALUES (105, N'rahman', CAST(N'1992-08-02T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[student] OFF
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([Std_id])
REFERENCES [dbo].[student] ([st_id])
GO
ALTER TABLE [dbo].[Sal_Details]  WITH CHECK ADD FOREIGN KEY([E_id])
REFERENCES [dbo].[Employee] ([Emp_id])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([mob_no]>=(1000000000) AND [mob_no]<=(9999999999.)))
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([ZIP_Code]>=(100000) AND [ZIP_Code]<=(999999)))
GO
/****** Object:  StoredProcedure [dbo].[change_name]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[change_name](@id int)
as 
begin 
update Employee
set EmpName='himanshu'
where @id=Emp_id
end
GO
/****** Object:  StoredProcedure [dbo].[change_name1]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[change_name1]
as
begin 
update Employee
set EmpName='himanshu'
where Emp_id=100
end
GO
/****** Object:  StoredProcedure [dbo].[Sal_sum3]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sal_sum3] @e_id varchar(40) 
as
select sum(amount) from Sal_Details where E_id=@e_id
GO
/****** Object:  StoredProcedure [dbo].[Sal_sum4]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Sal_sum4] @e_id varchar(40) 
as
BEGIN
DECLARE @Total varchar(10)
SET @Total= (SELECT COUNT(*)FROM Employee)
select sum(amount) from Sal_Details where E_id=@e_id
END
GO
/****** Object:  StoredProcedure [dbo].[Sal_sum5]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sal_sum5] @e_id varchar(40) 
as
BEGIN
DECLARE @Total varchar(10)
SET @Total= (SELECT COUNT(*)FROM Employee)
PRINT @Total
select sum(amount) from Sal_Details where E_id=@e_id
END
GO
/****** Object:  StoredProcedure [dbo].[Sal_sum6]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Sal_sum6] @e_id varchar(40) 
as
BEGIN
DECLARE @Total varchar(10)
SET @Total= (SELECT COUNT(*)FROM Employee)
PRINT @Total
--select sum(amount) from Sal_Details where E_id=@e_id
END
GO
/****** Object:  StoredProcedure [dbo].[Sal_sum9]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sal_sum9]
as
BEGIN
	DECLARE @Total varchar(10),@INITIALIZER varchar(5)
	SET @Total= (SELECT COUNT(*)FROM Employee)
	SET @INITIALIZER=1
	PRINT @Total
	
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
/****** Object:  StoredProcedure [dbo].[SUM_SALARY]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procEDURE [dbo].[SUM_SALARY] @e_id int
AS
select sum(amount) from Sal_Details where E_id=@e_id
GO
/****** Object:  StoredProcedure [dbo].[SUM_SALARY_1]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SUM_SALARY_1] @e_id bigint
AS
select sum(amount) from Sal_Details where E_id=@e_id
GO
/****** Object:  StoredProcedure [dbo].[SUM_SALARY_2]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SUM_SALARY_2] @e_id bigint, @output int output
AS
begin
 set @output= (select sum(amount) from Sal_Details where E_id=@e_id)
 return @output
end
GO
/****** Object:  StoredProcedure [dbo].[SUM_SALARY_4]    Script Date: 19-03-2020 14:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SUM_SALARY_4] @e_id bigint
AS
select sum(amount) from Sal_Details where E_id=@e_id
GO
USE [master]
GO
ALTER DATABASE [assign_db] SET  READ_WRITE 
GO
