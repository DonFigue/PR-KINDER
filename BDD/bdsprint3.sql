USE [master]
GO
/****** Object:  Database [dbInstitution]    Script Date: 10/10/2023 16:44:00 ******/
CREATE DATABASE [dbInstitution]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbInstitution', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbInstitution.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbInstitution_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbInstitution_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbInstitution] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbInstitution].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbInstitution] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbInstitution] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbInstitution] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbInstitution] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbInstitution] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbInstitution] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbInstitution] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbInstitution] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbInstitution] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbInstitution] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbInstitution] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbInstitution] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbInstitution] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbInstitution] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbInstitution] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbInstitution] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbInstitution] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbInstitution] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbInstitution] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbInstitution] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbInstitution] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbInstitution] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbInstitution] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbInstitution] SET  MULTI_USER 
GO
ALTER DATABASE [dbInstitution] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbInstitution] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbInstitution] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbInstitution] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbInstitution] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbInstitution] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbInstitution] SET QUERY_STORE = OFF
GO
USE [dbInstitution]
GO
/****** Object:  Table [dbo].[Institution]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institution](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](65) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[latitude] [float] NOT NULL,
	[longitude] [float] NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[idCity] [smallint] NOT NULL,
	[registrerDate] [datetime] NOT NULL,
	[status] [tinyint] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Institution] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwInstitution]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwInstitution]
AS
SELECT id, name AS 'Nombre Institucion', address AS 'Direccion',latitude AS 'Latitud', longitude AS 'Longitud', phone AS 'Telefono'
FROM Institution
WHERE status=1
GO
/****** Object:  Table [dbo].[Area]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[areaName] [varchar](50) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asignature]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignature](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[nameAsignature] [varchar](30) NOT NULL,
	[areaID] [smallint] NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
	[idGrade] [smallint] NULL,
 CONSTRAINT [PK_Asignature] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attorney]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attorney](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](60) NOT NULL,
	[lastName] [varchar](60) NOT NULL,
	[secondLastName] [varchar](60) NULL,
	[ci] [varchar](15) NOT NULL,
	[gender] [char](1) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[occupation] [varchar](65) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Attorney] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[courseName] [nvarchar](30) NOT NULL,
	[teacherID] [smallint] NULL,
	[gradeID] [smallint] NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[grade] [varchar](20) NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
	[InstitutionID] [smallint] NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grade_Student]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grade_Student](
	[idStudent] [smallint] NOT NULL,
	[idGrade] [smallint] NOT NULL,
	[Year] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingrendient]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrendient](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[idPlate] [smallint] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Ingrendient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateOfPayment] [datetime] NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[PaymentState] [nvarchar](50) NOT NULL,
	[Snack] [bit] NOT NULL,
	[TutorID] [smallint] NULL,
	[PlanID] [int] NOT NULL,
	[userID] [smallint] NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](60) NOT NULL,
	[lastName] [varchar](60) NOT NULL,
	[secondLastName] [varchar](60) NULL,
	[ci] [varchar](15) NOT NULL,
	[gender] [char](1) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[birthdate] [datetime] NOT NULL,
	[placeOfBirth] [varchar](60) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plan]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[StudentID] [smallint] NOT NULL,
	[userID] [smallint] NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
 CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plate]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plate](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
	[idMenu] [smallint] NOT NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relationship_Student_Tutor]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relationship_Student_Tutor](
	[idStudent] [smallint] NOT NULL,
	[idTutor] [smallint] NOT NULL,
	[description] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [smallint] NOT NULL,
	[codStudent] [varchar](50) NOT NULL,
	[discapacity] [varchar](50) NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
	[idInstitution] [smallint] NULL,
	[courseID] [int] NULL,
 CONSTRAINT [PK_Student_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Menu]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Menu](
	[idStudent] [smallint] NOT NULL,
	[idMenu] [smallint] NOT NULL,
	[Days] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[id] [smallint] NOT NULL,
	[phone] [varchar](9) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tutor]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tutor](
	[id] [smallint] NOT NULL,
	[cellphone] [smallint] NOT NULL,
	[workPlace] [varchar](65) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[profession] [varchar](50) NOT NULL,
	[nit] [smallint] NOT NULL,
	[businessName] [varchar](50) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_Tutor_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/10/2023 16:44:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](12) NOT NULL,
	[password] [varbinary](35) NULL,
	[firstName] [varchar](60) NOT NULL,
	[LastName] [varchar](60) NOT NULL,
	[secondLastName] [varchar](60) NULL,
	[phone] [varchar](9) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[ci] [varchar](15) NOT NULL,
	[role] [varchar](15) NOT NULL,
	[status] [tinyint] NOT NULL,
	[registerDate] [datetime] NOT NULL,
	[lastUpdate] [datetime] NULL,
	[userID] [smallint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Area] ADD  CONSTRAINT [DF_Area_userID]  DEFAULT ((1)) FOR [userID]
GO
ALTER TABLE [dbo].[Asignature] ADD  CONSTRAINT [DF_Asignature_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Asignature] ADD  CONSTRAINT [DF_Asignature_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Asignature] ADD  CONSTRAINT [DF_Asignature_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Attorney] ADD  CONSTRAINT [DF_Attorney_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Attorney] ADD  CONSTRAINT [DF_Attorney_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Attorney] ADD  CONSTRAINT [DF_Attorney_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Ingrendient] ADD  CONSTRAINT [DF_Ingrendient_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Ingrendient] ADD  CONSTRAINT [DF_Ingrendient_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Institution] ADD  CONSTRAINT [DF_Institution_registrerDate]  DEFAULT (getdate()) FOR [registrerDate]
GO
ALTER TABLE [dbo].[Institution] ADD  CONSTRAINT [DF_Institution_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Institution] ADD  CONSTRAINT [DF_Institution_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Menu] ADD  CONSTRAINT [DF_Menu_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_Snack]  DEFAULT ((0)) FOR [Snack]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_userID]  DEFAULT ((1)) FOR [userID]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Payment] ADD  CONSTRAINT [DF_Payment_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_birthdate]  DEFAULT (getdate()) FOR [birthdate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_placeOfBirth]  DEFAULT ('') FOR [placeOfBirth]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Plan] ADD  CONSTRAINT [DF_Plan_userID]  DEFAULT ((1)) FOR [userID]
GO
ALTER TABLE [dbo].[Plan] ADD  CONSTRAINT [DF_Plan_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Plan] ADD  CONSTRAINT [DF_Plan_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Plan] ADD  CONSTRAINT [DF_Plan_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Plate] ADD  CONSTRAINT [DF_Plate_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Plate] ADD  CONSTRAINT [DF_Plate_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_discapacity]  DEFAULT ('') FOR [discapacity]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_idInstitution]  DEFAULT ((0)) FOR [idInstitution]
GO
ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_cellphone]  DEFAULT ('') FOR [cellphone]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_email]  DEFAULT ('') FOR [email]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_profession]  DEFAULT ('') FOR [profession]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_nit]  DEFAULT ('') FOR [nit]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_businessName]  DEFAULT ('') FOR [businessName]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[Tutor] ADD  CONSTRAINT [DF_Tutor_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_name]  DEFAULT ('') FOR [name]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_firstName]  DEFAULT ('') FOR [firstName]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_secondName]  DEFAULT ('') FOR [LastName]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_secondLastName]  DEFAULT ('') FOR [secondLastName]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_phone]  DEFAULT ((0)) FOR [phone]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_email]  DEFAULT ('') FOR [email]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_ci]  DEFAULT ('') FOR [ci]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_role]  DEFAULT ('') FOR [role]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_registerDate]  DEFAULT (getdate()) FOR [registerDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_lastUpdate]  DEFAULT (getdate()) FOR [lastUpdate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_userID]  DEFAULT ((0)) FOR [userID]
GO
ALTER TABLE [dbo].[Asignature]  WITH CHECK ADD  CONSTRAINT [FK_Asignature_Area] FOREIGN KEY([areaID])
REFERENCES [dbo].[Area] ([id])
GO
ALTER TABLE [dbo].[Asignature] CHECK CONSTRAINT [FK_Asignature_Area]
GO
ALTER TABLE [dbo].[Asignature]  WITH CHECK ADD  CONSTRAINT [FK_Asignature_Grade] FOREIGN KEY([idGrade])
REFERENCES [dbo].[Grade] ([id])
GO
ALTER TABLE [dbo].[Asignature] CHECK CONSTRAINT [FK_Asignature_Grade]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Grade] FOREIGN KEY([gradeID])
REFERENCES [dbo].[Grade] ([id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Grade]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([teacherID])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Grade]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Institution1] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institution] ([id])
GO
ALTER TABLE [dbo].[Grade] CHECK CONSTRAINT [FK_Grade_Institution1]
GO
ALTER TABLE [dbo].[Grade_Student]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student_Grade] FOREIGN KEY([idGrade])
REFERENCES [dbo].[Grade] ([id])
GO
ALTER TABLE [dbo].[Grade_Student] CHECK CONSTRAINT [FK_Grade_Student_Grade]
GO
ALTER TABLE [dbo].[Grade_Student]  WITH CHECK ADD  CONSTRAINT [FK_Grade_Student_Student] FOREIGN KEY([idStudent])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Grade_Student] CHECK CONSTRAINT [FK_Grade_Student_Student]
GO
ALTER TABLE [dbo].[Ingrendient]  WITH CHECK ADD  CONSTRAINT [FK_Ingrendient_Plate] FOREIGN KEY([idPlate])
REFERENCES [dbo].[Plate] ([id])
GO
ALTER TABLE [dbo].[Ingrendient] CHECK CONSTRAINT [FK_Ingrendient_Plate]
GO
ALTER TABLE [dbo].[Institution]  WITH CHECK ADD  CONSTRAINT [FK_Institution_City] FOREIGN KEY([idCity])
REFERENCES [dbo].[City] ([id])
GO
ALTER TABLE [dbo].[Institution] CHECK CONSTRAINT [FK_Institution_City]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Plan] FOREIGN KEY([PlanID])
REFERENCES [dbo].[Plan] ([id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Plan]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Tutor] FOREIGN KEY([TutorID])
REFERENCES [dbo].[Tutor] ([id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Tutor]
GO
ALTER TABLE [dbo].[Plan]  WITH CHECK ADD  CONSTRAINT [FK_Plan_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Plan] CHECK CONSTRAINT [FK_Plan_Student]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Menu]
GO
ALTER TABLE [dbo].[Relationship_Student_Tutor]  WITH CHECK ADD  CONSTRAINT [FK_Relationship_Student_Tutor_Student] FOREIGN KEY([idStudent])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Relationship_Student_Tutor] CHECK CONSTRAINT [FK_Relationship_Student_Tutor_Student]
GO
ALTER TABLE [dbo].[Relationship_Student_Tutor]  WITH CHECK ADD  CONSTRAINT [FK_Relationship_Student_Tutor_Tutor] FOREIGN KEY([idTutor])
REFERENCES [dbo].[Tutor] ([id])
GO
ALTER TABLE [dbo].[Relationship_Student_Tutor] CHECK CONSTRAINT [FK_Relationship_Student_Tutor_Tutor]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Course] FOREIGN KEY([courseID])
REFERENCES [dbo].[Course] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Course]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([id])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
ALTER TABLE [dbo].[Student_Menu]  WITH CHECK ADD  CONSTRAINT [FK_Student_Menu_Menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[Student_Menu] CHECK CONSTRAINT [FK_Student_Menu_Menu]
GO
ALTER TABLE [dbo].[Student_Menu]  WITH CHECK ADD  CONSTRAINT [FK_Student_Menu_Student] FOREIGN KEY([idStudent])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Student_Menu] CHECK CONSTRAINT [FK_Student_Menu_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Person] FOREIGN KEY([id])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Person]
GO
ALTER TABLE [dbo].[Tutor]  WITH CHECK ADD  CONSTRAINT [FK_Tutor_Person] FOREIGN KEY([id])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Tutor] CHECK CONSTRAINT [FK_Tutor_Person]
GO
USE [master]
GO
ALTER DATABASE [dbInstitution] SET  READ_WRITE 
GO
