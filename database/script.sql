USE [master]
GO
/****** Object:  Database [QuanLyNhaKho]    Script Date: 5/31/2017 8:43:18 AM ******/
CREATE DATABASE [QuanLyNhaKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhaKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyNhaKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhaKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyNhaKho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhaKho] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhaKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhaKho] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhaKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhaKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhaKho] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyNhaKho]
GO
/****** Object:  UserDefinedFunction [dbo].[func_ma_next]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_ma_next](@last_ma varchar(10),@char1 varchar(6),@size int) returns varchar(10)
		as
		begin
			if(@last_ma='')
				set @last_ma=@char1+REPLICATE(0,@size-LEN(@char1))
			declare @num_next_ma int,@next_ma varchar(10)
			set @last_ma=LTRIM(RTRIM(@last_ma))
			set @num_next_ma=REPLACE(@last_ma,@char1,'')+1
			set @size=@size-len(@char1)
			set @next_ma=@char1 + REPLICATE(0,@size-LEN(@char1))
			set @next_ma=@char1+RIGHT(REPLICATE(0,@size)+CONVERT(varchar(MAX),@num_next_ma),@size)
			return @next_ma
		end
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPN] [char](10) NOT NULL,
	[MaHH] [char](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[MaPX] [char](10) NOT NULL,
	[MaHH] [char](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUAHANG]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUAHANG](
	[MaCH] [char](10) NOT NULL,
	[TenCH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [decimal](12, 0) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CUAHANG] PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHH] [char](10) NOT NULL,
	[MaNhom] [char](10) NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nchar](10) NULL,
	[NSX] [date] NULL,
	[HSD] [date] NULL,
	[ThongTin] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [decimal](12, 0) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [decimal](11, 0) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMHANG](
	[MaNhom] [char](10) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHOMHANG] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [char](10) NOT NULL,
	[MaNCC] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[NgayNhap] [date] NOT NULL,
	[TongTien] [float] NOT NULL,
	[ChietKhau] [int] NULL,
	[ThanhTien] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHIEUNHAP_1] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPX] [char](10) NOT NULL,
	[MaCH] [char](10) NOT NULL,
	[MaNV] [char](10) NULL,
	[NgayXuat] [date] NOT NULL,
	[TongTien] [float] NOT NULL,
	[ChietKhau] [int] NULL,
	[ThanhTien] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHIEUXUAT_1] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PN002     ', N'HH002     ', 100, 300000, 30000000, N'')
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PN002     ', N'HH007     ', 20, 300000, 6000000, N'')
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PN002     ', N'HH010     ', 100, 120000, 12000000, N'')
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PN003     ', N'HH003     ', 100, 120000, 12000000, N'')
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPN], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PN003     ', N'HH005     ', 10000, 120000, 1200000000, N'')
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPX], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PX002     ', N'HH001     ', 100, 12000, 1200000, N'')
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPX], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PX002     ', N'HH005     ', 1, 12000, 12000, N'')
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPX], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PX003     ', N'HH001     ', 1, 123333, 123333, N'')
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPX], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PX003     ', N'HH007     ', 1, 12344, 12344, N'')
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPX], [MaHH], [SoLuong], [DonGia], [ThanhTien], [GhiChu]) VALUES (N'PX003     ', N'HH008     ', 5, 12345, 61725, N'')
INSERT [dbo].[CUAHANG] ([MaCH], [TenCH], [DiaChi], [SDT], [GhiChu]) VALUES (N'CH001     ', N'Thuan Envity', N'Nam Dinh', CAST(12321 AS Decimal(12, 0)), NULL)
INSERT [dbo].[CUAHANG] ([MaCH], [TenCH], [DiaChi], [SDT], [GhiChu]) VALUES (N'CH002     ', N'Royal City', N'Hà Nội', CAST(120993 AS Decimal(12, 0)), NULL)
INSERT [dbo].[CUAHANG] ([MaCH], [TenCH], [DiaChi], [SDT], [GhiChu]) VALUES (N'CH003     ', N'Times City', N'Hà Nam ', CAST(19389 AS Decimal(12, 0)), NULL)
INSERT [dbo].[CUAHANG] ([MaCH], [TenCH], [DiaChi], [SDT], [GhiChu]) VALUES (N'CH004     ', N'Aeon-mall', N'Long Biên ', CAST(3297523489 AS Decimal(12, 0)), NULL)
INSERT [dbo].[CUAHANG] ([MaCH], [TenCH], [DiaChi], [SDT], [GhiChu]) VALUES (N'CH005     ', N'Big C', N'Thăng Long', CAST(23978 AS Decimal(12, 0)), NULL)
INSERT [dbo].[DANGNHAP] ([UserName], [Password]) VALUES (N'admin', N'123')
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH001     ', N'NH01      ', N'HP', -1, N'chiếc     ', CAST(N'2017-04-03' AS Date), CAST(N'2022-03-03' AS Date), N'May tinh tam trung', NULL)
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH002     ', N'NH01      ', N'Macbook', 200, N'chiếc     ', CAST(N'2017-04-03' AS Date), CAST(N'2022-03-03' AS Date), N'Hàng xách tay', CAST(N'2017-04-05' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH003     ', N'NH01      ', N'Dell', 203, N'chiếc     ', CAST(N'2017-03-02' AS Date), CAST(N'2018-01-01' AS Date), NULL, CAST(N'2017-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH004     ', N'NH01      ', N'Asus', 104, N'chiếc     ', CAST(N'2013-03-02' AS Date), CAST(N'2018-03-03' AS Date), NULL, CAST(N'2018-03-02' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH005     ', N'NH01      ', N'Lenovo', 10101, N'chiếc     ', CAST(N'2013-02-02' AS Date), CAST(N'2019-03-03' AS Date), NULL, CAST(N'2019-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH006     ', N'NH02      ', N'Sơ Mi Nam', 103, N'chiếc     ', CAST(N'2014-02-02' AS Date), CAST(N'2017-04-04' AS Date), NULL, CAST(N'2015-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH007     ', N'NH02      ', N'Váy Nữ', 119, N'chiếc     ', CAST(N'2014-03-03' AS Date), CAST(N'2019-03-03' AS Date), NULL, CAST(N'2015-03-02' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH008     ', N'NH02      ', N'Áo Khoác ', 97, N'chiếc     ', CAST(N'2014-02-02' AS Date), CAST(N'2019-05-03' AS Date), NULL, CAST(N'2015-02-02' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH009     ', N'NH03      ', N'Giày Thể Thao', 120, N'đôi       ', CAST(N'2014-02-20' AS Date), CAST(N'2019-03-03' AS Date), NULL, CAST(N'2015-05-05' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH010     ', N'NH03      ', N'Adidas', 220, N'đôi       ', CAST(N'2014-04-04' AS Date), CAST(N'2019-03-03' AS Date), NULL, CAST(N'2015-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH011     ', N'NH03      ', N'Nike', 123, N'đôi       ', CAST(N'2012-02-02' AS Date), CAST(N'2017-05-05' AS Date), NULL, CAST(N'2015-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH012     ', N'NH04      ', N'Nokia', 121, N'chiếc     ', CAST(N'2014-04-02' AS Date), CAST(N'2018-04-04' AS Date), N'Bản Quốc Tế', CAST(N'2016-06-06' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH013     ', N'NH04      ', N'Iphone', 121, N'chiếc     ', CAST(N'2015-04-04' AS Date), CAST(N'2019-03-03' AS Date), N'Hàng xách tay', CAST(N'2016-08-08' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH014     ', N'NH04      ', N'SamSung', 120, N'chiếc     ', CAST(N'2016-06-06' AS Date), CAST(N'2019-09-09' AS Date), N'Bản Hàn Quốc ', CAST(N'2016-02-02' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH015     ', N'NH05      ', N'The great Gatsby', 120, N'quyển     ', CAST(N'2017-03-03' AS Date), NULL, N'English version', CAST(N'2017-03-03' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH016     ', N'NH05      ', N'Silicon Valley', 121, N'quyển     ', CAST(N'2016-06-03' AS Date), NULL, NULL, CAST(N'2016-06-06' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH017     ', N'NH05      ', N'Tuổi Trẻ Đáng Giá Bao Nhiêu', 120, N'quyển     ', CAST(N'2013-03-03' AS Date), NULL, NULL, CAST(N'2016-06-06' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH018     ', N'NH06      ', N'Xe Đạp ', 120, N'cái       ', CAST(N'2014-04-04' AS Date), NULL, NULL, CAST(N'2015-05-05' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH019     ', N'NH06      ', N'Lego', 120, N'Hộp       ', CAST(N'2014-03-03' AS Date), NULL, NULL, CAST(N'2015-05-04' AS Date))
INSERT [dbo].[HANGHOA] ([MaHH], [MaNhom], [TenHang], [SoLuong], [DonViTinh], [NSX], [HSD], [ThongTin], [NgayNhap]) VALUES (N'HH020     ', N'NH06      ', N'Rubik', 120, N'khối      ', CAST(N'2015-03-03' AS Date), NULL, NULL, CAST(N'2016-06-06' AS Date))
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC001    ', N'Tran Anh', N'Ha Noi', CAST(32323 AS Decimal(12, 0)), N'')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC002    ', N'Thế Giới Di Động', N'Đan Phượng Hà Nội', CAST(19001233 AS Decimal(12, 0)), NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC003    ', N'HP', N'Valley Silicon', CAST(19202 AS Decimal(12, 0)), NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC004    ', N'Adidas', N'French', CAST(1900029 AS Decimal(12, 0)), NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC005    ', N'Nike', N'Hàn Quốc ', CAST(1900122 AS Decimal(12, 0)), NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT], [GhiChu]) VALUES (N'NCC006    ', N'Rubik', N'Việt Nam ', CAST(1922201 AS Decimal(12, 0)), NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [UserName], [Password]) VALUES (N'NV001     ', N'Nguyễn Văn Thuần', CAST(N'1996-08-26' AS Date), N'Nam       ', N'Ha Noi', CAST(23423 AS Decimal(11, 0)), N'admin', N'123456')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [UserName], [Password]) VALUES (N'NV002     ', N'Trần Duy Hưng', CAST(N'2017-05-06' AS Date), N'Nam       ', N'Vĩnh Phúc', CAST(345423 AS Decimal(11, 0)), N'admin', N'123')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [UserName], [Password]) VALUES (N'NV003     ', N'Lê Quốc Khánh', CAST(N'2017-05-06' AS Date), N'Nam       ', N'Hà Nam', CAST(5342 AS Decimal(11, 0)), N'v                   ', N'c                   ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [UserName], [Password]) VALUES (N'NV004     ', N'Nguyễn Minh Hằng', CAST(N'2017-05-06' AS Date), N'Nữ        ', N'fasdfsa', CAST(234 AS Decimal(11, 0)), N'e                   ', N'123')
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH01      ', N'Máy Tính', 3, NULL)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH02      ', N'Quần Áo', 1, NULL)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH03      ', N'Shoes', 4, N'')
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH04      ', N'Điện Thoại', 1, NULL)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH05      ', N'Sách', 6, NULL)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH06      ', N'Đồ Chơi', 3, NULL)
INSERT [dbo].[NHOMHANG] ([MaNhom], [TenNhom], [SoLuong], [GhiChu]) VALUES (N'NH07      ', N'BC', 0, N'')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PN001     ', N'NCC001    ', N'NV001     ', CAST(N'2014-05-05' AS Date), 0, 0, 0, N'0')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PN002     ', N'NCC001    ', N'NV001     ', CAST(N'2014-06-11' AS Date), 48000000, 0, 48000000, N'')
INSERT [dbo].[PHIEUNHAP] ([MaPN], [MaNCC], [MaNV], [NgayNhap], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PN003     ', N'NCC001    ', N'NV001     ', CAST(N'2017-01-31' AS Date), 1212000000, 0, 1212000000, N'')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [MaCH], [MaNV], [NgayXuat], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PX001     ', N'CH001     ', N'NV001     ', CAST(N'2016-06-06' AS Date), 0, 0, 0, N'0')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [MaCH], [MaNV], [NgayXuat], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PX002     ', N'CH001     ', N'NV001     ', CAST(N'2017-02-14' AS Date), 1212000, 0, 1212000, N'')
INSERT [dbo].[PHIEUXUAT] ([MaPX], [MaCH], [MaNV], [NgayXuat], [TongTien], [ChietKhau], [ThanhTien], [GhiChu]) VALUES (N'PX003     ', N'CH001     ', N'NV001     ', CAST(N'2017-02-28' AS Date), 197402, 0, 197402, N'')
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_HANGHOA] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HANGHOA] ([MaHH])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PHIEUXUAT] ([MaPX])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_CUAHANG] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CUAHANG] ([MaCH])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_CUAHANG]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------ DeleteCH
create proc [dbo].[DeleteCH] (@MaCH char(10))
as
begin 
	Delete CUAHANG
	where MaCH=@MaCH
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteChiTietPhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteChiTietPhieuNhap] (@MaPN char(10))
as 
begin 
		Delete CHITIETPHIEUNHAP
	where MaPN =@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteChiTietPhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteChiTietPhieuXuat] (@MaPX char(10))
as 
begin 
	Delete CHITIETPHIEUXUAT
	where MaPX = @MaPX
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteHangHoa]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----- Delete Hang Hoa 
create proc [dbo].[DeleteHangHoa](@MaHH char(10))
as 
begin
	Delete HANGHOA
	where MaHH=@MaHH
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteNCC](@MaNCC char(10))
as
begin 
	Delete NHACUNGCAP
	where MaNCC=@MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteNhanVien](@MaNV char(10))
as
begin 
	Delete NHANVIEN
	where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteNhomHang](@MaNhom char(10))
as
begin 
	Delete NHOMHANG
	where MaNhom=@MaNhom
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------- Delete PhieuNhap
create proc [dbo].[DeletePhieuNhap] (@MaPN char(10))
as 
begin 
	Delete PHIEUNHAP
	where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeletePhieuXuat] (@MaPX char(10))
as 
begin 
	Delete PHIEUXUAT
	where MaPX=@MaPX
end

GO
/****** Object:  StoredProcedure [dbo].[DeletePX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------ DeletePX
create proc [dbo].[DeletePX](@MaPX char(10))
as
begin 
	Delete PHIEUXUAT
	where MaPX=@MaPX
end
GO
/****** Object:  StoredProcedure [dbo].[EditPassword]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditPassword](@MaNV char(10), @Password nvarchar(20))
as
begin
Update NHANVIEN
set Password=@Password
where MaNV=@MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[GetExportByID]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetExportByID](@MaPX char(10))
as
begin 
select *from PHIEUXUAT
where MaPX=@MaPX
end
GO
/****** Object:  StoredProcedure [dbo].[GetImportByID]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetImportByID] (@MaPN char(10))
as
begin 
select *from PHIEUNHAP
where MaPN = @MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[GetListCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListCH]
as
begin 
	select *from CUAHANG
end
GO
/****** Object:  StoredProcedure [dbo].[GetListCTPNByMaPN]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetListCTPNByMaPN] (@MaPN char (10))
as
begin
	select CHITIETPHIEUNHAP.MaPN, HANGHOA.MaHH,HANGHOA.TenHang,CHITIETPHIEUNHAP.SoLuong,CHITIETPHIEUNHAP.DonGia,CHITIETPHIEUNHAP.ThanhTien,CHITIETPHIEUNHAP.GhiChu
	from HANGHOA,CHITIETPHIEUNHAP,NHOMHANG
	where MaPN=@MaPN and HANGHOA.MaHH = CHITIETPHIEUNHAP.MaHH and HANGHOA.MaNhom = NHOMHANG.MaNhom
end
GO
/****** Object:  StoredProcedure [dbo].[GetListCTPXByMaPX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListCTPXByMaPX] (@MaPX char (10))
as
begin
	select CHITIETPHIEUXUAT.MaPX, HANGHOA.MaHH,HANGHOA.TenHang,CHITIETPHIEUXUAT.SoLuong,CHITIETPHIEUXUAT.DonGia,CHITIETPHIEUXUAT.ThanhTien,CHITIETPHIEUXUAT.GhiChu
	from HANGHOA,CHITIETPHIEUXUAT,NHOMHANG
	where MaPX=@MaPX and HANGHOA.MaHH = CHITIETPHIEUXUAT.MaHH and HANGHOA.MaNhom = NHOMHANG.MaNhom
end
GO
/****** Object:  StoredProcedure [dbo].[GetListHangHoa]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListHangHoa]
as 
 begin 
	select *from HANGHOA
end

GO
/****** Object:  StoredProcedure [dbo].[GetListHHByNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetListHHByNhomHang]
as
begin
select MaHH,NhomHang.TenNhom,NHOMHANG.MaNhom,TenHang,HangHoa.SoLuong,DonViTinh,NSX,HSD,ThongTin,NgayNhap
from HangHoa,NhomHang 
where HangHoa.MaNhom=NHOMHANG.MaNhom
end
GO
/****** Object:  StoredProcedure [dbo].[GetListNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------- GetListNCC
create proc [dbo].[GetListNCC]
as
begin 
	select *from NHACUNGCAP
end
GO
/****** Object:  StoredProcedure [dbo].[GetListNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListNhanVien]
as
begin
	select *from NHANVIEN
	
end 
GO
/****** Object:  StoredProcedure [dbo].[GetListNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetListNhomHang] 
as
begin 
	select *from NHOMHANG
end
GO
/****** Object:  StoredProcedure [dbo].[GetListPhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetListPhieuNhap]
as
begin
select MaPN,PHIEUNHAP.MaNCC,NHACUNGCAP.TenNCC,MaNV,NgayNhap,ThanhTien,ChietKhau,TongTien,PHIEUNHAP.GhiChu
from PHIEUNHAP,NHACUNGCAP
where PHIEUNHAP.MaNCC= NHACUNGCAP.MaNCC

end

GO
/****** Object:  StoredProcedure [dbo].[GetListPhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListPhieuXuat] 
as
begin
	select * 
	from PHIEUXUAT
end
GO
/****** Object:  StoredProcedure [dbo].[GetListStatisticByTimeExport]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListStatisticByTimeExport] (@fromTime date,@toTime date)
as
begin
	select *from PHIEUXUAT
	where NgayXuat between @fromTime and @toTime
end

GO
/****** Object:  StoredProcedure [dbo].[GetListStatisticByTimeImport]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListStatisticByTimeImport](@fromTime date,@toTime date)
as
begin
	select *from PHIEUNHAP
	where NgayNhap between @fromTime and @toTime
end
GO
/****** Object:  StoredProcedure [dbo].[GetListTenCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetListTenCH]
as
begin

select MaCH,TenCH,DiaChi
from CUAHANG
end
GO
/****** Object:  StoredProcedure [dbo].[GetListTenHH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetListTenHH]
as
begin

select MaHH,TenHang
from HANGHOA
end
GO
/****** Object:  StoredProcedure [dbo].[GetListTenNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetListTenNCC]
as
begin

select MaNCC,TenNCC
from NHACUNGCAP
end

GO
/****** Object:  StoredProcedure [dbo].[GetMaCHNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaCHNext]
as
begin 
	select dbo.func_ma_next((select top 1 MaCH from CUAHANG order by  MaCH desc),'CH','5') as MaCH
end
GO
/****** Object:  StoredProcedure [dbo].[GetMaHHNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaHHNext]
as 
begin 
	select  dbo.func_ma_next ((select top 1 MaHH from HANGHOA order by MaHH desc),'HH','5') as MaHH
end

GO
/****** Object:  StoredProcedure [dbo].[GetMaNCCNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetMaNCCNext]
as
begin	
	select dbo.func_ma_next ((select top 1 MaNCC from NHACUNGCAP order by MaNCC desc),'NCC','6') as MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[GetMaNhomHangNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaNhomHangNext]
as
begin 
	select dbo.func_ma_next((select top 1 MaNhom from NHOMHANG order by MaNhom desc),'NH','4')as MaNhom
end
GO
/****** Object:  StoredProcedure [dbo].[GetMaNVNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaNVNext]
as 
	begin 

	select dbo.func_ma_next((select top 1 MaNV from NHANVIEN order by MaNV desc),'NV','5')as MaNV

end
GO
/****** Object:  StoredProcedure [dbo].[GetMaPNNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaPNNext]
as
begin 
	select dbo.func_ma_next((select top 1 MaPN from PHIEUNHAP order by MaPN desc),'PN','5')as MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[GetMaPXNext]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetMaPXNext] 
as
begin 
	select dbo.func_ma_next((select top 1 MaPX from PHIEUXUAT order by MaPX desc),'PX','5') as MaPX
end
GO
/****** Object:  StoredProcedure [dbo].[GetTenNhom]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GetTenNhom]
as
begin
select TenNhom,MaNhom
from NHOMHANG
end
GO
/****** Object:  StoredProcedure [dbo].[GetTotalMoneyExport]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[GetTotalMoneyExport] (@fromTime date,@toTime date)
as
begin 
	select sum (ThanhTien) as ThanhTien
	from PHIEUXUAT
	where NgayXuat between @fromTime and @toTime
end



GO
/****** Object:  StoredProcedure [dbo].[GetTotalMoneyImport]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetTotalMoneyImport] (@fromTime date,@toTime date)
as
begin 
	select sum (ThanhTien)as ThanhTien
	from PHIEUNHAP
	where NgayNhap between @fromTime and @toTime
end

GO
/****** Object:  StoredProcedure [dbo].[InsertCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------ InsertCH
create proc [dbo].[InsertCH](@MaCH char(10),@TenCH nvarchar(10),@DiaChi nvarchar(50),@SDT decimal(12,0),@GhiChu nvarchar(50))
as
begin 
	Insert into CUAHANG(MaCH,TenCH,DiaChi,SDT,GhiChu) values (@MaCH,@TenCH,@DiaChi,@SDT,@GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertCTPN]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertCTPN] (@MaPN char(10),@MaHH char(10),@DonGia int,@SoLuong int,@ThanhTien int,@GhiChu nvarchar(50))
AS
BEGIN 
	Insert into CHITIETPHIEUNHAP values (@MaPN,@MaHH,@SoLuong,@DonGia,@ThanhTien,@GhiChu)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertCTPX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertCTPX](@MaPX char(10),@MaHH char(10),@DonGia int,@SoLuong int,@ThanhTien int,@GhiChu nvarchar(50))
AS
BEGIN 
	Insert into CHITIETPHIEUXUAT values (@MaPX,@MaHH,@SoLuong,@DonGia,@ThanhTien,@GhiChu)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertHangHoa]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertHangHoa](@MaHH char(10),@MaNhom char(10),@TenHang nvarchar(50)
		,@SoLuong int,@DonViTinh nchar(10)
		 ,@NSX date,@HSD date,@ThongTin nvarchar(50), @NgayNhap date)
as 
begin 
	Insert into HANGHOA (MaHH,MaNhom,TenHang,SoLuong,DonViTinh,NSX,HSD,ThongTin,NgayNhap)
			values(@MaHH,@MaNhom,@TenHang,@SoLuong,@DonViTinh,@NSX,@HSD,@ThongTin,@NgayNhap)
end




GO
/****** Object:  StoredProcedure [dbo].[InsertNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertNCC](@MaNCC char(10), @TenNCC nvarchar(50),@DiaChi nvarchar(50),@SDT decimal(12,0),@GhiChu nvarchar(50))
as
begin 
	insert into NHACUNGCAP(MaNCC,TenNCC,DiaChi,SDT,GhiChu) values (@MaNCC,@TenNCC,@DiaChi,@SDT,@GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertNhanVien](@MaNV char(10),@HoTen nvarchar(50), @NgaySinh date,@GioiTinh nchar(10), @DiaChi nvarchar(50), @SDT decimal(12,0),@UserName nchar(20),@Password nchar(20))
as
begin 
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,UserName,Password) values(@MaNV,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@SDT,@UserName,@Password)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertNhomHang](@MaNhom char(10),@TenNhom nvarchar(50),@SoLuong int, @GhiChu nvarchar(50))
as
begin
	insert into NHOMHANG(MaNhom,TenNhom,SoLuong,GhiChu) values(@MaNhom,@TenNhom,@SoLuong,@GhiChu)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertPhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertPhieuNhap](@MaPN char(10),@MaNCC char(10),@MaNV char(10),@NgayNhap date,@TongTien float,@ChietKhau int,@ThanhTien float,@GhiChu nvarchar(50))
as
begin 
	insert into PHIEUNHAP(MaPN,MaNCC,MaNV,NgayNhap,TongTien,ChietKhau,ThanhTien,GhiChu) values(@MaPN,@MaNCC,@MaNV,@NgayNhap,@TongTien,@ChietKhau,@ThanhTien,@GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertPX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertPX](@MaPX char(10),@MaCH char(10),@MaNV char(10),@NgayXuat date, @TongTien float,@ChietKhau int,@ThanhTien float,@GhiChu nvarchar(50))
as
begin 
	Insert into PHIEUXUAT(MaPX,MaCH,MaNV,NgayXuat,TongTien,ChietKhau,ThanhTien,GhiChu) values(@MaPX,@MaCH,@MaNV,@NgayXuat,@TongTien,@ChietKhau,@ThanhTien,@GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[ListHangHoaByNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ListHangHoaByNhomHang](@MaNhom char(10))
as
begin 
	select HANGHOA.MaHH,HANGHOA.TenHang,HANGHOA.SoLuong
	from NHOMHANG, HANGHOA
	where NHOMHANG.MaNhom = HANGHOA.MaNhom and NHOMHANG.MaNhom=@MaNhom
end

GO
/****** Object:  StoredProcedure [dbo].[SearchCuaHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchCuaHang] (@maCH char(10))
as
begin 
	select *from CUAHANG where MaCH = @maCH
end
GO
/****** Object:  StoredProcedure [dbo].[SearchHangHoa]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchHangHoa] (@maHH char(10))
as
begin 
	select *from HANGHOA where MaHH = @maHH
end
GO
/****** Object:  StoredProcedure [dbo].[SearchNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchNCC] (@MaNCC char(10))
as
begin 
	select *from NHACUNGCAP where MaNCC=@MaNCC
	end
GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SearchNhanVien] (@maNV char(10))
as
begin 
	select *from NHANVIEN where MaNV = @maNV
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateCH](@MaCH char(10),@TenCH nvarchar(10),@DiaChi nvarchar(50),@SDT decimal(12,0),@GhiChu nvarchar(50))
as 
begin 
	Update CUAHANG
	set TenCH=@TenCH,DiaChi=@DiaChi,SDT=@SDT,GhiChu=@GhiChu
	where MaCH=@MaCH
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateChiTietPhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateChiTietPhieuNhap](@MaPN char(10),@MaHH char(10),@SoLuong int,@DonGia int ,@ThanhTien int, @GhiChu nvarchar(50))
as
begin 
	

	Insert into CHITIETPHIEUNHAP values (@MaPN,@MaHH,@SoLuong,@DonGia,@ThanhTien,@GhiChu)

end
GO
/****** Object:  StoredProcedure [dbo].[UpdateChiTietPhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateChiTietPhieuXuat](@MaPX char(10),@MaHH char(10),@SoLuong int,@DonGia int ,@ThanhTien int, @GhiChu nvarchar(50))
as
begin 
	

	Insert into CHITIETPHIEUXUAT values (@MaPX,@MaHH,@SoLuong,@DonGia,@ThanhTien,@GhiChu)

end

GO
/****** Object:  StoredProcedure [dbo].[UpdateHangHoa]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateHangHoa](@MaHH char(10),@MaNhom char(10),@TenHang nvarchar(50)
						,@SoLuong int,@DonViTinh nchar(10)
						 ,@NSX date,@HSD date,@ThongTin nvarchar(50),@NgayNhap date)
as 
begin 
	Update HANGHOA
	set MaNhom = @MaNhom,TenHang = @TenHang,SoLuong=@SoLuong,DonViTinh=@DonViTinh
		,NSX=@NSX,HSD=@HSD,ThongTin=@ThongTin, NgayNhap=@NgayNhap
	where MaHH=@MaHH
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateNCC] (@MaNCC char(10), @TenNCC nvarchar(50),@DiaChi nvarchar(50),@SDT decimal(12,0),@GhiChu nvarchar(50))
as
begin 
	Update NHACUNGCAP
	set TenNCC=@TenNCC,DiaChi=@DiaChi,SDT=@SDT,GhiChu=@GhiChu
	where MaNCC=@MaNCC
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[UpdateNhanVien](@MaNV char(10),@HoTen nvarchar(50), @NgaySinh date,@GioiTinh nchar(10), @DiaChi nvarchar(50), @SDT decimal(12,0),@UserName nchar(20),@Password nchar(20))
as
begin 
	update NHANVIEN
	set HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh = @GioiTinh,DiaChi=@DiaChi,SDT=@SDT,UserName=@UserName,Password=@Password
	where MaNV=@MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[UpdateNhomHang](@MaNhom char(10),@TenNhom nvarchar(50),@SoLuong int, @GhiChu nvarchar(50))
as
begin 
	Update NHOMHANG
	set TenNhom=@TenNhom,SoLuong=@SoLuong,GhiChu=@GhiChu
	where MaNhom=@MaNhom
end 
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- UpdatePhieuNhap
create proc [dbo].[UpdatePhieuNhap](@MaPN char(10),@MaNCC char(10),@MaNV char(10),@NgayNhap date,@TongTien float,@ChietKhau int,@ThanhTien float,@GhiChu nvarchar(50))
as
begin
	Update PHIEUNHAP
	set MaNCC=@MaNCC,MaNV=@MaNV,NgayNhap=@NgayNhap,TongTien=@TongTien,ChietKhau=@ChietKhau,ThanhTien=@ThanhTien,GhiChu=@GhiChu
	where MaPN=@MaPN
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePhieuXuat] (@MaPX char(10),@MaCH char(10),@MaNV char(10),@NgayXuat datetime , @TongTien int,@ChietKhau int, @ThanhTien int,@GhiChu nvarchar(50))
as
begin
	Update PHIEUXUAT
	set MaCH=@MaCH,MaNV=@MaNV,NgayXuat=@NgayXuat,TongTien=@TongTien,ChietKhau=@ChietKhau,ThanhTien=@ThanhTien,GhiChu=@GhiChu
	where MaPX=@MaPX
end


GO
/****** Object:  StoredProcedure [dbo].[UpdatePX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdatePX](@MaPX char(10),@MaCH char(10),@MaNV char(10),@NgayXuat date, @TongTien float,@ChietKhau int,@ThanhTien float,@GhiChu nvarchar(50))
as
begin 
	Update PHIEUXUAT
	set MaCH=@MaCH, MaNV=@MaNV,NgayXuat=@NgayXuat,TongTien=@TongTien,ChietKhau=@ChietKhau,ThanhTien=@ThanhTien,GhiChu=@GhiChu
	where MaPX=@MaPX
end
GO
/****** Object:  Trigger [dbo].[tg_Update_DeleteCTPN]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[tg_Update_DeleteCTPN] on [dbo].[CHITIETPHIEUNHAP] for insert,delete, update 
as
declare @MaHH1 char(10),@MaHH2 char(10), @SoLuong1 int ,@SoLuong2 int 
begin 
	select @MaHH1=MaHH from inserted
	select @MaHH2 = MaHH from deleted
	select @SoLuong1=SoLuong from inserted
	select @SoLuong2 = SoLuong from deleted
	
	Update HANGHOA
	set SoLuong=SoLuong+@SoLuong1
	where MaHH=@MaHH1

	Update HANGHOA
	set SoLuong=SoLuong-@SoLuong2
	where MaHH=@MaHH2
end
GO
/****** Object:  Trigger [dbo].[tg_Update_DeleteCTPX]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------ Khi delete, update CTPN thì SoLuong trong HangHoa đc cập nhật lại
create trigger [dbo].[tg_Update_DeleteCTPX] on [dbo].[CHITIETPHIEUXUAT] for insert,delete, update 
as
declare @MaHH1 char(10),@MaHH2 char(10), @SoLuong1 int ,@SoLuong2 int 
begin 
	select @MaHH1=MaHH from inserted
	select @MaHH2 = MaHH from deleted
	select @SoLuong1=SoLuong from inserted
	select @SoLuong2 = SoLuong from deleted
	
	Update HANGHOA
	set SoLuong=SoLuong-@SoLuong1
	where MaHH=@MaHH1

	Update HANGHOA
	set SoLuong=SoLuong+@SoLuong2
	where MaHH=@MaHH2
end
GO
/****** Object:  Trigger [dbo].[tg_DeleteCH]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[tg_DeleteCH] on [dbo].[CUAHANG] instead of Delete
as
declare @MaCH char(10)
begin 
	select @MaCH = MaCH from deleted

	Update PHIEUXUAT
	set MaCH = null
	where MaCH = @MaCH

	Delete CUAHANG
	where MaCH=@MaCH
end

GO
/****** Object:  Trigger [dbo].[tg_UpdateSoLuong]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_UpdateSoLuong] on [dbo].[HANGHOA] for insert,delete
as
declare @MaNhom1 char(10),@MaNhom2 char(10)
begin 
	select @MaNhom1 = MaNhom from inserted
	select @MaNhom2 = MaNhom from deleted
	
	Update NHOMHANG
	set SoLuong = SoLuong+1
	where  MaNhom=@MaNhom1

	Update NHOMHANG
	set SoLuong = SoLuong -1 
	where MaNhom = @MaNhom2
end

GO
/****** Object:  Trigger [dbo].[tg_DeleteNCC]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_DeleteNCC] on [dbo].[NHACUNGCAP] instead of delete
as
declare @MaNCC char(10)
begin 
	select @MaNCC=MaNCC from deleted

	Update PHIEUNHAP
	set MaNCC=null
	where MaNCC=@MaNCC


	Delete NHACUNGCAP
	where MaNCC=@MaNCC
end
GO
/****** Object:  Trigger [dbo].[tg_DeleteNhanVien]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_DeleteNhanVien] on [dbo].[NHANVIEN] instead of delete
as
declare @MaNV char(10)
begin 
	select @MaNV=MaNV from deleted

	Update PHIEUXUAT 
	set MaNV= null
	where MaNV = @MaNV

	Update PHIEUNHAP 
	set MaNV = null
	where MaNV = @MaNV

	Delete NHANVIEN
	where MaNV =@MaNV
end
GO
/****** Object:  Trigger [dbo].[tg_DeleteNhomHang]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE trigger [dbo].[tg_DeleteNhomHang] on [dbo].[NHOMHANG] instead of delete
as
declare 
	@MaNhom char(10)
begin 
	select @MaNhom=MaNhom from deleted

	Update HANGHOA 
	set MaNhom =null
	where MaNhom = @MaNhom

	Delete NHOMHANG
	where MaNhom=@MaNhom
end


GO
/****** Object:  Trigger [dbo].[tg_DeletePhieuNhap]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_DeletePhieuNhap] on [dbo].[PHIEUNHAP] instead of Delete
as 
declare @MaPN char (10)
begin 
select @MaPN = MaPN from deleted
 
 Delete CHITIETPHIEUNHAP
 where MaPN = @MaPN

 Delete PHIEUNHAP
 where MaPN =@MaPN 
end
GO
/****** Object:  Trigger [dbo].[tg_DeletePhieuXuat]    Script Date: 5/31/2017 8:43:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[tg_DeletePhieuXuat] on [dbo].[PHIEUXUAT] instead of Delete
as 
declare @MaPX char (10)
begin 
select @MaPX = MaPX from deleted
 
 Delete CHITIETPHIEUXUAT
 where MaPX = @MaPX

 Delete PHIEUXUAT
 where MaPX = @MaPX 
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaKho] SET  READ_WRITE 
GO
