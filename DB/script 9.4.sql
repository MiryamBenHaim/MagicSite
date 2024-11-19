USE [MagicalDB]
GO
/****** Object:  Table [dbo].[CategoryProductTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProductTbl](
	[cpId] [int] IDENTITY(1,1) NOT NULL,
	[cpCatId] [int] NOT NULL,
	[cpGenProdId] [int] NOT NULL,
 CONSTRAINT [PK_CategoryProductTbl] PRIMARY KEY CLUSTERED 
(
	[cpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTbl](
	[catId] [int] IDENTITY(1,1) NOT NULL,
	[catName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CategoryTbl] PRIMARY KEY CLUSTERED 
(
	[catId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CityTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTbl](
	[cityId] [int] IDENTITY(1,1) NOT NULL,
	[cityName] [varchar](20) NOT NULL,
	[cityShippPrice] [float] NOT NULL,
 CONSTRAINT [PK_CityTvl] PRIMARY KEY CLUSTERED 
(
	[cityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColorTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorTbl](
	[colorId] [int] IDENTITY(1,1) NOT NULL,
	[colorName] [varbinary](50) NOT NULL,
 CONSTRAINT [PK_ColorTbl] PRIMARY KEY CLUSTERED 
(
	[colorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GeneralProductTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneralProductTbl](
	[genProdId] [int] NOT NULL,
	[genProdName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_GeneralProductTbl] PRIMARY KEY CLUSTERED 
(
	[genProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersTbl](
	[ordId] [int] IDENTITY(1,1) NOT NULL,
	[ordUserId] [int] NOT NULL,
	[ordDate] [date] NOT NULL,
	[ordStatus] [varchar](10) NOT NULL,
	[ordDateSend] [date] NULL,
	[ordTotalPayment] [float] NOT NULL,
 CONSTRAINT [PK_OrdersTbl] PRIMARY KEY CLUSTERED 
(
	[ordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PictureTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PictureTbl](
	[picId] [int] IDENTITY(1,1) NOT NULL,
	[picName] [varchar](150) NOT NULL,
	[picProdId] [int] NOT NULL,
 CONSTRAINT [PK_PictureTbl_1] PRIMARY KEY CLUSTERED 
(
	[picId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductOrderTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductOrderTbl](
	[poId] [int] NOT NULL,
	[poOrdId] [int] NOT NULL,
	[poProdId] [int] NOT NULL,
	[poNote] [varchar](200) NULL,
	[poCityId] [int] NOT NULL,
	[poAddress] [varchar](30) NOT NULL,
	[poUserId] [int] NOT NULL,
	[poNameGet] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ProductOrderTbl] PRIMARY KEY CLUSTERED 
(
	[poId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[prodId] [int] NOT NULL,
	[prodGeneralId] [int] NOT NULL,
	[prodColorId] [int] NOT NULL,
	[prodName] [varchar](20) NOT NULL,
	[prodDesc] [varchar](50) NULL,
	[prodPrice] [float] NOT NULL,
	[prodQty] [int] NOT NULL,
	[prodInStack] [bit] NOT NULL,
	[prodStatus] [varchar](10) NOT NULL,
	[prodPic] [varchar](150) NOT NULL,
	[prodInSale] [bit] NOT NULL,
	[prodSalePrice] [float] NULL,
 CONSTRAINT [PK_ProductTbl] PRIMARY KEY CLUSTERED 
(
	[prodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 09/04/2024 11:01:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](30) NOT NULL,
	[userPhone] [varchar](20) NOT NULL,
	[userEmail] [varchar](50) NOT NULL,
	[userPass] [varchar](50) NOT NULL,
	[userCityId] [int] NULL,
	[userAddress] [varchar](30) NULL,
 CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CategoryProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProductTbl_CategoryTbl] FOREIGN KEY([cpCatId])
REFERENCES [dbo].[CategoryTbl] ([catId])
GO
ALTER TABLE [dbo].[CategoryProductTbl] CHECK CONSTRAINT [FK_CategoryProductTbl_CategoryTbl]
GO
ALTER TABLE [dbo].[CategoryProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProductTbl_GeneralProductTbl] FOREIGN KEY([cpGenProdId])
REFERENCES [dbo].[GeneralProductTbl] ([genProdId])
GO
ALTER TABLE [dbo].[CategoryProductTbl] CHECK CONSTRAINT [FK_CategoryProductTbl_GeneralProductTbl]
GO
ALTER TABLE [dbo].[OrdersTbl]  WITH CHECK ADD  CONSTRAINT [FK_OrdersTbl_UserTbl] FOREIGN KEY([ordUserId])
REFERENCES [dbo].[UserTbl] ([userId])
GO
ALTER TABLE [dbo].[OrdersTbl] CHECK CONSTRAINT [FK_OrdersTbl_UserTbl]
GO
ALTER TABLE [dbo].[PictureTbl]  WITH CHECK ADD  CONSTRAINT [FK_PictureTbl_ProductTbl] FOREIGN KEY([picProdId])
REFERENCES [dbo].[ProductTbl] ([prodId])
GO
ALTER TABLE [dbo].[PictureTbl] CHECK CONSTRAINT [FK_PictureTbl_ProductTbl]
GO
ALTER TABLE [dbo].[ProductOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderTbl_CityTbl] FOREIGN KEY([poCityId])
REFERENCES [dbo].[CityTbl] ([cityId])
GO
ALTER TABLE [dbo].[ProductOrderTbl] CHECK CONSTRAINT [FK_ProductOrderTbl_CityTbl]
GO
ALTER TABLE [dbo].[ProductOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderTbl_OrdersTbl] FOREIGN KEY([poOrdId])
REFERENCES [dbo].[OrdersTbl] ([ordId])
GO
ALTER TABLE [dbo].[ProductOrderTbl] CHECK CONSTRAINT [FK_ProductOrderTbl_OrdersTbl]
GO
ALTER TABLE [dbo].[ProductOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderTbl_ProductTbl] FOREIGN KEY([poProdId])
REFERENCES [dbo].[ProductTbl] ([prodId])
GO
ALTER TABLE [dbo].[ProductOrderTbl] CHECK CONSTRAINT [FK_ProductOrderTbl_ProductTbl]
GO
ALTER TABLE [dbo].[ProductOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderTbl_UserTbl] FOREIGN KEY([poUserId])
REFERENCES [dbo].[UserTbl] ([userId])
GO
ALTER TABLE [dbo].[ProductOrderTbl] CHECK CONSTRAINT [FK_ProductOrderTbl_UserTbl]
GO
ALTER TABLE [dbo].[ProductOrderTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductOrderTbl_UserTbl1] FOREIGN KEY([poUserId])
REFERENCES [dbo].[UserTbl] ([userId])
GO
ALTER TABLE [dbo].[ProductOrderTbl] CHECK CONSTRAINT [FK_ProductOrderTbl_UserTbl1]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_ColorTbl] FOREIGN KEY([prodColorId])
REFERENCES [dbo].[ColorTbl] ([colorId])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_ColorTbl]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_GeneralProductTbl] FOREIGN KEY([prodGeneralId])
REFERENCES [dbo].[GeneralProductTbl] ([genProdId])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_GeneralProductTbl]
GO
ALTER TABLE [dbo].[UserTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserTbl_CityTbl] FOREIGN KEY([userCityId])
REFERENCES [dbo].[CityTbl] ([cityId])
GO
ALTER TABLE [dbo].[UserTbl] CHECK CONSTRAINT [FK_UserTbl_CityTbl]
GO
