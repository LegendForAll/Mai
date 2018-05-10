USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QuanLyTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QuanLyTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QuanLyTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QuanLyTV]
GO

USE [QuanLyTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 5/8/2018 2:47:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDocGia](
	[maDocGia] [nvarchar](50) NOT NULL,
	[LoaiDocGia] [int] NOT NULL,
	[HoTen] [varchar](50) NOT NULL,
	[DiaChi] [varchar](50) NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[NgayLapThe] [datetime2](7) NOT NULL,
	[NguoiLapThe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[maDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyTV]
GO

/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 5/8/2018 2:48:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[MaLoaiDocGia] [int] NOT NULL,
	[TenLoaiDocGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLyTV]
GO

INSERT INTO [dbo].[tblLoaiDocGia]
           ([MaLoaiDocGia]
           ,[TenLoaiDocGia])
     VALUES
           (1,N'Friendly')
GO
INSERT INTO [dbo].[tblLoaiDocGia]
           ([MaLoaiDocGia]
           ,[TenLoaiDocGia])
     VALUES
           (2,N'Vip')
GO