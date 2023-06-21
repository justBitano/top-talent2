USE [master]
GO
/****** Object:  Database [TopTalent2]    Script Date: 22/06/2023 3:06:03 SA ******/
CREATE DATABASE [TopTalent2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TopTalentNew', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TopTalentNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TopTalentNew_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TopTalentNew_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TopTalent2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TopTalent2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TopTalent2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TopTalent2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TopTalent2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TopTalent2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TopTalent2] SET ARITHABORT OFF 
GO
ALTER DATABASE [TopTalent2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TopTalent2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TopTalent2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TopTalent2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TopTalent2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TopTalent2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TopTalent2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TopTalent2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TopTalent2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TopTalent2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TopTalent2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TopTalent2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TopTalent2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TopTalent2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TopTalent2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TopTalent2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TopTalent2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TopTalent2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TopTalent2] SET  MULTI_USER 
GO
ALTER DATABASE [TopTalent2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TopTalent2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TopTalent2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TopTalent2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TopTalent2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TopTalent2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TopTalent2] SET QUERY_STORE = OFF
GO
USE [TopTalent2]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[booking_id] [int] IDENTITY(1,1) NOT NULL,
	[createDate] [datetime] NULL,
	[cash] [float] NOT NULL,
	[description] [nvarchar](500) NULL,
	[status] [int] NULL,
	[user_id] [int] NOT NULL,
	[talent_id] [int] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chat]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chat](
	[user_id] [int] NOT NULL,
	[talent_id] [int] NOT NULL,
	[message] [nvarchar](500) NOT NULL,
	[time] [datetime] NOT NULL,
 CONSTRAINT [PK_Chat] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[talent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[payment_id] [int] NOT NULL,
	[booking_id] [int] NOT NULL,
	[ammount] [float] NULL,
	[method] [nvarchar](50) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefershTokenUser]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefershTokenUser](
	[refersh_token] [int] NOT NULL,
	[user_id] [int] NULL,
	[token] [nvarchar](1000) NULL,
	[jwtId] [nvarchar](1000) NULL,
	[isUsed] [bit] NULL,
	[isRevoked] [bit] NULL,
	[issuedAt] [datetime] NULL,
	[expiredAt] [datetime] NULL,
 CONSTRAINT [PK_RefershTokenUser] PRIMARY KEY CLUSTERED 
(
	[refersh_token] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefreshTokenTalent]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefreshTokenTalent](
	[refresh_token_talent_id] [int] NOT NULL,
	[talent_id] [int] NULL,
	[token] [nvarchar](1000) NULL,
	[jwtId] [nvarchar](1000) NULL,
	[isUsed] [bit] NULL,
	[isRevoked] [bit] NULL,
	[issuedAt] [datetime] NULL,
	[expiredAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[review_id] [int] IDENTITY(1,1) NOT NULL,
	[booking_id] [int] NOT NULL,
	[text] [nvarchar](500) NULL,
	[rate] [int] NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[review_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Talent]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Talent](
	[talent_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullName] [nvarchar](50) NOT NULL,
	[phone] [int] NOT NULL,
	[address] [nvarchar](200) NULL,
	[jobTitle] [nvarchar](50) NULL,
	[price] [float] NULL,
	[image] [nvarchar](200) NULL,
	[description] [nvarchar](500) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_Talent] PRIMARY KEY CLUSTERED 
(
	[talent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 22/06/2023 3:06:03 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullName] [nvarchar](50) NULL,
	[phone] [int] NULL,
	[description] [nvarchar](500) NULL,
	[image] [nvarchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([booking_id], [createDate], [cash], [description], [status], [user_id], [talent_id]) VALUES (1, CAST(N'2023-06-19T00:00:00.000' AS DateTime), 950, N'Levent book bạn chụp 2 mẫu ảnh nha', NULL, 1, 1)
INSERT [dbo].[Booking] ([booking_id], [createDate], [cash], [description], [status], [user_id], [talent_id]) VALUES (3, CAST(N'2023-06-19T00:00:00.000' AS DateTime), 1000, N'Mình bên Coolmate muốn mời bạn chụp concept mùa xuân bên mình ,!', NULL, 2, 4)
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
INSERT [dbo].[RefershTokenUser] ([refersh_token], [user_id], [token], [jwtId], [isUsed], [isRevoked], [issuedAt], [expiredAt]) VALUES (0, NULL, N'KZmM4FuYbkfFCCFKPG1p2WE3Ak4QcGoB/+Lh8BLvE5s=', N'5d0880ba-8eea-4470-aab5-3ff22f7ed892', 0, 0, CAST(N'2023-06-21T15:07:03.817' AS DateTime), CAST(N'2023-06-21T16:07:03.817' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([review_id], [booking_id], [text], [rate]) VALUES (1, 1, N'Bạn này làm rất tốt. 10 điểm ', 5)
INSERT [dbo].[Review] ([review_id], [booking_id], [text], [rate]) VALUES (4, 3, N'Bạn này rất Ok . 9 dim 5', 5)
SET IDENTITY_INSERT [dbo].[Review] OFF
GO
SET IDENTITY_INSERT [dbo].[Talent] ON 

INSERT [dbo].[Talent] ([talent_id], [username], [password], [fullName], [phone], [address], [jobTitle], [price], [image], [description], [status]) VALUES (1, N'minayoung', N'minayoung123', N'Mina Young ', 91113344, NULL, N'Streamer', 1000, NULL, N'Streamer , Youtuber from Ba Ga With Love', NULL)
INSERT [dbo].[Talent] ([talent_id], [username], [password], [fullName], [phone], [address], [jobTitle], [price], [image], [description], [status]) VALUES (4, N'uyenphuong', N'uyenphuong123', N'Uyen Phuong', 91199999, NULL, N'KOL', 1000, NULL, N'Các nhãn hàng booking liên hệ qua instagram @uyenphuongggggg', NULL)
INSERT [dbo].[Talent] ([talent_id], [username], [password], [fullName], [phone], [address], [jobTitle], [price], [image], [description], [status]) VALUES (5, N'march', N'march123', N'Marchhhh', 9555555, NULL, N'KOL', 1000, NULL, N'@marchhhhh', NULL)
INSERT [dbo].[Talent] ([talent_id], [username], [password], [fullName], [phone], [address], [jobTitle], [price], [image], [description], [status]) VALUES (6, N'peter', N'peter123', N'Peter', 922222, NULL, N'Actor', 1000, NULL, N'Actor + KOL', NULL)
INSERT [dbo].[Talent] ([talent_id], [username], [password], [fullName], [phone], [address], [jobTitle], [price], [image], [description], [status]) VALUES (7, N'bobeo', N'bobeo123', N'Rambo', 961837669, N'string', N'Youtuber', 0, N'string', N'From Mixi With Love', 0)
SET IDENTITY_INSERT [dbo].[Talent] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [description], [image], [status]) VALUES (1, N'quockhanh1', N'quockhanh123', N'Le Quoc Khanh', 96123456, N'string', N'string', 0)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [description], [image], [status]) VALUES (2, N'minhthuan', N'minhthuan123', N'Hoang Minh Thuan', 9345555, NULL, NULL, NULL)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [description], [image], [status]) VALUES (4, N'luongdd', N'123', N'Dao Duc Luong 1', 961837769, N'string', N'string', 0)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [description], [image], [status]) VALUES (5, N'quochung', N'123', N'Dao Duc Hung', 961837768, N'string', N'string', 0)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [description], [image], [status]) VALUES (7, N'admin', N'admin123', N'Admin', NULL, NULL, NULL, 10)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Talent] FOREIGN KEY([talent_id])
REFERENCES [dbo].[Talent] ([talent_id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Talent]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_User]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_Talent] FOREIGN KEY([talent_id])
REFERENCES [dbo].[Talent] ([talent_id])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_Talent]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_User]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Booking] FOREIGN KEY([booking_id])
REFERENCES [dbo].[Booking] ([booking_id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Booking]
GO
ALTER TABLE [dbo].[RefershTokenUser]  WITH CHECK ADD  CONSTRAINT [FK_RefershTokenUser_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[RefershTokenUser] CHECK CONSTRAINT [FK_RefershTokenUser_User]
GO
ALTER TABLE [dbo].[RefreshTokenTalent]  WITH CHECK ADD  CONSTRAINT [FK_RefreshTokenTalent_Talent] FOREIGN KEY([talent_id])
REFERENCES [dbo].[Talent] ([talent_id])
GO
ALTER TABLE [dbo].[RefreshTokenTalent] CHECK CONSTRAINT [FK_RefreshTokenTalent_Talent]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Booking] FOREIGN KEY([booking_id])
REFERENCES [dbo].[Booking] ([booking_id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Booking]
GO
USE [master]
GO
ALTER DATABASE [TopTalent2] SET  READ_WRITE 
GO
