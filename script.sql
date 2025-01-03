USE [master]
GO
/****** Object:  Database [LotusPansiyon]    Script Date: 1.01.2025 14:05:44 ******/
CREATE DATABASE [LotusPansiyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LotusPansiyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LotusPansiyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LotusPansiyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LotusPansiyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LotusPansiyon] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LotusPansiyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LotusPansiyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LotusPansiyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LotusPansiyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LotusPansiyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LotusPansiyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [LotusPansiyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LotusPansiyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LotusPansiyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LotusPansiyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LotusPansiyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LotusPansiyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LotusPansiyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LotusPansiyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LotusPansiyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LotusPansiyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LotusPansiyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LotusPansiyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LotusPansiyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LotusPansiyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LotusPansiyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LotusPansiyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LotusPansiyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LotusPansiyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LotusPansiyon] SET  MULTI_USER 
GO
ALTER DATABASE [LotusPansiyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LotusPansiyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LotusPansiyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LotusPansiyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LotusPansiyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LotusPansiyon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LotusPansiyon] SET QUERY_STORE = ON
GO
ALTER DATABASE [LotusPansiyon] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LotusPansiyon]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[Kullanici] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Internet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Mesajid] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](255) NOT NULL,
	[Mesaj] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mesajid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriEkle](
	[Musteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](100) NULL,
	[Soyadi] [varchar](100) NULL,
	[Cinsiyet] [varchar](10) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](100) NULL,
	[TC] [varchar](11) NULL,
	[OdaNo] [int] NULL,
	[Ucret] [decimal](10, 2) NULL,
	[GirisTarihi] [datetime] NULL,
	[CikisTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Musteriid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda101]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda101](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda102]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda102](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda103]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda103](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda104]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda104](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda105]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda105](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda106]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda106](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda107]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda107](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda108]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda108](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda109]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda109](
	[Adi] [varchar](50) NULL,
	[Soyadi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 1.01.2025 14:05:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stoklar](
	[Gıda] [int] NULL,
	[Icecek] [int] NULL,
	[Cerezler] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [LotusPansiyon] SET  READ_WRITE 
GO
