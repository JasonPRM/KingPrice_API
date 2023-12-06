USE [master]
GO
/****** Object:  Database [KingPriceDB]    Script Date: 06/12/2023 13:12:27 ******/
CREATE DATABASE [KingPriceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KingPriceDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.LOCALHOST\MSSQL\DATA\KingPriceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KingPriceDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.LOCALHOST\MSSQL\DATA\KingPriceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [KingPriceDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KingPriceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KingPriceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KingPriceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KingPriceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KingPriceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KingPriceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KingPriceDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [KingPriceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KingPriceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KingPriceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KingPriceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KingPriceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KingPriceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KingPriceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KingPriceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KingPriceDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KingPriceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KingPriceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KingPriceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KingPriceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KingPriceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KingPriceDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [KingPriceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KingPriceDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KingPriceDB] SET  MULTI_USER 
GO
ALTER DATABASE [KingPriceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KingPriceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KingPriceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KingPriceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KingPriceDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KingPriceDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [KingPriceDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [KingPriceDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [KingPriceDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupPermissions]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupPermissions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NOT NULL,
	[PermissionsID] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_GroupPermissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perms]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perms](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_Perms] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGroups]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_UserGroups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/12/2023 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231206072659_Initial', N'8.0.0')
GO
SET IDENTITY_INSERT [dbo].[GroupPermissions] ON 
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (1, 1, 1, CAST(N'2023-12-06T09:26:58.9657732' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (2, 2, 1, CAST(N'2023-12-06T09:26:58.9657733' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (3, 3, 1, CAST(N'2023-12-06T09:26:58.9657734' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (4, 1, 2, CAST(N'2023-12-06T09:26:58.9657735' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (5, 2, 2, CAST(N'2023-12-06T09:26:58.9657736' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (6, 3, 2, CAST(N'2023-12-06T09:26:58.9657737' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (7, 1, 3, CAST(N'2023-12-06T09:26:58.9657738' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (8, 2, 3, CAST(N'2023-12-06T09:26:58.9657739' AS DateTime2), NULL)
GO
INSERT [dbo].[GroupPermissions] ([ID], [GroupID], [PermissionsID], [DateCreated], [DateUpdated]) VALUES (9, 3, 3, CAST(N'2023-12-06T09:26:58.9657740' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[GroupPermissions] OFF
GO
SET IDENTITY_INSERT [dbo].[Groups] ON 
GO
INSERT [dbo].[Groups] ([ID], [Name], [Description], [DateCreated], [DateUpdated]) VALUES (1, N'Group 1', N'Description for group 1', CAST(N'2023-12-06T09:26:58.9657689' AS DateTime2), NULL)
GO
INSERT [dbo].[Groups] ([ID], [Name], [Description], [DateCreated], [DateUpdated]) VALUES (2, N'Group 2', N'Description for group 2', CAST(N'2023-12-06T09:26:58.9657690' AS DateTime2), NULL)
GO
INSERT [dbo].[Groups] ([ID], [Name], [Description], [DateCreated], [DateUpdated]) VALUES (3, N'Group 3', N'Description for group 3', CAST(N'2023-12-06T09:26:58.9657691' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Groups] OFF
GO
SET IDENTITY_INSERT [dbo].[Perms] ON 
GO
INSERT [dbo].[Perms] ([ID], [Name], [DateCreated], [DateUpdated]) VALUES (1, N'Level 1', CAST(N'2023-12-06T09:26:58.9657550' AS DateTime2), NULL)
GO
INSERT [dbo].[Perms] ([ID], [Name], [DateCreated], [DateUpdated]) VALUES (2, N'Level 2', CAST(N'2023-12-06T09:26:58.9657565' AS DateTime2), NULL)
GO
INSERT [dbo].[Perms] ([ID], [Name], [DateCreated], [DateUpdated]) VALUES (3, N'Level 3', CAST(N'2023-12-06T09:26:58.9657566' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Perms] OFF
GO
SET IDENTITY_INSERT [dbo].[UserGroups] ON 
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (1, 1, 1, CAST(N'2023-12-06T09:26:58.9657762' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (2, 2, 1, CAST(N'2023-12-06T09:26:58.9657764' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (3, 3, 1, CAST(N'2023-12-06T09:26:58.9657807' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (4, 1, 2, CAST(N'2023-12-06T09:26:58.9657809' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (5, 2, 2, CAST(N'2023-12-06T09:26:58.9657810' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (6, 3, 2, CAST(N'2023-12-06T09:26:58.9657811' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (7, 1, 3, CAST(N'2023-12-06T09:26:58.9657812' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (8, 2, 3, CAST(N'2023-12-06T09:26:58.9657813' AS DateTime2), NULL)
GO
INSERT [dbo].[UserGroups] ([ID], [UserID], [GroupID], [DateCreated], [DateUpdated]) VALUES (9, 3, 3, CAST(N'2023-12-06T09:26:58.9657814' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[UserGroups] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (1, N'Jason2', N'Marques', N'test@gmail.com', CAST(N'2023-12-06T09:26:58.9657710' AS DateTime2), CAST(N'2023-12-06T11:31:51.5778826' AS DateTime2))
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (2, N'John', N'smith', N'test2@gmail.com', CAST(N'2023-12-06T09:26:58.9657712' AS DateTime2), NULL)
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (3, N'Jack', N'Mark', N'test3@gmail.com', CAST(N'2023-12-06T09:26:58.9657713' AS DateTime2), NULL)
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (4, N'test', N'test', N'test123@gmail.com', CAST(N'2023-12-06T11:37:04.4891134' AS DateTime2), CAST(N'2023-12-06T11:44:57.9578687' AS DateTime2))
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (5, N'Test', N'Test', N'Test20@gmail.com', CAST(N'2023-12-06T12:49:05.0438774' AS DateTime2), NULL)
GO
INSERT [dbo].[Users] ([ID], [Firstname], [Surname], [Email], [DateCreated], [DateUpdated]) VALUES (6, N'Test', N'Test', N'Test20@gmail.com', CAST(N'2023-12-06T12:53:18.7815194' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_GroupPermissions_GroupID]    Script Date: 06/12/2023 13:12:27 ******/
CREATE NONCLUSTERED INDEX [IX_GroupPermissions_GroupID] ON [dbo].[GroupPermissions]
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupPermissions_PermissionsID]    Script Date: 06/12/2023 13:12:27 ******/
CREATE NONCLUSTERED INDEX [IX_GroupPermissions_PermissionsID] ON [dbo].[GroupPermissions]
(
	[PermissionsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroups_GroupID]    Script Date: 06/12/2023 13:12:27 ******/
CREATE NONCLUSTERED INDEX [IX_UserGroups_GroupID] ON [dbo].[UserGroups]
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserGroups_UserID]    Script Date: 06/12/2023 13:12:27 ******/
CREATE NONCLUSTERED INDEX [IX_UserGroups_UserID] ON [dbo].[UserGroups]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GroupPermissions]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermissions_Groups_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupPermissions] CHECK CONSTRAINT [FK_GroupPermissions_Groups_GroupID]
GO
ALTER TABLE [dbo].[GroupPermissions]  WITH CHECK ADD  CONSTRAINT [FK_GroupPermissions_Perms_PermissionsID] FOREIGN KEY([PermissionsID])
REFERENCES [dbo].[Perms] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupPermissions] CHECK CONSTRAINT [FK_GroupPermissions_Perms_PermissionsID]
GO
ALTER TABLE [dbo].[UserGroups]  WITH CHECK ADD  CONSTRAINT [FK_UserGroups_Groups_GroupID] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGroups] CHECK CONSTRAINT [FK_UserGroups_Groups_GroupID]
GO
ALTER TABLE [dbo].[UserGroups]  WITH CHECK ADD  CONSTRAINT [FK_UserGroups_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGroups] CHECK CONSTRAINT [FK_UserGroups_Users_UserID]
GO
USE [master]
GO
ALTER DATABASE [KingPriceDB] SET  READ_WRITE 
GO
