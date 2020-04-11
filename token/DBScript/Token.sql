CREATE DATABASE [TokenDB]
USE [TokenDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserName] [varchar](30) NULL,
	[Pass] [varchar](30) NULL,
	[Role] [varchar](20) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([UserName], [Pass], [Role]) VALUES (N'Abhishek', N'abhi123', N'Admin')
GO
INSERT [dbo].[Login] ([UserName], [Pass], [Role]) VALUES (N'Vijay', N'vijay123', N'User')
GO
INSERT [dbo].[Login] ([UserName], [Pass], [Role]) VALUES (N'Anurag', N'anu123', N'User')
GO
USE [master]
GO
ALTER DATABASE [TokenDB] SET  READ_WRITE 
GO
