USE [master]
GO
/****** Object:  Database [db_EcoRecicla]    Script Date: 1/06/2025 00:17:20 ******/
CREATE DATABASE [db_EcoRecicla]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_EcoRecicla', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_EcoRecicla.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_EcoRecicla_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_EcoRecicla_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_EcoRecicla] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_EcoRecicla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_EcoRecicla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_EcoRecicla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_EcoRecicla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_EcoRecicla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_EcoRecicla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET RECOVERY FULL 
GO
ALTER DATABASE [db_EcoRecicla] SET  MULTI_USER 
GO
ALTER DATABASE [db_EcoRecicla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_EcoRecicla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_EcoRecicla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_EcoRecicla] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_EcoRecicla] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_EcoRecicla] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_EcoRecicla', N'ON'
GO
ALTER DATABASE [db_EcoRecicla] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_EcoRecicla] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_EcoRecicla]
GO
/****** Object:  Table [dbo].[Asignacion]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignacion](
	[AsignacionID] [int] IDENTITY(1,1) NOT NULL,
	[OrdenID] [int] NULL,
	[VehiculoID] [int] NULL,
	[ConductorID] [int] NULL,
	[TurnoID] [int] NOT NULL,
	[FechaAsignacion] [datetime] NOT NULL,
 CONSTRAINT [PK__Asignaci__D82B5BB7FF0FC470] PRIMARY KEY CLUSTERED 
(
	[AsignacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[RUC] [varchar](20) NULL,
	[Direccion] [varchar](200) NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conductor]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conductor](
	[ConductorID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[DNI] [varchar](20) NULL,
	[Licencia] [varchar](20) NULL,
	[Direccion] [varchar](200) NULL,
	[Telefono] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Estado] [bit] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ConductorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoOrden]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoOrden](
	[EstadoOrdenID] [int] IDENTITY(1,1) NOT NULL,
	[NombreEstado] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoOrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogInicioSesion]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogInicioSesion](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioID] [int] NULL,
	[FechaHora] [datetime] NULL,
	[DireccionIP] [varchar](45) NULL,
	[Exito] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenRecojo]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenRecojo](
	[OrdenID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NULL,
	[FechaSolicitud] [datetime] NOT NULL,
	[FechaRecojo] [date] NULL,
	[Horario] [varchar](20) NULL,
	[EstadoOrdenID] [int] NULL,
	[TipoResiduoID] [int] NULL,
	[Cantidad] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoResiduo]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoResiduo](
	[TipoResiduoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Clasificacion] [varchar](50) NULL,
	[Descripcion] [text] NULL,
	[RequiereManejoEspecial] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TipoResiduoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[TurnoID] [int] IDENTITY(1,1) NOT NULL,
	[HorarioInicio] [time](7) NOT NULL,
	[HorarioFin] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TurnoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[ContraseñaHash] [varchar](255) NOT NULL,
	[RolID] [int] NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioCliente]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioCliente](
	[UsuarioClienteID] [int] IDENTITY(1,1) NOT NULL,
	[UsuarioID] [int] NULL,
	[ClienteID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 1/06/2025 00:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[VehiculoID] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [varchar](20) NOT NULL,
	[Marca] [varchar](20) NULL,
	[Modelo] [varchar](20) NULL,
	[TipoVehiculo] [varchar](50) NULL,
	[CapacidadTotal] [decimal](10, 2) NULL,
	[Disponible] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[VehiculoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [Asignacion_index_5]    Script Date: 1/06/2025 00:17:20 ******/
CREATE NONCLUSTERED INDEX [Asignacion_index_5] ON [dbo].[Asignacion]
(
	[OrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [OrdenRecojo_index_2]    Script Date: 1/06/2025 00:17:20 ******/
CREATE NONCLUSTERED INDEX [OrdenRecojo_index_2] ON [dbo].[OrdenRecojo]
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Usuario_index_0]    Script Date: 1/06/2025 00:17:20 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Usuario_index_0] ON [dbo].[Usuario]
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UsuarioCliente_index_1]    Script Date: 1/06/2025 00:17:20 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UsuarioCliente_index_1] ON [dbo].[UsuarioCliente]
(
	[UsuarioID] ASC,
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Vehiculo_index_4]    Script Date: 1/06/2025 00:17:20 ******/
CREATE UNIQUE NONCLUSTERED INDEX [Vehiculo_index_4] ON [dbo].[Vehiculo]
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Conductor] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Conductor] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[LogInicioSesion] ADD  DEFAULT (getdate()) FOR [FechaHora]
GO
ALTER TABLE [dbo].[TipoResiduo] ADD  DEFAULT ((0)) FOR [RequiereManejoEspecial]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Vehiculo] ADD  DEFAULT ((1)) FOR [Disponible]
GO
ALTER TABLE [dbo].[Asignacion]  WITH CHECK ADD  CONSTRAINT [FK__Asignacio__Condu__5EBF139D] FOREIGN KEY([ConductorID])
REFERENCES [dbo].[Conductor] ([ConductorID])
GO
ALTER TABLE [dbo].[Asignacion] CHECK CONSTRAINT [FK__Asignacio__Condu__5EBF139D]
GO
ALTER TABLE [dbo].[Asignacion]  WITH CHECK ADD  CONSTRAINT [FK__Asignacio__Orden__5CD6CB2B] FOREIGN KEY([OrdenID])
REFERENCES [dbo].[OrdenRecojo] ([OrdenID])
GO
ALTER TABLE [dbo].[Asignacion] CHECK CONSTRAINT [FK__Asignacio__Orden__5CD6CB2B]
GO
ALTER TABLE [dbo].[Asignacion]  WITH CHECK ADD  CONSTRAINT [FK__Asignacio__Vehic__5DCAEF64] FOREIGN KEY([VehiculoID])
REFERENCES [dbo].[Vehiculo] ([VehiculoID])
GO
ALTER TABLE [dbo].[Asignacion] CHECK CONSTRAINT [FK__Asignacio__Vehic__5DCAEF64]
GO
ALTER TABLE [dbo].[Asignacion]  WITH CHECK ADD  CONSTRAINT [FK_Asignacion_Turno] FOREIGN KEY([TurnoID])
REFERENCES [dbo].[Turno] ([TurnoID])
GO
ALTER TABLE [dbo].[Asignacion] CHECK CONSTRAINT [FK_Asignacion_Turno]
GO
ALTER TABLE [dbo].[LogInicioSesion]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuario] ([UsuarioID])
GO
ALTER TABLE [dbo].[OrdenRecojo]  WITH CHECK ADD FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[OrdenRecojo]  WITH CHECK ADD FOREIGN KEY([EstadoOrdenID])
REFERENCES [dbo].[EstadoOrden] ([EstadoOrdenID])
GO
ALTER TABLE [dbo].[OrdenRecojo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenRecojo_TipoResiduo] FOREIGN KEY([TipoResiduoID])
REFERENCES [dbo].[TipoResiduo] ([TipoResiduoID])
GO
ALTER TABLE [dbo].[OrdenRecojo] CHECK CONSTRAINT [FK_OrdenRecojo_TipoResiduo]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([RolID])
REFERENCES [dbo].[Rol] ([RolID])
GO
ALTER TABLE [dbo].[UsuarioCliente]  WITH CHECK ADD FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[UsuarioCliente]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuario] ([UsuarioID])
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Asignación de vehículo y conductor a una orden' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Asignacion'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Clientes que solicitan servicios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Conductores disponibles' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Conductor'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Estados posibles para órdenes de recojo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'EstadoOrden'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Registro de accesos al sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LogInicioSesion'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Órdenes de recojo de residuos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'OrdenRecojo'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Roles asignados a los usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rol'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Usuarios del sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Relaciona usuarios con clientes que registran o gestionan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'Table_Description', @value=N'Vehículos asignados a recojos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Vehiculo'
GO
USE [master]
GO
ALTER DATABASE [db_EcoRecicla] SET  READ_WRITE 
GO
