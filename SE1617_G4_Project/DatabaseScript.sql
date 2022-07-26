USE [master]
GO
/****** Object:  Database [Shop1]    Script Date: 7/26/2022 12:07:29 AM ******/
CREATE DATABASE [Shop1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TIEN\MSSQL\DATA\Shop1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TIEN\MSSQL\DATA\Shop1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Shop1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shop1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Shop1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop1] SET RECOVERY FULL 
GO
ALTER DATABASE [Shop1] SET  MULTI_USER 
GO
ALTER DATABASE [Shop1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shop1', N'ON'
GO
ALTER DATABASE [Shop1] SET QUERY_STORE = OFF
GO
USE [Shop1]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Import]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[import_Date] [date] NOT NULL,
	[staffID] [int] NOT NULL,
	[totalAmount] [float] NULL,
 CONSTRAINT [PK_Import] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetails]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetails](
	[quantity] [int] NOT NULL,
	[price_import] [float] NOT NULL,
	[importID] [int] NOT NULL,
	[productID] [int] NOT NULL,
 CONSTRAINT [PK_ImportDetails] PRIMARY KEY CLUSTERED 
(
	[importID] ASC,
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
	[sellPrice] [float] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC,
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] NOT NULL,
	[orderDate] [datetime] NOT NULL,
	[customerName] [nvarchar](150) NULL,
	[customerAddress] [nvarchar](max) NULL,
	[customerPhone] [nvarchar](50) NULL,
	[totalAmount] [float] NOT NULL,
	[deliverDate] [datetime] NULL,
	[staffID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [float] NOT NULL,
	[discount] [int] NOT NULL,
	[country] [nvarchar](max) NOT NULL,
	[categoryID] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 7/26/2022 12:07:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](150) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[isManager] [bit] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [name]) VALUES (1, N'Bim bim')
INSERT [dbo].[Category] ([id], [name]) VALUES (2, N'Nuoc ngot')
INSERT [dbo].[Category] ([id], [name]) VALUES (3, N'bot giat')
INSERT [dbo].[Category] ([id], [name]) VALUES (4, N'giay an')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Import] ON 

INSERT [dbo].[Import] ([id], [import_Date], [staffID], [totalAmount]) VALUES (4, CAST(N'2022-07-25' AS Date), 1, 10100)
INSERT [dbo].[Import] ([id], [import_Date], [staffID], [totalAmount]) VALUES (5, CAST(N'2022-07-25' AS Date), 1, 100)
INSERT [dbo].[Import] ([id], [import_Date], [staffID], [totalAmount]) VALUES (6, CAST(N'2022-07-25' AS Date), 1, 950)
INSERT [dbo].[Import] ([id], [import_Date], [staffID], [totalAmount]) VALUES (7, CAST(N'2022-07-25' AS Date), 1, 400)
SET IDENTITY_INSERT [dbo].[Import] OFF
GO
INSERT [dbo].[ImportDetails] ([quantity], [price_import], [importID], [productID]) VALUES (1, 100, 4, 1)
INSERT [dbo].[ImportDetails] ([quantity], [price_import], [importID], [productID]) VALUES (1, 10000, 4, 2)
INSERT [dbo].[ImportDetails] ([quantity], [price_import], [importID], [productID]) VALUES (1, 100, 5, 1)
INSERT [dbo].[ImportDetails] ([quantity], [price_import], [importID], [productID]) VALUES (19, 50, 6, 5)
INSERT [dbo].[ImportDetails] ([quantity], [price_import], [importID], [productID]) VALUES (4, 100, 7, 5)
GO
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (1, 1, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (1, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (2, 1, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (2, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (3, 1, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (3, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (4, 1, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (4, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (5, 1, 600, 6)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (5, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (6, 1, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (6, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (7, 1, 10, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (7, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (8, 1, 40, 4)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (8, 2, 70000, 7)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (9, 1, 60, 6)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (9, 2, 50000, 5)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (9, 5, 1100, 11)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (10, 1, 40, 4)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (10, 2, 10000, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (10, 5, 100, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (11, 1, 10, 1)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (11, 2, 30000, 3)
INSERT [dbo].[OrderDetails] ([orderID], [productID], [sellPrice], [quantity]) VALUES (11, 5, 300, 3)
GO
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (1, CAST(N'2022-07-25T03:09:50.000' AS DateTime), N'', N'', N'', 10100, CAST(N'2022-07-25T03:09:50.000' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (2, CAST(N'2022-07-25T03:13:36.020' AS DateTime), N'', N'', N'', 10100, CAST(N'2022-07-25T03:13:36.020' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (3, CAST(N'2022-07-25T03:14:25.570' AS DateTime), N'', N'', N'', 10100, CAST(N'2022-07-25T03:14:25.570' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (4, CAST(N'2022-07-25T03:15:19.593' AS DateTime), N'', N'', N'', 10100, CAST(N'2022-07-25T03:15:19.593' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (5, CAST(N'2022-07-25T03:17:17.613' AS DateTime), N'hieu', N'21331adawdaw', N'91921', 10600, CAST(N'2022-07-25T03:17:17.617' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (6, CAST(N'2022-07-25T03:18:15.820' AS DateTime), N'', N'', N'', 10100, CAST(N'2022-07-25T03:18:15.820' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (7, CAST(N'2022-07-25T03:18:45.263' AS DateTime), N'', N'', N'', 10010, CAST(N'2022-07-25T03:18:45.263' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (8, CAST(N'2022-07-25T08:27:43.500' AS DateTime), N'', N'', N'', 70040, CAST(N'2022-07-25T08:27:43.500' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (9, CAST(N'2022-07-25T11:50:59.913' AS DateTime), N'Phi minh tien', N'han oui', N'1000', 51160, CAST(N'2022-07-25T11:50:59.913' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (10, CAST(N'2022-07-25T14:52:48.860' AS DateTime), N'', N'', N'', 10460, CAST(N'2022-07-25T14:52:48.863' AS DateTime), 1)
INSERT [dbo].[Orders] ([id], [orderDate], [customerName], [customerAddress], [customerPhone], [totalAmount], [deliverDate], [staffID]) VALUES (11, CAST(N'2022-07-25T17:55:22.943' AS DateTime), N'Phi Tien', N'HN', N'0987654321', 30390, CAST(N'2022-07-25T17:55:22.943' AS DateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [description], [quantity], [price], [discount], [country], [categoryID]) VALUES (1, N'cocacola', N'nuoc ngon', 86, 100, 10, N'viet nam', 2)
INSERT [dbo].[Product] ([id], [name], [description], [quantity], [price], [discount], [country], [categoryID]) VALUES (2, N'bim bim tau', N'trung quoc', 84, 10000, 0, N'china', 1)
INSERT [dbo].[Product] ([id], [name], [description], [quantity], [price], [discount], [country], [categoryID]) VALUES (5, N'fanta', N'nuoc ngot co ga', 8, 100, 0, N'viet name', 2)
INSERT [dbo].[Product] ([id], [name], [description], [quantity], [price], [discount], [country], [categoryID]) VALUES (6, N'Tra Xanh 0 do', N'Nuoc uong giai khat', 20, 10000, 0, N'', 2)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([id], [username], [password], [fullname], [phone], [address], [isManager], [status]) VALUES (1, N'staff', N'123', N'hieu le duc a', N'01215152790', N'Ha Noi', 0, 1)
INSERT [dbo].[Staff] ([id], [username], [password], [fullname], [phone], [address], [isManager], [status]) VALUES (2, N'manager', N'123', N'hieu hihi', N'0131213', N'hanoi', 1, 1)
INSERT [dbo].[Staff] ([id], [username], [password], [fullname], [phone], [address], [isManager], [status]) VALUES (3, N'tien', N'123', N'tien phi', N'0987654321', N'Ha Noi VN', 0, 1)
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Import_Staff] FOREIGN KEY([staffID])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Import_Staff]
GO
ALTER TABLE [dbo].[ImportDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetails_Import] FOREIGN KEY([importID])
REFERENCES [dbo].[Import] ([id])
GO
ALTER TABLE [dbo].[ImportDetails] CHECK CONSTRAINT [FK_ImportDetails_Import]
GO
ALTER TABLE [dbo].[ImportDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetails_Product] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[ImportDetails] CHECK CONSTRAINT [FK_ImportDetails_Product]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Product] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Product]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Staff] FOREIGN KEY([staffID])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Staff]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([categoryID])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [Shop1] SET  READ_WRITE 
GO
