CREATE DATABASE [DB_VS]
 
USE [DB_VS]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] NULL,
	[Name] [varchar](30) NULL,
	[Salary] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Library]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Library](
	[Books_ID] [int] NULL,
	[Books_Issued] [int] NULL,
	[Books_Left] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Library1]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Library1](
	[Books_ID] [int] IDENTITY(10,1) NOT NULL,
	[Books_Issued] [int] NULL,
	[Books_Left] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTN]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTN](
	[Name] [varchar](30) NULL,
	[ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTN1]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTN1](
	[Name] [varchar](30) NULL,
	[Password] [varchar](30) NULL,
	[City] [varchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary]) VALUES (1, N'Abhishek', 25000)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary]) VALUES (2, N'Sonal', 27000)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary]) VALUES (4, N'Neha', 22000)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary]) VALUES (5, N'vishesh', 21000)
GO
INSERT [dbo].[Employee] ([Id], [Name], [Salary]) VALUES (6, N'Aditi', 30000)
GO
SET IDENTITY_INSERT [dbo].[Library1] ON 
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (10, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (11, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (12, 2, 51)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (13, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (14, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (15, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (10, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (11, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (12, 2, 51)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (13, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (14, 1, 50)
GO
INSERT [dbo].[Library1] ([Books_ID], [Books_Issued], [Books_Left]) VALUES (15, 1, 50)
GO
SET IDENTITY_INSERT [dbo].[Library1] OFF
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'abhishek', 3976)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'neha goel', 4072)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'vishesh', 4072)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'sonal', 4148)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'vijay', 4168)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'abhishek', 3976)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'neha goel', 4072)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'vishesh', 4072)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'sonal', 4148)
GO
INSERT [dbo].[TTN] ([Name], [ID]) VALUES (N'vijay', 4168)
GO
INSERT [dbo].[TTN1] ([Name], [Password], [City]) VALUES (N'abhishek ', N'abhi123', N'abhi123')
GO
INSERT [dbo].[TTN1] ([Name], [Password], [City]) VALUES (N'abhishek ', N'abhi123', N'Allahabad ')
GO
INSERT [dbo].[TTN1] ([Name], [Password], [City]) VALUES (N'abhishek ', N'abhi123', N'abhi123')
GO
INSERT [dbo].[TTN1] ([Name], [Password], [City]) VALUES (N'abhishek ', N'abhi123', N'Allahabad ')
GO
/****** Object:  StoredProcedure [dbo].[proc_db]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_db] 
@Books_ID int,@Books_Issued int
as
begin
select Books_Left from Library1
where Books_ID like @Books_ID and Books_Issued like @Books_Issued
end 
GO
/****** Object:  StoredProcedure [dbo].[proc_Insert]    Script Date: 19-03-2020 15:43:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_Insert]
@ID int, @Name varchar(30),@Salary int
as 
begin
insert into Employee(Id,Name,Salary) values(@ID,@Name,@Salary)
end 
GO
USE [master]
GO
ALTER DATABASE [DB_VS] SET  READ_WRITE 
GO
