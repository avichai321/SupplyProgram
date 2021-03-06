USE [SuplyProgram]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[PackageID] [int] IDENTITY(1,1) NOT NULL,
	[PackageType] [nvarchar](50) NULL,
	[ScaleID] [int] NOT NULL,
 CONSTRAINT [PK_Packages] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductStatus1]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductStatus1](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[LocationID] [int] NULL,
	[ProductID] [int] NULL,
	[PackageID] [int] NULL,
	[UnitInstock] [int] NULL,
	[UnitinOrder] [int] NULL,
 CONSTRAINT [PK_ProductStatus1] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScaleValue]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScaleValue](
	[ScaleID] [int] IDENTITY(1,1) NOT NULL,
	[ScalesTypes] [nvarchar](50) NULL,
 CONSTRAINT [PK_ScaleValue] PRIMARY KEY CLUSTERED 
(
	[ScaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/02/2022 19:30:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UsersID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UsersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([LocationID], [Location]) VALUES (1, N'HOME 1')
INSERT [dbo].[Locations] ([LocationID], [Location]) VALUES (2, N'STORE')
INSERT [dbo].[Locations] ([LocationID], [Location]) VALUES (3, N'HOME 2')
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[Packages] ON 

INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (1, N'BOX 1', 1)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (2, N'BOX 2', 2)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (3, N'Bag 1', 1)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (4, N'Bag 2', 5)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (5, N'Small Bag 1', 2)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (6, N'Small Bag 2', 3)
INSERT [dbo].[Packages] ([PackageID], [PackageType], [ScaleID]) VALUES (7, N'BOX 3', 4)
SET IDENTITY_INSERT [dbo].[Packages] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (1, N'Black peppercorns')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (2, N'Ground cinnamon')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (3, N'Chili powder')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (4, N'Hot-red-chili flakes')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (5, N'Cumin')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (6, N'Ground ginger')
INSERT [dbo].[Products] ([ProductID], [ProductName]) VALUES (7, N'Spicy Paprika')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductStatus1] ON 

INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (1, 1, 2, 3, 10, 30)
INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (2, 1, 5, 1, 15, 30)
INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (4, 2, 3, 3, 20, 25)
INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (5, 3, 6, 4, 15, 16)
INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (8, 2, 3, 1, 15, 30)
INSERT [dbo].[ProductStatus1] ([StatusID], [LocationID], [ProductID], [PackageID], [UnitInstock], [UnitinOrder]) VALUES (9, 1, 1, 1, 10, 15)
SET IDENTITY_INSERT [dbo].[ProductStatus1] OFF
GO
SET IDENTITY_INSERT [dbo].[ScaleValue] ON 

INSERT [dbo].[ScaleValue] ([ScaleID], [ScalesTypes]) VALUES (1, N'5 kg')
INSERT [dbo].[ScaleValue] ([ScaleID], [ScalesTypes]) VALUES (2, N'10 kg')
INSERT [dbo].[ScaleValue] ([ScaleID], [ScalesTypes]) VALUES (3, N'500 g')
INSERT [dbo].[ScaleValue] ([ScaleID], [ScalesTypes]) VALUES (4, N'300 g')
INSERT [dbo].[ScaleValue] ([ScaleID], [ScalesTypes]) VALUES (5, N'100 g')
SET IDENTITY_INSERT [dbo].[ScaleValue] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UsersID], [Username], [Password], [Email], [Admin]) VALUES (1, N'AdminUser', N'Aa123456', N'admin@gmail.com', 1)
INSERT [dbo].[Users] ([UsersID], [Username], [Password], [Email], [Admin]) VALUES (2, N'User1', N'Aa123456', N'user1@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Packages]  WITH CHECK ADD  CONSTRAINT [FK_Packages_ScaleValue] FOREIGN KEY([ScaleID])
REFERENCES [dbo].[ScaleValue] ([ScaleID])
GO
ALTER TABLE [dbo].[Packages] CHECK CONSTRAINT [FK_Packages_ScaleValue]
GO
ALTER TABLE [dbo].[ProductStatus1]  WITH CHECK ADD  CONSTRAINT [FK_ProductStatus1_Locations] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Locations] ([LocationID])
GO
ALTER TABLE [dbo].[ProductStatus1] CHECK CONSTRAINT [FK_ProductStatus1_Locations]
GO
ALTER TABLE [dbo].[ProductStatus1]  WITH CHECK ADD  CONSTRAINT [FK_ProductStatus1_Packages] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Packages] ([PackageID])
GO
ALTER TABLE [dbo].[ProductStatus1] CHECK CONSTRAINT [FK_ProductStatus1_Packages]
GO
ALTER TABLE [dbo].[ProductStatus1]  WITH CHECK ADD  CONSTRAINT [FK_ProductStatus1_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductStatus1] CHECK CONSTRAINT [FK_ProductStatus1_Products]
GO
