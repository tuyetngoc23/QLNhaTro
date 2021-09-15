
/****** Object:  Database [DBQLNhaTro]    Script Date: 9/15/2021 19:26:11 ******/
CREATE DATABASE [DBQLNhaTro] 

USE [DBQLNhaTro]
GO

/****** Object:  Table [dbo].[ChiPhi]    Script Date: 9/15/2021 19:26:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiPhi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Gia] [decimal](18, 0) NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiPhi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoDien] [int] NULL,
	[SoNuoc] [int] NULL,
	[TongTien] [decimal](18, 0) NULL,
	[ThuePhongID] [int] NULL,
	[ThangID] [int] NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[CMND] [nchar](10) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](max) NULL,
	[SDT] [nchar](10) NULL,
	[TrangThaiThuePhong] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Gia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoPhong] [int] NULL,
	[LoaiPhongID] [int] NULL,
	[TrangThai] [bit] NULL,
	[SoNguoiToiDa] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thang]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Thang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TienCoc] [decimal](18, 0) NULL,
	[NgayThue] [date] NULL,
	[NgayNhanCoc] [date] NULL,
	[KhachHangID] [int] NULL,
	[PhongID] [int] NULL,
	[TrangThaiThanhToan] [bit] NULL,
 CONSTRAINT [PK_ThuePhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/15/2021 19:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayTra] [date] NULL,
	[ThuePhongID] [int] NULL,
	[TraCoc] [bit] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_TraPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiPhi] ON 
GO
INSERT [dbo].[ChiPhi] ([ID], [Ten], [Gia], [DonViTinh]) VALUES (1, N'Điện', CAST(3500 AS Decimal(18, 0)), N'kg')
GO
INSERT [dbo].[ChiPhi] ([ID], [Ten], [Gia], [DonViTinh]) VALUES (2, N'Nước', CAST(7000 AS Decimal(18, 0)), N'khối')
GO
INSERT [dbo].[ChiPhi] ([ID], [Ten], [Gia], [DonViTinh]) VALUES (3, N'Rác', CAST(20000 AS Decimal(18, 0)), N'phòng')
GO
INSERT [dbo].[ChiPhi] ([ID], [Ten], [Gia], [DonViTinh]) VALUES (4, N'Wifi', CAST(80000 AS Decimal(18, 0)), N'phòng')
GO
INSERT [dbo].[ChiPhi] ([ID], [Ten], [Gia], [DonViTinh]) VALUES (5, N'Dịch vụ khác', CAST(20000 AS Decimal(18, 0)), N'phòng')
GO
SET IDENTITY_INSERT [dbo].[ChiPhi] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 
GO
INSERT [dbo].[LoaiPhong] ([ID], [Ten], [Gia]) VALUES (1, N'Phòng nhỏ', CAST(1500000 AS Decimal(18, 0)))
GO
INSERT [dbo].[LoaiPhong] ([ID], [Ten], [Gia]) VALUES (2, N'Phòng vừa', CAST(2000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[LoaiPhong] ([ID], [Ten], [Gia]) VALUES (3, N'Phòng lớn', CAST(2500000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 
GO
INSERT [dbo].[Phong] ([ID], [SoPhong], [LoaiPhongID], [TrangThai], [SoNguoiToiDa]) VALUES (1, 203, 1, 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[Thang] ON 
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (1, N'Tháng 1')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (2, N'Tháng 2')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (3, N'Tháng 3')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (4, N'Tháng 4')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (5, N'Tháng 5')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (6, N'Tháng 6')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (7, N'Tháng 7')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (8, N'Tháng 8')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (9, N'Tháng 9')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (10, N'Tháng 10')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (11, N'Tháng 11')
GO
INSERT [dbo].[Thang] ([ID], [Ten]) VALUES (12, N'Tháng 12')
GO
SET IDENTITY_INSERT [dbo].[Thang] OFF
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Thang] FOREIGN KEY([ThangID])
REFERENCES [dbo].[Thang] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Thang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ThuePhong] FOREIGN KEY([ThuePhongID])
REFERENCES [dbo].[ThuePhong] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_ThuePhong]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([LoaiPhongID])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KhachHang] FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KhachHang]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_Phong] FOREIGN KEY([PhongID])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_Phong]
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD  CONSTRAINT [FK_TraPhong_ThuePhong1] FOREIGN KEY([ThuePhongID])
REFERENCES [dbo].[ThuePhong] ([ID])
GO
ALTER TABLE [dbo].[TraPhong] CHECK CONSTRAINT [FK_TraPhong_ThuePhong1]
GO
USE [master]
GO
ALTER DATABASE [DBQLNhaTro] SET  READ_WRITE 
GO
