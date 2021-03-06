USE [master]
GO
/****** Object:  Database [StockTracking]    Script Date: 10.02.2021 19:58:17 ******/
CREATE DATABASE [StockTracking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockTracking', FILENAME = N'C:\Users\engin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\StockTracking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockTracking_log', FILENAME = N'C:\Users\engin\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\StockTracking.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockTracking] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockTracking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockTracking] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_NULLS ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_PADDING ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [StockTracking] SET ARITHABORT ON 
GO
ALTER DATABASE [StockTracking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockTracking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockTracking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockTracking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockTracking] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [StockTracking] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [StockTracking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockTracking] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [StockTracking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockTracking] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockTracking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockTracking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockTracking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockTracking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockTracking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockTracking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockTracking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockTracking] SET RECOVERY FULL 
GO
ALTER DATABASE [StockTracking] SET  MULTI_USER 
GO
ALTER DATABASE [StockTracking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockTracking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockTracking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockTracking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockTracking] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockTracking] SET QUERY_STORE = OFF
GO
USE [StockTracking]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [StockTracking]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[EMail] [varchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInStores]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInStores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[StoreId] [int] NOT NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](100) NULL,
	[Unit] [varchar](100) NULL,
	[Description] [varchar](100) NULL,
	[Image] [varchar](100) NULL,
	[CriticalStock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockMovements]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockMovements](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](4) NULL,
	[MemberNumber] [int] NULL,
	[ProductId] [int] NULL,
	[Piece] [int] NULL,
	[UnitPrice] [decimal](10, 2) NULL,
	[TotalPrice] [decimal](10, 2) NULL,
	[TransactionDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stores]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[EMail] [varchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.02.2021 19:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[EMail] [varchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [CompanyName], [FirstName], [LastName], [EMail], [PhoneNumber]) VALUES (1, N'Sarar', N'Ali Talha', N'Yenice', N'alitalha2626@gmail.com', N'05436321365')
INSERT [dbo].[Customers] ([Id], [CompanyName], [FirstName], [LastName], [EMail], [PhoneNumber]) VALUES (2, N'Sarar', N'Atiye', N'Unal', N'atiyeunal@gmail.com', N'123456')
INSERT [dbo].[Customers] ([Id], [CompanyName], [FirstName], [LastName], [EMail], [PhoneNumber]) VALUES (3, N'Opet', N'Kevser', N'Unal', N'kevserunal26@gmail.com', N'12345')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductInStores] ON 

INSERT [dbo].[ProductInStores] ([Id], [ProductId], [StoreId], [Stock]) VALUES (3, 1, 1, 100)
INSERT [dbo].[ProductInStores] ([Id], [ProductId], [StoreId], [Stock]) VALUES (1002, 2, 2, 15)
INSERT [dbo].[ProductInStores] ([Id], [ProductId], [StoreId], [Stock]) VALUES (1003, 2, 1, 25)
INSERT [dbo].[ProductInStores] ([Id], [ProductId], [StoreId], [Stock]) VALUES (2003, 2, 1002, 160)
SET IDENTITY_INSERT [dbo].[ProductInStores] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Type], [Unit], [Description], [Image], [CriticalStock]) VALUES (1, N'Içecek', N'Litre', N'Uludag Gazoz', N'asd', 25)
INSERT [dbo].[Products] ([Id], [Type], [Unit], [Description], [Image], [CriticalStock]) VALUES (2, N'Yiyecek', N'Gram', N'Doritos  Cips', N'asd', 20)
INSERT [dbo].[Products] ([Id], [Type], [Unit], [Description], [Image], [CriticalStock]) VALUES (3, N'Yiyecek', N'Adet', N'Ülker Çikolata', N'asd', 15)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[StockMovements] ON 

INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (4, N'Buy', 1, 1, 50, CAST(12.50 AS Decimal(10, 2)), CAST(625.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (5, N'Sell', 1, 1, 25, CAST(8.50 AS Decimal(10, 2)), CAST(212.50 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (6, N'Sell', 1, 1, 25, CAST(10.00 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (1002, N'Buy', 2, 2, 100, CAST(3.00 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (1003, N'Buy', 2, 2, 50, CAST(3.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (1004, N'Sell', 2, 2, 10, CAST(7.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
INSERT [dbo].[StockMovements] ([Id], [Type], [MemberNumber], [ProductId], [Piece], [UnitPrice], [TotalPrice], [TransactionDate]) VALUES (1005, N'Sell', 2, 2, 8, CAST(10.25 AS Decimal(10, 2)), CAST(82.00 AS Decimal(10, 2)), CAST(N'2021-02-10' AS Date))
SET IDENTITY_INSERT [dbo].[StockMovements] OFF
GO
SET IDENTITY_INSERT [dbo].[Stores] ON 

INSERT [dbo].[Stores] ([Id], [Name], [Address], [PhoneNumber]) VALUES (1, N'A', N'Gölkmeydan Mahallesi Fidangül Sokak No 9 Daire 18', N'05436321365')
INSERT [dbo].[Stores] ([Id], [Name], [Address], [PhoneNumber]) VALUES (2, N'B', N'Eskisehir / Odunpazari', N'05444444444')
INSERT [dbo].[Stores] ([Id], [Name], [Address], [PhoneNumber]) VALUES (1002, N'C', N'Eskisehir / Mahmudiye', N'05422222222')
SET IDENTITY_INSERT [dbo].[Stores] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([Id], [CompanyName], [EMail], [PhoneNumber]) VALUES (1, N'Yurtiçi Kargo', N'enginyenice2626@gmail.com', N'05436321365')
INSERT [dbo].[Suppliers] ([Id], [CompanyName], [EMail], [PhoneNumber]) VALUES (2, N'Sürat Kargo', N'suratkargo@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [EMail], [PhoneNumber], [UserName], [Password]) VALUES (4, N'Muzaffer', N'Yenice', N'muzafferyenice26@gmail.com', N'05436321365', N'MuzafferYenice', N'1234')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [EMail], [PhoneNumber], [UserName], [Password]) VALUES (5, N'Nevin', N'Yenice', N'nevinyenice26@gmail.com', N'05436321365', N'NevinYenice', N'1234')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [EMail], [PhoneNumber], [UserName], [Password]) VALUES (6, N'Ali Talha', N'Yenice', N'alitalhayenice26@gmail.com', N'05436321365', N'AliTalhaYenice', N'1234')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [StockTracking] SET  READ_WRITE 
GO
