USE [master]
GO
/****** Object:  Database [Polyclinic]    Script Date: 06.05.2022 14:02:32 ******/
CREATE DATABASE [Polyclinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Polyclinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\Polyclinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Polyclinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\Polyclinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Polyclinic] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Polyclinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Polyclinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Polyclinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Polyclinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Polyclinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Polyclinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [Polyclinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Polyclinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Polyclinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Polyclinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Polyclinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Polyclinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Polyclinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Polyclinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Polyclinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Polyclinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Polyclinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Polyclinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Polyclinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Polyclinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Polyclinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Polyclinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Polyclinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Polyclinic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Polyclinic] SET  MULTI_USER 
GO
ALTER DATABASE [Polyclinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Polyclinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Polyclinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Polyclinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Polyclinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Polyclinic] SET QUERY_STORE = OFF
GO
USE [Polyclinic]
GO
/****** Object:  Table [dbo].[Applicationsss]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Applicationsss](
	[Id_application] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NULL,
	[Status] [nvarchar](150) NULL,
	[Id_service] [int] NULL,
	[Id_doctor] [int] NULL,
	[Id_cabinet] [int] NULL,
	[Id_user] [int] NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[Id_application] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Business]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Business](
	[Id_business] [int] NOT NULL,
	[Status] [bit] NULL,
	[Id_user] [int] NULL,
	[Id_application] [int] NULL,
	[Id_conclusion] [int] NULL,
 CONSTRAINT [PK_Business] PRIMARY KEY CLUSTERED 
(
	[Id_business] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cabinet]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cabinet](
	[Id_cabinet] [int] NOT NULL,
	[Id_department] [int] NULL,
 CONSTRAINT [PK_Cabinet] PRIMARY KEY CLUSTERED 
(
	[Id_cabinet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conclusion]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conclusion](
	[Id_conclusion] [int] NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Id_application] [int] NULL,
 CONSTRAINT [PK_Conclusion] PRIMARY KEY CLUSTERED 
(
	[Id_conclusion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id_department] [int] NOT NULL,
	[Name] [nchar](35) NULL,
	[Id_polyclinic] [int] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id_department] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[Id_doctor] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Telephone] [nvarchar](50) NULL,
	[Id_doctorType] [int] NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Id_doctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorType]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorType](
	[Id_doctorType] [int] NOT NULL,
	[Name] [nchar](25) NULL,
 CONSTRAINT [PK_DoctorType] PRIMARY KEY CLUSTERED 
(
	[Id_doctorType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id_employees] [int] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Id_department] [int] NULL,
	[Id_doctorType] [int] NULL,
	[Id_Role] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id_employees] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Polyclinic]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Polyclinic](
	[Id_polyclinic] [int] NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[Director] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Polyclinic] PRIMARY KEY CLUSTERED 
(
	[Id_polyclinic] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Role] [int] NOT NULL,
	[Name] [nchar](20) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[Id_service] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [float] NULL,
	[Id_cabinet] [int] NULL,
	[Id_doctor] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[Id_service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 06.05.2022 14:02:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id_user] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Applicationsss]  WITH CHECK ADD  CONSTRAINT [FK_Application_Cabinet] FOREIGN KEY([Id_cabinet])
REFERENCES [dbo].[Cabinet] ([Id_cabinet])
GO
ALTER TABLE [dbo].[Applicationsss] CHECK CONSTRAINT [FK_Application_Cabinet]
GO
ALTER TABLE [dbo].[Applicationsss]  WITH CHECK ADD  CONSTRAINT [FK_Application_Doctor] FOREIGN KEY([Id_doctor])
REFERENCES [dbo].[Doctor] ([Id_doctor])
GO
ALTER TABLE [dbo].[Applicationsss] CHECK CONSTRAINT [FK_Application_Doctor]
GO
ALTER TABLE [dbo].[Applicationsss]  WITH CHECK ADD  CONSTRAINT [FK_Application_Service] FOREIGN KEY([Id_service])
REFERENCES [dbo].[Service] ([Id_service])
GO
ALTER TABLE [dbo].[Applicationsss] CHECK CONSTRAINT [FK_Application_Service]
GO
ALTER TABLE [dbo].[Applicationsss]  WITH CHECK ADD  CONSTRAINT [FK_Application_User] FOREIGN KEY([Id_user])
REFERENCES [dbo].[User] ([Id_user])
GO
ALTER TABLE [dbo].[Applicationsss] CHECK CONSTRAINT [FK_Application_User]
GO
ALTER TABLE [dbo].[Business]  WITH CHECK ADD  CONSTRAINT [FK_Business_Application] FOREIGN KEY([Id_application])
REFERENCES [dbo].[Applicationsss] ([Id_application])
GO
ALTER TABLE [dbo].[Business] CHECK CONSTRAINT [FK_Business_Application]
GO
ALTER TABLE [dbo].[Business]  WITH CHECK ADD  CONSTRAINT [FK_Business_Conclusion] FOREIGN KEY([Id_conclusion])
REFERENCES [dbo].[Conclusion] ([Id_conclusion])
GO
ALTER TABLE [dbo].[Business] CHECK CONSTRAINT [FK_Business_Conclusion]
GO
ALTER TABLE [dbo].[Business]  WITH CHECK ADD  CONSTRAINT [FK_Business_User] FOREIGN KEY([Id_user])
REFERENCES [dbo].[User] ([Id_user])
GO
ALTER TABLE [dbo].[Business] CHECK CONSTRAINT [FK_Business_User]
GO
ALTER TABLE [dbo].[Cabinet]  WITH CHECK ADD  CONSTRAINT [FK_Cabinet_Department] FOREIGN KEY([Id_department])
REFERENCES [dbo].[Department] ([Id_department])
GO
ALTER TABLE [dbo].[Cabinet] CHECK CONSTRAINT [FK_Cabinet_Department]
GO
ALTER TABLE [dbo].[Conclusion]  WITH CHECK ADD  CONSTRAINT [FK_Conclusion_Application] FOREIGN KEY([Id_application])
REFERENCES [dbo].[Applicationsss] ([Id_application])
GO
ALTER TABLE [dbo].[Conclusion] CHECK CONSTRAINT [FK_Conclusion_Application]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Polyclinic] FOREIGN KEY([Id_polyclinic])
REFERENCES [dbo].[Polyclinic] ([Id_polyclinic])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Polyclinic]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_DoctorType] FOREIGN KEY([Id_doctorType])
REFERENCES [dbo].[DoctorType] ([Id_doctorType])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_DoctorType]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Department] FOREIGN KEY([Id_department])
REFERENCES [dbo].[Department] ([Id_department])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Department]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_DoctorType] FOREIGN KEY([Id_doctorType])
REFERENCES [dbo].[DoctorType] ([Id_doctorType])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_DoctorType]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Roles] FOREIGN KEY([Id_Role])
REFERENCES [dbo].[Roles] ([Id_Role])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Roles]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Cabinet] FOREIGN KEY([Id_cabinet])
REFERENCES [dbo].[Cabinet] ([Id_cabinet])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Cabinet]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Doctor] FOREIGN KEY([Id_doctor])
REFERENCES [dbo].[Doctor] ([Id_doctor])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Doctor]
GO
USE [master]
GO
ALTER DATABASE [Polyclinic] SET  READ_WRITE 
GO
