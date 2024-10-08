USE [master]
GO
/****** Object:  Database [NewStoresSec]    Script Date: 12/15/2020 6:40:38 PM ******/
CREATE DATABASE [NewStoresSec]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NewStoresSec', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewStoresSec.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NewStoresSec_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\NewStoresSec_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NewStoresSec] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NewStoresSec].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NewStoresSec] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NewStoresSec] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NewStoresSec] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NewStoresSec] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NewStoresSec] SET ARITHABORT OFF 
GO
ALTER DATABASE [NewStoresSec] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NewStoresSec] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NewStoresSec] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NewStoresSec] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NewStoresSec] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NewStoresSec] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NewStoresSec] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NewStoresSec] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NewStoresSec] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NewStoresSec] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NewStoresSec] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NewStoresSec] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NewStoresSec] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NewStoresSec] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NewStoresSec] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NewStoresSec] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NewStoresSec] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NewStoresSec] SET RECOVERY FULL 
GO
ALTER DATABASE [NewStoresSec] SET  MULTI_USER 
GO
ALTER DATABASE [NewStoresSec] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NewStoresSec] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NewStoresSec] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NewStoresSec] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [NewStoresSec] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NewStoresSec', N'ON'
GO
USE [NewStoresSec]
GO
/****** Object:  User [admin]    Script Date: 12/15/2020 6:40:38 PM ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[Action]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Action](
	[ActionName] [nvarchar](100) NOT NULL,
	[Notes] [nchar](250) NULL,
 CONSTRAINT [PK_Action] PRIMARY KEY CLUSTERED 
(
	[ActionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserCode] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PassWord] [nvarchar](250) NULL,
	[Notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserActio]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserActio](
	[Name] [nvarchar](50) NULL,
	[ActionName] [nvarchar](100) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'أخذ نسخة من البيانات', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'أرباح المساهمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'أرباح مساهمين لم تحصل', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'إظهار إنشاء مستخدمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'إظهار تغيير كلمات مرور المستخدمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'إظهار صلاحيات المستخدمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'أقساط الشهر الحالى', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'أقساط تم سدادها', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الأصناف', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الأقساط', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'التقارير', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الخزينة', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'العاملين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'العملاء', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الفواتير', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'المجموعات', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'المخازن', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'المصانع', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'المصروفات', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'المناطق', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الموردين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'الوحدات', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'بيانات وإيداع المساهمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'تسديد أقساط كاش', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'حساب عميل', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'حساب مورد', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'شراءأجل', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'شراءنقدى', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'مرتجع شراء أجل', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'مرتجع شراء نقدى', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'مسحوبات المساهمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'مصروفات المساهمين', NULL)
INSERT [dbo].[Action] ([ActionName], [Notes]) VALUES (N'وظائف', NULL)
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserCode], [Name], [PassWord], [Notes]) VALUES (1, N'admin', N'fgcf2bAj7Y8YRYpzYToINPYiC9XMUDV7o0k8YECp6ow=', NULL)
INSERT [dbo].[User] ([UserCode], [Name], [PassWord], [Notes]) VALUES (1001, N'AA', N'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', N'')
INSERT [dbo].[User] ([UserCode], [Name], [PassWord], [Notes]) VALUES (1002, N'رانيا', N'T8grJq7LR9KGjE7741gXMqPny8xsLvsyBiwIFwoF7rg=', N'')
SET IDENTITY_INSERT [dbo].[User] OFF
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الخزينة')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'وظائف')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'العاملين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'المجموعات')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الوحدات')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'المصانع')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'أخذ نسخة من البيانات')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'أرباح المساهمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'أرباح مساهمين لم تحصل')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'إظهار إنشاء مستخدمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'إظهار تغيير كلمات مرور المستخدمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'إظهار صلاحيات المستخدمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'أقساط الشهر الحالى')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'أقساط تم سدادها')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الأصناف')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الأقساط')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'التقارير')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'العملاء')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الفواتير')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'المخازن')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'المصروفات')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'الموردين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'حساب عميل')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'حساب مورد')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'بيانات وإيداع المساهمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'تسديد أقساط كاش')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'مسحوبات المساهمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'مصروفات المساهمين')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'المناطق')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'شراءنقدى')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'شراءأجل')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'مرتجع شراء نقدى')
INSERT [dbo].[UserActio] ([Name], [ActionName]) VALUES (N'admin', N'مرتجع شراء أجل')
/****** Object:  StoredProcedure [dbo].[ActionInsetUpdate]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[ActionInsetUpdate]
@ActionName nvarchar(100),
@Notes nchar(250)
AS
declare @IsExist int = (select count(*) from [dbo].[Action] where [ActionName] = @ActionName)
if @IsExist = 0
begin
INSERT INTO [dbo].[Action]
           ([ActionName]
           ,[Notes])
     VALUES
           (@ActionName
           ,@Notes)
end
---------------------------------------------------------
else
begin
UPDATE [dbo].[Action]
set
      [Notes] = @Notes
 WHERE [ActionName] = @ActionName
end






GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChangePassword]
@Name nvarchar(100),
@password nchar(250)
AS
UPDATE [dbo].[User]
set
[PassWord] = @password
 WHERE [Name] = @Name






GO
/****** Object:  StoredProcedure [dbo].[CheckAction]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CheckAction]
@Name nvarchar (50),
@ActionName nvarchar(100)
AS
declare @result int
set @result =( SELECT Count(*)
FROM [dbo].[UserActio]
where Name = @Name and ActionName = @ActionName)
return @result






GO
/****** Object:  StoredProcedure [dbo].[SelectUserNameActions]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SelectUserNameActions]
@UserName nvarchar(50)
as
SELECT 
      [ActionName]
  FROM [dbo].[UserActio]
  where [dbo].[UserActio].Name =@UserName






GO
/****** Object:  StoredProcedure [dbo].[UserActioDelete]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UserActioDelete]
@Name nvarchar(50)
AS
delete dbo.UserActio where Name = @Name






GO
/****** Object:  StoredProcedure [dbo].[UserActioInser]    Script Date: 12/15/2020 6:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UserActioInser]
@Name nvarchar (50),
@ActionName nvarchar(100)
AS
insert into  dbo.UserActio ([Name],[ActionName])VALUES(@Name,@ActionName)






GO
USE [master]
GO
ALTER DATABASE [NewStoresSec] SET  READ_WRITE 
GO
