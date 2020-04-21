USE [DB_VS]
CREATE TABLE [dbo].[Side_Navbar](
	[NavBar_ID] [int] NULL,
	[Name] [varchar](30) NULL,
	[Reference] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Login]    Script Date: 22-04-2020 04:03:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Password] [varchar](30) NULL,
	[Role] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Student]    Script Date: 22-04-2020 04:03:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Student](
	[ID] [int] IDENTITY(2,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (1, N'Student', N'StudentDetails')
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (2, N'CalciTest', N'Calculator')
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (3, N'Question1', N'Ques1')
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (4, N'Question2', N'Ques2')
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (5, N'Question3', N'Ques3')
GO
INSERT [dbo].[Side_Navbar] ([NavBar_ID], [Name], [Reference]) VALUES (6, N'Question4', N'Ques4')
GO
SET IDENTITY_INSERT [dbo].[TBL_Login] ON 
GO
INSERT [dbo].[TBL_Login] ([ID], [Name], [Password], [Role]) VALUES (1, N'Abhishek', N'abhi123', N'Admin')
GO
INSERT [dbo].[TBL_Login] ([ID], [Name], [Password], [Role]) VALUES (2, N'vijay', N'vijay123', N'User')
GO
INSERT [dbo].[TBL_Login] ([ID], [Name], [Password], [Role]) VALUES (3, N'neha', N'neha123', NULL)
GO
SET IDENTITY_INSERT [dbo].[TBL_Login] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Student] ON 
GO
INSERT [dbo].[TBL_Student] ([ID], [Name], [Age], [Gender]) VALUES (2, N'Abhishek', 23, N'Male')
GO
INSERT [dbo].[TBL_Student] ([ID], [Name], [Age], [Gender]) VALUES (3, N'Azeem', 23, N'Male')
GO
INSERT [dbo].[TBL_Student] ([ID], [Name], [Age], [Gender]) VALUES (4, N'Vijay', 25, N'Male')
GO
INSERT [dbo].[TBL_Student] ([ID], [Name], [Age], [Gender]) VALUES (5, N'Vishesh', 21, N'Male')
GO
INSERT [dbo].[TBL_Student] ([ID], [Name], [Age], [Gender]) VALUES (6, N'Arpit', 22, N'Male')
GO
SET IDENTITY_INSERT [dbo].[TBL_Student] OFF
GO
