USE [user_managment_database]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/1/2023 2:17:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](255) NULL,
	[Last_Name] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[Created_on] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [First_Name], [Last_Name], [Address], [Created_on]) VALUES (1, N'Madawa', N'Herath', N'AL Nadha', CAST(N'2023-09-01T02:14:25.527' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
