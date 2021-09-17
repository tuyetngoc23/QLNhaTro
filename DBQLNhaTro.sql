
/****** Object:  Database [DBQLNhaTro]    Script Date: 9/17/2021 16:27:06 ******/
CREATE DATABASE [DBQLNhaTro] 

USE [DBQLNhaTro]
GO

/****** Object:  Table [dbo].[ChiPhi]    Script Date: 9/17/2021 16:27:07 ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/17/2021 16:27:07 ******/
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
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/17/2021 16:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[CMND] [nchar](10) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[QueQuan] [nvarchar](max) NULL,
	[SDT] [nchar](10) NULL,
	[TrangThaiThuePhong] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 9/17/2021 16:27:07 ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 9/17/2021 16:27:07 ******/
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
/****** Object:  Table [dbo].[Thang]    Script Date: 9/17/2021 16:27:07 ******/
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
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 9/17/2021 16:27:07 ******/
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
/****** Object:  Table [dbo].[TraPhong]    Script Date: 9/17/2021 16:27:07 ******/
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
SET IDENTITY_INSERT [dbo].[KhachHang] ON 
GO
INSERT [dbo].[KhachHang] ([ID], [HoTen], [CMND], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [TrangThaiThuePhong]) VALUES (1, N'Huỳnh Văn A', N'          ', N'', CAST(N'1998-09-23' AS Date), N'', N'          ', 0)
GO
INSERT [dbo].[KhachHang] ([ID], [HoTen], [CMND], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [TrangThaiThuePhong]) VALUES (2, N'Huỳnh Văn B', N'12357893  ', N'Nam', CAST(N'1998-09-23' AS Date), N'Bình Thuận', N'9881821412', 0)
GO
INSERT [dbo].[KhachHang] ([ID], [HoTen], [CMND], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [TrangThaiThuePhong]) VALUES (3, N'', N'          ', N'', CAST(N'1998-09-23' AS Date), N'', N'          ', 0)
GO
INSERT [dbo].[KhachHang] ([ID], [HoTen], [CMND], [GioiTinh], [NgaySinh], [QueQuan], [SDT], [TrangThaiThuePhong]) VALUES (4, N'Huỳnh Văn A', N'265179103 ', N'Nam', CAST(N'1998-09-23' AS Date), N'Quận Gò vấp, Tp.HCM', N'8765792211', 0)
GO
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
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
INSERT [dbo].[Phong] ([ID], [SoPhong], [LoaiPhongID], [TrangThai], [SoNguoiToiDa]) VALUES (4, 201, 1, 1, 3)
GO
INSERT [dbo].[Phong] ([ID], [SoPhong], [LoaiPhongID], [TrangThai], [SoNguoiToiDa]) VALUES (5, 202, 2, 0, 4)
GO
INSERT [dbo].[Phong] ([ID], [SoPhong], [LoaiPhongID], [TrangThai], [SoNguoiToiDa]) VALUES (6, 203, 3, 0, 5)
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
SET IDENTITY_INSERT [dbo].[ThuePhong] ON 
GO
INSERT [dbo].[ThuePhong] ([ID], [TienCoc], [NgayThue], [NgayNhanCoc], [KhachHangID], [PhongID], [TrangThaiThanhToan]) VALUES (1, CAST(1000000 AS Decimal(18, 0)), NULL, CAST(N'2021-09-16' AS Date), 1, 4, 0)
GO
INSERT [dbo].[ThuePhong] ([ID], [TienCoc], [NgayThue], [NgayNhanCoc], [KhachHangID], [PhongID], [TrangThaiThanhToan]) VALUES (2, CAST(1000000 AS Decimal(18, 0)), NULL, CAST(N'2021-09-16' AS Date), 1, 4, 0)
GO
SET IDENTITY_INSERT [dbo].[ThuePhong] OFF
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_TrangThaiThuePhong]  DEFAULT ((0)) FOR [TrangThaiThuePhong]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[ThuePhong] ADD  CONSTRAINT [DF_ThuePhong_TrangThaiThanhToan]  DEFAULT ((0)) FOR [TrangThaiThanhToan]
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
/****** Object:  StoredProcedure [dbo].[sp_ThemKH]    Script Date: 9/17/2021 16:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemKH] @tenKH nvarchar(max), @cmnd nchar(10), @queQuan nvarchar(max), 
						@gt nvarchar(50), @ngaySinh date, @sdt nchar(10), @id int
AS
BEGIN
	if(@id in (select ID from KhachHang))
		begin
			update KhachHang
			set HoTen = @tenKH, CMND = @cmnd, QueQuan = @queQuan, GioiTinh = @gt,
				NgaySinh = @ngaySinh,
				SDT = @sdt
			where ID = @id
		end
	else
		begin
			insert into KhachHang(HoTen, CMND, QueQuan, GioiTinh, NgaySinh, SDT) 
			values(@tenKH, @cmnd, @queQuan, @gt, @ngaySinh, @sdt)
		end
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThuePhong]    Script Date: 9/17/2021 16:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThuePhong] @tienCoc decimal, @ngayNhanCoc date, @PhongID int, @KHID int
AS
BEGIN
	insert into ThuePhong(TienCoc, NgayNhanCoc, PhongID, KhachHangID)
	values (@tienCoc, @ngayNhanCoc, @PhongID, @KHID)
	update Phong
	set TrangThai = 1
	where ID = @PhongID
END

GO
USE [master]
GO
ALTER DATABASE [DBQLNhaTro] SET  READ_WRITE 
GO
