USE [DB_VS]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 13-04-2020 04:30:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NULL,
	[LastName] [varchar](30) NULL,
	[Address] [varchar](30) NULL,
	[Gender] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [Address], [Gender]) VALUES (1, N'vijay', N'Kumar', N'delhi', N'M')
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [Address], [Gender]) VALUES (2, N'Abhishek', N'Srivastava', N'Allahabad', N'M')
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [Address], [Gender]) VALUES (3, N'Neha', N'Goel', N'Delhi', N'F')
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [Address], [Gender]) VALUES (4, N'Sonal', N'Jha', N'Varanasi', N'F')
GO
INSERT [dbo].[Employee] ([ID], [FirstName], [LastName], [Address], [Gender]) VALUES (5, N'vishesh', N'Kapoor', N'Ghaziabad', N'M')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
