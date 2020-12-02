USE [master]
GO
/****** Object:  Database [Ventas]    Script Date: 01/12/2020 22:36:50 ******/
CREATE DATABASE [Ventas]
 WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS
GO
ALTER DATABASE [Ventas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ventas] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [Ventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ventas] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Ventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ventas] SET  MULTI_USER 
GO
ALTER DATABASE [Ventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ventas] SET ENCRYPTION ON
GO
ALTER DATABASE [Ventas] SET QUERY_STORE = ON
GO
ALTER DATABASE [Ventas] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [Ventas]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
USE [Ventas]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_diagramobjects]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [sysname] NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Cabecera_Venta]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Cabecera_Venta](
	[Id_venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_documento_venta] [int] NOT NULL,
	[Nun_serie_venta] [varchar](4) NULL,
	[Nun_correlativo_venta] [int] NULL,
	[Nun_documento_venta] [varchar](12) NOT NULL,
	[Fecha_emision] [datetime] NOT NULL,
	[Estado_Venta] [int] NOT NULL,
	[Id_cliente] [int] NOT NULL,
	[Id_moneda] [int] NOT NULL,
	[Id_Usuarios] [int] NOT NULL,
	[Observacion_venta] [varchar](50) NULL,
 CONSTRAINT [PK__Tb_Cabec__F077E880AFF3579B] PRIMARY KEY CLUSTERED 
(
	[Id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Categoria]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Categoria](
	[Id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_categoria] [varchar](50) NOT NULL,
	[Estado_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Cierre_Caja]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Cierre_Caja](
	[Id_close] [int] IDENTITY(1,1) NOT NULL,
	[Close_date] [datetime] NOT NULL,
	[Close_cash_sys] [decimal](8, 2) NOT NULL,
	[Close_cash_imp] [decimal](8, 2) NOT NULL,
	[Id_usuarios] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_close] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Clase]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Clase](
	[Id_Clase] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Clase] [varchar](50) NOT NULL,
	[Estado_Clase] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Clase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Cliente]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Cliente](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_cliente] [varchar](200) NOT NULL,
	[Apellido_cliente] [varchar](200) NOT NULL,
	[Id_documento_identidad] [int] NOT NULL,
	[Numero_Documento] [nvarchar](50) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](9) NULL,
 CONSTRAINT [PK__Tb_Clien__FCE039929453A794] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Deta_Producto]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Deta_Producto](
	[Id_Deta_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Deta_Producto] [varchar](50) NOT NULL,
	[Estado_Deta_Producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Deta_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Detalle_Venta]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Detalle_Venta](
	[Id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_producto] [int] NOT NULL,
	[Id_venta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Subtotal] [decimal](8, 2) NOT NULL,
	[IGV] [decimal](8, 2) NOT NULL,
	[Precio_venta] [decimal](8, 2) NOT NULL,
	[Importe_total] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK__Tb_Detal__AF4B6D7B12AF626F] PRIMARY KEY CLUSTERED 
(
	[Id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Documento_Identidad]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Documento_Identidad](
	[Id_documento_identidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_documento_identidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Documento_Venta]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Documento_Venta](
	[Id_documento_venta] [int] IDENTITY(1,1) NOT NULL,
	[Documento_venta] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Tb_Docum__1B1FAE10BD2C7459] PRIMARY KEY CLUSTERED 
(
	[Id_documento_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Empresa]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Empresa](
	[Id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial_empresa] [varchar](50) NULL,
	[Nombre_empresa] [varchar](50) NULL,
	[Ruc_empresa] [varchar](11) NULL,
	[Direccion_empresa] [varchar](50) NULL,
 CONSTRAINT [PK_Tb_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Estado]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Estado](
	[Id_Estado] [int] IDENTITY(0,1) NOT NULL,
	[Descripcion_Estado] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Log]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Log](
	[Id_log] [int] IDENTITY(1,1) NOT NULL,
	[Id_Usuarios] [int] NOT NULL,
	[Fecha_inicio_Log] [datetime] NOT NULL,
	[Fecha_fin_Log] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Moneda]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Moneda](
	[Id_moneda] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_moneda] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_moneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Productos]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Productos](
	[Id_producto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_producto] [varchar](20) NOT NULL,
	[Nombre_producto] [varchar](100) NOT NULL,
	[Precio_producto] [decimal](8, 2) NOT NULL,
	[Estado_producto] [int] NOT NULL,
	[Stock_producto] [int] NOT NULL,
	[Id_Categoria] [int] NOT NULL,
	[Id_Deta_Producto] [int] NOT NULL,
	[Id_Clase] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tb_Usuarios]    Script Date: 01/12/2020 22:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tb_Usuarios](
	[Id_usuarios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_user] [varchar](50) NOT NULL,
	[Apellido_user] [varchar](50) NOT NULL,
	[Nickname_user] [varchar](10) NOT NULL,
	[Password_user] [varchar](16) NOT NULL,
	[Correo_user] [varchar](100) NULL,
	[Id_cargo] [int] NOT NULL,
	[Estado_user] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tb_Cabecera_Venta] ON 

INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (1, 1, N'B001', 1, N'B001-0001', CAST(N'2020-11-29T00:00:00.000' AS DateTime), 1, 1, 1, 1, N'ventita')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (2, 2, N'F001', 1, N'F001-0001', CAST(N'2020-11-29T00:00:00.000' AS DateTime), 1, 1, 1, 1, N'vent')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (3, 1, N'B001', 2, N'B001-0002', CAST(N'2020-11-30T00:00:00.000' AS DateTime), 1, 1, 1, 1, NULL)
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (4, 2, N'F001', 2, N'F001-0002', CAST(N'2020-11-30T22:53:13.000' AS DateTime), 1, 1, 1, 1, NULL)
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (6, 1, N'B001', 3, N'B001 - 0003', CAST(N'2020-12-01T00:05:06.000' AS DateTime), 1, 5, 1, 15, N'xd')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (7, 2, N'F001', 3, N'F001-0003', CAST(N'2020-12-01T02:02:50.000' AS DateTime), 1, 13, 1, 15, N'xddd')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (8, 1, N'B001', 4, N'B001-0004', CAST(N'2020-12-01T02:53:49.000' AS DateTime), 1, 14, 1, 15, N'quiero dormir rctmr')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (9, 1, N'B001', 5, N'B001-0005', CAST(N'2020-12-01T17:32:05.000' AS DateTime), 1, 14, 1, 1, N'xddd')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (10, 2, N'F001', 4, N'F001-0004', CAST(N'2020-12-01T17:36:30.000' AS DateTime), 1, 15, 1, 1, N'miraflores')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (11, 1, N'B001', 6, N'B001-0006', CAST(N'2020-12-01T19:30:07.000' AS DateTime), 1, 15, 1, 1, N'xddddd')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (12, 1, N'B001', 7, N'B001-0007', CAST(N'2020-12-01T19:37:19.000' AS DateTime), 1, 15, 1, 1, N'xddd')
INSERT [dbo].[Tb_Cabecera_Venta] ([Id_venta], [Id_documento_venta], [Nun_serie_venta], [Nun_correlativo_venta], [Nun_documento_venta], [Fecha_emision], [Estado_Venta], [Id_cliente], [Id_moneda], [Id_Usuarios], [Observacion_venta]) VALUES (13, 1, N'B001', 8, N'B001-0008', CAST(N'2020-12-01T20:21:13.000' AS DateTime), 1, 16, 1, 1, N'')
SET IDENTITY_INSERT [dbo].[Tb_Cabecera_Venta] OFF
SET IDENTITY_INSERT [dbo].[Tb_Categoria] ON 

INSERT [dbo].[Tb_Categoria] ([Id_categoria], [Nombre_categoria], [Estado_categoria]) VALUES (1, N'Refrescos', 1)
INSERT [dbo].[Tb_Categoria] ([Id_categoria], [Nombre_categoria], [Estado_categoria]) VALUES (2, N'utiles', 1)
INSERT [dbo].[Tb_Categoria] ([Id_categoria], [Nombre_categoria], [Estado_categoria]) VALUES (4, N'frutos secos', 0)
INSERT [dbo].[Tb_Categoria] ([Id_categoria], [Nombre_categoria], [Estado_categoria]) VALUES (5, N'Masa1', 1)
SET IDENTITY_INSERT [dbo].[Tb_Categoria] OFF
SET IDENTITY_INSERT [dbo].[Tb_Clase] ON 

INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (1, N'Gaseosa', 1)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (2, N'cafe', 1)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (3, N'churro', 0)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (4, N'cacao', 0)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (5, N'frutos secos', 1)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (6, N'Pastel', 1)
INSERT [dbo].[Tb_Clase] ([Id_Clase], [Nombre_Clase], [Estado_Clase]) VALUES (7, N'pan', 1)
SET IDENTITY_INSERT [dbo].[Tb_Clase] OFF
SET IDENTITY_INSERT [dbo].[Tb_Cliente] ON 

INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (1, N'Abdon', N'Gutierrez', 1, N'70980090', N'SJM', N'955235138')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (5, N'RENATO', N'RENATO2', 1, N'123456', N'ASD', N'123')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (7, N'JUAN', N'VENTURA', 1, N'1234567', N'SJM', N'99999999')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (8, N'ANGEL', N'GUTIERREZ', 1, N'70980090', N'SJM', N'95563')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (9, N'sara', N'mujer', 2, N'987654321', N'molina', N'123456789')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (12, N'feliciano', N'allccarima', 1, N'70980090', N'miraflores', N'987654321')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (13, N'FERRINDUSTRIAL S.A.C.', N'-', 2, N'20600116518', N'CAL.PISCOBAMBA NRO. 1632 URB. LOS NARANJOS LIMA - LIMA - LOS OLIVOS', N'')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (14, N'CORPORACION CARMINA SAC', N'-', 2, N'20601155185', N'CAL.LOS MOJAVES NRO. 278 SALAMANCA (ALT CDRA 9 DE AV LOS PARACAS SALAMANCA) LIMA - LIMA - ATE', N'')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (15, N'MODAS LOREN EIRL', N'-', 2, N'20543248984', N'AV. JOSE GRANDA NRO. 3884 UPOP CONDEVILLA DEL SEÑOR LIMA - LIMA - SAN MARTIN DE PORRES', N'')
INSERT [dbo].[Tb_Cliente] ([Id_cliente], [Nombre_cliente], [Apellido_cliente], [Id_documento_identidad], [Numero_Documento], [Direccion], [Telefono]) VALUES (16, N'BANCO BBVA PERU', N'BBVA', 2, N'20100130204', N'AV. REP DE PANAMA NRO. 3055 URB. EL PALOMAR LIMA - LIMA - SAN ISIDRO', N'')
SET IDENTITY_INSERT [dbo].[Tb_Cliente] OFF
SET IDENTITY_INSERT [dbo].[Tb_Deta_Producto] ON 

INSERT [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]) VALUES (1, N'3 Litros', 1)
INSERT [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]) VALUES (2, N'2 Litros', 1)
INSERT [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]) VALUES (3, N'1 Litro', 1)
INSERT [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]) VALUES (4, N'Chocolate', 1)
INSERT [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]) VALUES (5, N'Vainilla', 1)
SET IDENTITY_INSERT [dbo].[Tb_Deta_Producto] OFF
SET IDENTITY_INSERT [dbo].[Tb_Detalle_Venta] ON 

INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (1, 1, 1, 3, CAST(40.00 AS Decimal(8, 2)), CAST(7.20 AS Decimal(8, 2)), CAST(47.20 AS Decimal(8, 2)), CAST(141.60 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (2, 1, 2, 7, CAST(10.00 AS Decimal(8, 2)), CAST(1.80 AS Decimal(8, 2)), CAST(11.80 AS Decimal(8, 2)), CAST(82.60 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (3, 1, 3, 2, CAST(5.00 AS Decimal(8, 2)), CAST(0.90 AS Decimal(8, 2)), CAST(5.90 AS Decimal(8, 2)), CAST(11.80 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (4, 1, 4, 10, CAST(3.50 AS Decimal(8, 2)), CAST(0.63 AS Decimal(8, 2)), CAST(4.13 AS Decimal(8, 2)), CAST(41.30 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (5, 1, 6, 2, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(22.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (6, 1, 6, 4, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(44.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (7, 2, 6, 6, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(12.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (8, 1, 7, 2, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(22.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (9, 1, 7, 5, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(55.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (10, 2, 7, 8, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(16.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (11, 2, 7, 1, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (12, 1, 8, 2, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(22.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (13, 1, 8, 3, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(33.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (14, 2, 8, 4, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(8.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (15, 2, 8, 1, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (16, 2, 9, 5, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(10.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (17, 1, 9, 10, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(110.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (18, 2, 9, 30, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(60.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (19, 1, 10, 5, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(55.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (20, 2, 10, 3, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(6.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (21, 1, 10, 4, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(44.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (22, 1, 10, 11, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(121.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (23, 1, 11, 1, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (24, 2, 11, 1, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (25, 1, 12, 2, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(22.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (26, 2, 12, 4, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(8.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (27, 1, 13, 5, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(55.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (28, 2, 13, 7, CAST(1.69 AS Decimal(8, 2)), CAST(0.30 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(14.00 AS Decimal(8, 2)))
INSERT [dbo].[Tb_Detalle_Venta] ([Id_detalle_venta], [Id_producto], [Id_venta], [Cantidad], [Subtotal], [IGV], [Precio_venta], [Importe_total]) VALUES (29, 1, 13, 11, CAST(9.32 AS Decimal(8, 2)), CAST(1.68 AS Decimal(8, 2)), CAST(11.00 AS Decimal(8, 2)), CAST(121.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Tb_Detalle_Venta] OFF
SET IDENTITY_INSERT [dbo].[Tb_Documento_Identidad] ON 

INSERT [dbo].[Tb_Documento_Identidad] ([Id_documento_identidad], [Descripcion]) VALUES (1, N'DNI')
INSERT [dbo].[Tb_Documento_Identidad] ([Id_documento_identidad], [Descripcion]) VALUES (2, N'RUC')
SET IDENTITY_INSERT [dbo].[Tb_Documento_Identidad] OFF
SET IDENTITY_INSERT [dbo].[Tb_Documento_Venta] ON 

INSERT [dbo].[Tb_Documento_Venta] ([Id_documento_venta], [Documento_venta]) VALUES (1, N'BOLETA DE VENTA ELECTRONICA')
INSERT [dbo].[Tb_Documento_Venta] ([Id_documento_venta], [Documento_venta]) VALUES (2, N'FACTURA ELECTRONICA')
SET IDENTITY_INSERT [dbo].[Tb_Documento_Venta] OFF
SET IDENTITY_INSERT [dbo].[Tb_Empresa] ON 

INSERT [dbo].[Tb_Empresa] ([Id_empresa], [RazonSocial_empresa], [Nombre_empresa], [Ruc_empresa], [Direccion_empresa]) VALUES (1, N'PEPITO S.A.C.', N'PEPE LUCHO', N'20147589571', N'CAL GONXA 247 LT26 MZ 4 LOS OLIVOS')
SET IDENTITY_INSERT [dbo].[Tb_Empresa] OFF
SET IDENTITY_INSERT [dbo].[Tb_Estado] ON 

INSERT [dbo].[Tb_Estado] ([Id_Estado], [Descripcion_Estado]) VALUES (0, N'Inactivo')
INSERT [dbo].[Tb_Estado] ([Id_Estado], [Descripcion_Estado]) VALUES (1, N'Disponible')
SET IDENTITY_INSERT [dbo].[Tb_Estado] OFF
SET IDENTITY_INSERT [dbo].[Tb_Moneda] ON 

INSERT [dbo].[Tb_Moneda] ([Id_moneda], [Tipo_moneda]) VALUES (1, N'NUEVOS SOLES')
SET IDENTITY_INSERT [dbo].[Tb_Moneda] OFF
SET IDENTITY_INSERT [dbo].[Tb_Productos] ON 

INSERT [dbo].[Tb_Productos] ([Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]) VALUES (1, N'COCA2', N'Coca-Cola', CAST(11.00 AS Decimal(8, 2)), 1, 1, 1, 1, 1)
INSERT [dbo].[Tb_Productos] ([Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]) VALUES (2, N'gga', N'prueba', CAST(2.00 AS Decimal(8, 2)), 1, 1, 2, 1, 3)
INSERT [dbo].[Tb_Productos] ([Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]) VALUES (3, N'pruena', N'prueba3', CAST(11.00 AS Decimal(8, 2)), 0, 1, 1, 1, 1)
INSERT [dbo].[Tb_Productos] ([Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]) VALUES (4, N'sipanes', N'pan frances', CAST(2.00 AS Decimal(8, 2)), 0, 10, 5, 4, 7)
SET IDENTITY_INSERT [dbo].[Tb_Productos] OFF
SET IDENTITY_INSERT [dbo].[Tb_Usuarios] ON 

INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (1, N'Abdon', N'Gutierrez', N'Abdon', N'123', N'Abdon@gmail.com', 1, 1)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (2, N'asd', N'asd', N'asd', N'123', N'asd', 1, 2)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (3, N'XD', N'XD', N'XD', N'1', N'XD', 1, 2)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (11, N'@nombre', N'@apellido', N'@usuario', N'@password', N'@correo', 2, 0)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (12, N'@nombre', N'@apellido', N'@usuario', N'@password', N'@correo', 1, 0)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (13, N'abdon', N'abdon', N'abdon', N'345', N'abdon', 1, 0)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (14, N'juan', N'juan', N'juan', N'123', N'juan', 1, 2)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (15, N'manuel', N'manuel', N'manuel', N'456', N'manuel', 1, 1)
INSERT [dbo].[Tb_Usuarios] ([Id_usuarios], [Nombre_user], [Apellido_user], [Nickname_user], [Password_user], [Correo_user], [Id_cargo], [Estado_user]) VALUES (16, N'Miguel', N'De La Rivera', N'Mufasa', N'123', N'samuraidotatame@gmail.com', 1, 1)
SET IDENTITY_INSERT [dbo].[Tb_Usuarios] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_principal_name]    Script Date: 01/12/2020 22:37:05 ******/
ALTER TABLE [dbo].[sysdiagrams] ADD  CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED 
(
	[principal_id] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta] ADD  CONSTRAINT [DF__Tb_Cabece__Estad__75A278F5]  DEFAULT ((1)) FOR [Estado_Venta]
GO
ALTER TABLE [dbo].[Tb_Categoria] ADD  DEFAULT ((1)) FOR [Estado_categoria]
GO
ALTER TABLE [dbo].[Tb_Clase] ADD  DEFAULT ((1)) FOR [Estado_Clase]
GO
ALTER TABLE [dbo].[Tb_Deta_Producto] ADD  DEFAULT ((1)) FOR [Estado_Deta_Producto]
GO
ALTER TABLE [dbo].[Tb_Detalle_Venta] ADD  CONSTRAINT [DF__Tb_Detalle___IGV__797309D9]  DEFAULT ((18)) FOR [IGV]
GO
ALTER TABLE [dbo].[Tb_Productos] ADD  DEFAULT ((1)) FOR [Estado_producto]
GO
ALTER TABLE [dbo].[Tb_Productos] ADD  DEFAULT ((0)) FOR [Stock_producto]
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Cliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Tb_Cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta] CHECK CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Cliente]
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Documento_Venta] FOREIGN KEY([Id_documento_venta])
REFERENCES [dbo].[Tb_Documento_Venta] ([Id_documento_venta])
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta] CHECK CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Documento_Venta]
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Moneda] FOREIGN KEY([Id_moneda])
REFERENCES [dbo].[Tb_Moneda] ([Id_moneda])
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta] CHECK CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Moneda]
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Usuarios] FOREIGN KEY([Id_Usuarios])
REFERENCES [dbo].[Tb_Usuarios] ([Id_usuarios])
GO
ALTER TABLE [dbo].[Tb_Cabecera_Venta] CHECK CONSTRAINT [FK_Tb_Cabecera_Venta_Tb_Usuarios]
GO
ALTER TABLE [dbo].[Tb_Categoria]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Categoria_Tb_Estado] FOREIGN KEY([Estado_categoria])
REFERENCES [dbo].[Tb_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[Tb_Categoria] CHECK CONSTRAINT [FK_Tb_Categoria_Tb_Estado]
GO
ALTER TABLE [dbo].[Tb_Cierre_Caja]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cierre_Caja_Tb_Usuarios] FOREIGN KEY([Id_usuarios])
REFERENCES [dbo].[Tb_Usuarios] ([Id_usuarios])
GO
ALTER TABLE [dbo].[Tb_Cierre_Caja] CHECK CONSTRAINT [FK_Tb_Cierre_Caja_Tb_Usuarios]
GO
ALTER TABLE [dbo].[Tb_Clase]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Clase_Tb_Estado] FOREIGN KEY([Estado_Clase])
REFERENCES [dbo].[Tb_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[Tb_Clase] CHECK CONSTRAINT [FK_Tb_Clase_Tb_Estado]
GO
ALTER TABLE [dbo].[Tb_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Cliente_Tb_Documeto_Identidad] FOREIGN KEY([Id_documento_identidad])
REFERENCES [dbo].[Tb_Documento_Identidad] ([Id_documento_identidad])
GO
ALTER TABLE [dbo].[Tb_Cliente] CHECK CONSTRAINT [FK_Tb_Cliente_Tb_Documeto_Identidad]
GO
ALTER TABLE [dbo].[Tb_Deta_Producto]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Deta_Producto_Tb_Estado] FOREIGN KEY([Estado_Deta_Producto])
REFERENCES [dbo].[Tb_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[Tb_Deta_Producto] CHECK CONSTRAINT [FK_Tb_Deta_Producto_Tb_Estado]
GO
ALTER TABLE [dbo].[Tb_Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Detalle_Venta_Tb_Cabecera_Venta] FOREIGN KEY([Id_venta])
REFERENCES [dbo].[Tb_Cabecera_Venta] ([Id_venta])
GO
ALTER TABLE [dbo].[Tb_Detalle_Venta] CHECK CONSTRAINT [FK_Tb_Detalle_Venta_Tb_Cabecera_Venta]
GO
ALTER TABLE [dbo].[Tb_Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Detalle_Venta_Tb_Producto] FOREIGN KEY([Id_producto])
REFERENCES [dbo].[Tb_Productos] ([Id_producto])
GO
ALTER TABLE [dbo].[Tb_Detalle_Venta] CHECK CONSTRAINT [FK_Tb_Detalle_Venta_Tb_Producto]
GO
ALTER TABLE [dbo].[Tb_Log]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Log_Tb_Usuarios] FOREIGN KEY([Id_Usuarios])
REFERENCES [dbo].[Tb_Usuarios] ([Id_usuarios])
GO
ALTER TABLE [dbo].[Tb_Log] CHECK CONSTRAINT [FK_Tb_Log_Tb_Usuarios]
GO
ALTER TABLE [dbo].[Tb_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Productos_Tb_Categoria] FOREIGN KEY([Id_Categoria])
REFERENCES [dbo].[Tb_Categoria] ([Id_categoria])
GO
ALTER TABLE [dbo].[Tb_Productos] CHECK CONSTRAINT [FK_Tb_Productos_Tb_Categoria]
GO
ALTER TABLE [dbo].[Tb_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Productos_Tb_Estado] FOREIGN KEY([Estado_producto])
REFERENCES [dbo].[Tb_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[Tb_Productos] CHECK CONSTRAINT [FK_Tb_Productos_Tb_Estado]
GO
ALTER TABLE [dbo].[Tb_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Productos_Tb_Marca] FOREIGN KEY([Id_Clase])
REFERENCES [dbo].[Tb_Clase] ([Id_Clase])
GO
ALTER TABLE [dbo].[Tb_Productos] CHECK CONSTRAINT [FK_Tb_Productos_Tb_Marca]
GO
ALTER TABLE [dbo].[Tb_Productos]  WITH CHECK ADD  CONSTRAINT [FK_Tb_Productos_Tb_Modelo] FOREIGN KEY([Id_Deta_Producto])
REFERENCES [dbo].[Tb_Deta_Producto] ([Id_Deta_Producto])
GO
ALTER TABLE [dbo].[Tb_Productos] CHECK CONSTRAINT [FK_Tb_Productos_Tb_Modelo]
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_CategoriaList]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
CREATE PROCEDURE [dbo].[crud_Tb_CategoriaList]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT [Id_categoria], [Nombre_categoria], [Estado_categoria]
	FROM [dbo].[Tb_Categoria]

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ClaseList]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
CREATE PROCEDURE [dbo].[crud_Tb_ClaseList]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT [Id_Clase], [Nombre_Clase], [Estado_Clase]
	FROM [dbo].[Tb_Clase]
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_Deta_ProductoList]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
CREATE PROCEDURE [dbo].[crud_Tb_Deta_ProductoList]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT [Id_Deta_Producto], [Nombre_Deta_Producto], [Estado_Deta_Producto]
	FROM [dbo].[Tb_Deta_Producto]

	COMMIT

GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_EstadoList]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[crud_Tb_EstadoList]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT [Id_Estado], [Descripcion_Estado]
	FROM [dbo].[Tb_Estado]

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosDelete]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crud_Tb_ProductosDelete]
		@Id_producto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM [dbo].[Tb_Productos]
		WHERE ([Id_producto] = @Id_producto)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosDisable]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[crud_Tb_ProductosDisable]
		@Id_producto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
	UPDATE [dbo].[Tb_Productos]
	SET [Estado_producto] = 0
	WHERE ([Id_producto] = @Id_producto)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosInsert]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crud_Tb_ProductosInsert]
	(
		@Codigo_producto [varchar](20),
		@Nombre_producto [varchar](100),
		@Precio_producto [decimal](8, 2),
		@Estado_producto [int],
		@Stock_producto [int],
		@Id_Categoria [int],
		@Id_Deta_Producto [int],
		@Id_Clase [int]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO [dbo].[Tb_Productos]
	(
		[Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]
	)
	VALUES
	(
		@Codigo_producto,
		@Nombre_producto,
		@Precio_producto,
		@Estado_producto,
		@Stock_producto,
		@Id_Categoria,
		@Id_Deta_Producto,
		@Id_Clase

	)

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosListBruto]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[crud_Tb_ProductosListBruto]
AS
SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
	SELECT [Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]
	FROM [dbo].[Tb_Productos]
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosListPulido]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[crud_Tb_ProductosListPulido]
AS
SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
	SELECT pr.[Id_producto], pr.[Codigo_producto] AS 'Codigo de Producto', pr.[Nombre_producto] AS 'Nombre de Producto', cat.Nombre_categoria AS 'Categoria del producto', cla.Nombre_Clase AS 'Clase del producto', dep.Nombre_Deta_Producto AS 'Detalle del producto', pr.[Precio_producto], pr.[Stock_producto] AS 'Stock del producto', REPLACE(es.Descripcion_Estado,'Inactivo','No Disponible') AS 'Disponibilidad'
	FROM [dbo].[Tb_Productos] pr, dbo.Tb_Estado es, dbo.Tb_Categoria cat, dbo.Tb_Deta_Producto deP, dbo.Tb_Clase AS cla
	WHERE (pr.Estado_producto = es.Id_Estado AND pr.Id_Categoria = cat.Id_categoria AND pr.Id_Deta_Producto = deP.Id_Deta_Producto AND pr.Id_Clase = cla.Id_Clase)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosSelect]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crud_Tb_ProductosSelect]
		@Id_producto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT [Id_producto], [Codigo_producto], [Nombre_producto], [Precio_producto], [Estado_producto], [Stock_producto], [Id_Categoria], [Id_Deta_Producto], [Id_Clase]
	FROM [dbo].[Tb_Productos]
	WHERE ([Id_producto] = @Id_producto)

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[crud_Tb_ProductosUpdate]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[crud_Tb_ProductosUpdate]
	(
		@Id_producto [int],
		@Codigo_producto [varchar](20),
		@Nombre_producto [varchar](100),
		@Precio_producto [decimal](8, 2),
		@Estado_producto [int],
		@Stock_producto [int],
		@Id_Categoria [int],
		@Id_Deta_Producto [int],
		@Id_Clase [int]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE [dbo].[Tb_Productos]
		SET [Codigo_producto] = @Codigo_producto, [Nombre_producto] = @Nombre_producto, [Precio_producto] = @Precio_producto, [Estado_producto] = @Estado_producto, [Stock_producto] = @Stock_producto, [Id_Categoria] = @Id_Categoria, [Id_Deta_Producto] = @Id_Deta_Producto, [Id_Clase] = @Id_Clase
		WHERE ([Id_producto] = @Id_producto)
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[sp_alterdiagram]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_creatediagram]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_dropdiagram]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagramdefinition]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagrams]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_renamediagram]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_upgraddiagrams]    Script Date: 01/12/2020 22:37:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	
GO
EXEC sys.sp_addextendedproperty @name=N'microsoft_database_tools_support', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sysdiagrams'
GO
USE [master]
GO
ALTER DATABASE [Ventas] SET  READ_WRITE 
GO
