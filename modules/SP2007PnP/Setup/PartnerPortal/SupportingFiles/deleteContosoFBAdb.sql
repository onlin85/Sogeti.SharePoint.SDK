USE [master]
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ContosoFBAdb')
EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'ContosoFBAdb'
GO
USE [master]
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ContosoFBAdb')
ALTER DATABASE [ContosoFBAdb] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ContosoFBAdb')
ALTER DATABASE [ContosoFBAdb] SET  SINGLE_USER 
GO
USE [master]
GO
/****** Object:  Database [ContosoFBAdb]    Script Date: 02/21/2009 02:49:14 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ContosoFBAdb')
DROP DATABASE [ContosoFBAdb]
GO
