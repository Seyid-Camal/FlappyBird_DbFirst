USE [master]
GO
/****** Object:  Database [Flappy_Bird]    Script Date: 18.04.2021 14:03:46 ******/
CREATE DATABASE [Flappy_Bird]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Flappy_Bird', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Flappy_Bird.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Flappy_Bird_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Flappy_Bird_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Flappy_Bird] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Flappy_Bird].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Flappy_Bird] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Flappy_Bird] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Flappy_Bird] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Flappy_Bird] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Flappy_Bird] SET ARITHABORT OFF 
GO
ALTER DATABASE [Flappy_Bird] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Flappy_Bird] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Flappy_Bird] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Flappy_Bird] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Flappy_Bird] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Flappy_Bird] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Flappy_Bird] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Flappy_Bird] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Flappy_Bird] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Flappy_Bird] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Flappy_Bird] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Flappy_Bird] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Flappy_Bird] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Flappy_Bird] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Flappy_Bird] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Flappy_Bird] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Flappy_Bird] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Flappy_Bird] SET RECOVERY FULL 
GO
ALTER DATABASE [Flappy_Bird] SET  MULTI_USER 
GO
ALTER DATABASE [Flappy_Bird] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Flappy_Bird] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Flappy_Bird] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Flappy_Bird] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Flappy_Bird] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Flappy_Bird', N'ON'
GO
ALTER DATABASE [Flappy_Bird] SET QUERY_STORE = OFF
GO
USE [Flappy_Bird]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 18.04.2021 14:03:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[NameLastName] [nchar](100) NOT NULL,
	[UserName] [nchar](100) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[Question] [nchar](100) NOT NULL,
	[Answer] [nchar](100) NOT NULL,
	[PasswordRepeat] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Üye] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [NameLastName], [UserName], [Password], [Question], [Answer], [PasswordRepeat]) VALUES (1, N'Camal                                                                                               ', N'sa                                                                                                  ', N'987       ', N'ewe                                                                                                 ', N'ewew                                                                                                ', N'123       ')
INSERT [dbo].[Member] ([MemberID], [NameLastName], [UserName], [Password], [Question], [Answer], [PasswordRepeat]) VALUES (2, N'aaa                                                                                                 ', N'aaa                                                                                                 ', N'543       ', N'ghhg                                                                                                ', N'mnjk                                                                                                ', N'123       ')
INSERT [dbo].[Member] ([MemberID], [NameLastName], [UserName], [Password], [Question], [Answer], [PasswordRepeat]) VALUES (3, N'bb                                                                                                  ', N'bb                                                                                                  ', N'654       ', N'rdrr                                                                                                ', N'ıhjoıh                                                                                              ', N'123       ')
INSERT [dbo].[Member] ([MemberID], [NameLastName], [UserName], [Password], [Question], [Answer], [PasswordRepeat]) VALUES (4, N'Camal                                                                                               ', N'camalbaku@gmail.com                                                                                 ', N'987       ', N'wqwqw                                                                                               ', N'qwqww                                                                                               ', N'123       ')
SET IDENTITY_INSERT [dbo].[Member] OFF
USE [master]
GO
ALTER DATABASE [Flappy_Bird] SET  READ_WRITE 
GO
