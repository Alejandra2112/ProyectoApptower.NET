USE [ApptowerProvicional]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22/09/2023 8:28:49 a. m. ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Espacios]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Espacios](
	[IdEspacio] [int] IDENTITY(1,1) NOT NULL,
	[TipoEspacio] [varchar](255) NOT NULL,
	[NombreEspacio] [varchar](255) NULL,
	[Area] [float] NULL,
	[Capacidad] [int] NULL,
	[EstadoEspacio] [varchar](20) NOT NULL,
 CONSTRAINT [PKIdEspacios] PRIMARY KEY CLUSTERED 
(
	[IdEspacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parqueaderos]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parqueaderos](
	[IdParqueadero] [int] IDENTITY(1,1) NOT NULL,
	[NombreParqueadero] [varchar](10) NOT NULL,
	[TipoParqueadero] [varchar](50) NOT NULL,
	[EstadoParqueadero] [varchar](20) NULL,
 CONSTRAINT [PKParqueaderos] PRIMARY KEY CLUSTERED 
(
	[IdParqueadero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParqueaderosDeEspacios]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParqueaderosDeEspacios](
	[IdParqueaderosDeEspacios] [int] IDENTITY(1,1) NOT NULL,
	[IdEspacio] [int] NULL,
	[IdParqueadero] [int] NULL,
 CONSTRAINT [PKParqueaderosDeEspacios] PRIMARY KEY CLUSTERED 
(
	[IdParqueaderosDeEspacios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propietarios]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propietarios](
	[IdPropietario] [int] IDENTITY(1,1) NOT NULL,
	[TipoDocumentoPropietario] [varchar](20) NOT NULL,
	[NumeroDocumentoPropietario] [varchar](15) NOT NULL,
	[NombrePropietario] [varchar](255) NOT NULL,
	[ApellidoPropietario] [varchar](255) NOT NULL,
	[FechaNacimientoPropietario] [datetime] NOT NULL,
	[CorreoPropietario] [varchar](80) NOT NULL,
	[TelefonoPropietario] [varchar](15) NULL,
	[EstadoPropietario] [varchar](20) NOT NULL,
 CONSTRAINT [PKIdPropietario] PRIMARY KEY CLUSTERED 
(
	[IdPropietario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropietariosPorEspacio]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropietariosPorEspacio](
	[IdPropietariosPorEspacio] [int] IDENTITY(1,1) NOT NULL,
	[IdEspacio] [int] NULL,
	[IdPropietario] [int] NULL,
 CONSTRAINT [PKPropietariosPorEspacio] PRIMARY KEY CLUSTERED 
(
	[IdPropietariosPorEspacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[TipoReserva] [varchar](40) NOT NULL,
	[FechaReserva] [int] NOT NULL,
	[EspacioReserva] [varchar](40) NOT NULL,
	[CantidadPersonas] [int] NOT NULL,
 CONSTRAINT [PKReserva] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservasEspacios]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservasEspacios](
	[IdReservaEspacios] [int] IDENTITY(1,1) NOT NULL,
	[IdReserva] [int] NULL,
	[IdEspacio] [int] NULL,
 CONSTRAINT [PKReservaEspacios] PRIMARY KEY CLUSTERED 
(
	[IdReservaEspacios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservasParqueadero]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservasParqueadero](
	[IdReservaEspacios] [int] IDENTITY(1,1) NOT NULL,
	[IdReserva] [int] NULL,
	[IdParqueadero] [int] NULL,
	[IdVehiculo] [int] NULL,
 CONSTRAINT [PKReservaParqueadero] PRIMARY KEY CLUSTERED 
(
	[IdReservaEspacios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Residentes]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Residentes](
	[IdResidente] [int] IDENTITY(1,1) NOT NULL,
	[TipoDocumentoResidente] [varchar](20) NOT NULL,
	[NumeroDocumentoResidente] [varchar](15) NOT NULL,
	[NombreResidente] [varchar](255) NOT NULL,
	[ApellidoResidente] [varchar](255) NOT NULL,
	[FechaNacimientoResidente] [datetime] NOT NULL,
	[CorreoResidente] [varchar](80) NOT NULL,
	[TelefonoResidente] [varchar](15) NULL,
	[TipoResidente] [varchar](255) NOT NULL,
	[ResidenciaActual] [bit] NOT NULL,
	[IdEspacio] [int] NOT NULL,
	[FechaInicioResidencia] [datetime] NOT NULL,
	[FechaFinResidencia] [datetime] NULL,
	[EstadoResidente] [varchar](20) NOT NULL,
 CONSTRAINT [PKIdResidente] PRIMARY KEY CLUSTERED 
(
	[IdResidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[IdRol] [int] NULL,
	[TipoDocumento] [varchar](20) NULL,
	[Documento] [varchar](15) NULL,
	[Correo] [varchar](80) NULL,
	[fecha_creacion] [date] NULL,
	[Telefono] [varchar](15) NULL,
	[Contrasena] [varchar](10) NULL,
	[Estado] [varchar](20) NOT NULL,
 CONSTRAINT [PkIdUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[IdVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Placa] [varchar](10) NOT NULL,
	[TipoUsuarioVehiculo] [int] NOT NULL,
	[NombrePropietarioVehiculo] [int] NOT NULL,
 CONSTRAINT [PKVehiculos] PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehiculosPorEspacio]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiculosPorEspacio](
	[IdVehiculosPorEspacio] [int] IDENTITY(1,1) NOT NULL,
	[IdEspacio] [int] NULL,
	[IdVehiculo] [int] NULL,
 CONSTRAINT [PKIdVehiculosPorEspacio] PRIMARY KEY CLUSTERED 
(
	[IdVehiculosPorEspacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitantes]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitantes](
	[IdVisitante] [int] IDENTITY(1,1) NOT NULL,
	[TipoDocumentoVisitante] [varchar](20) NOT NULL,
	[NumeroDocumentoVisitante] [varchar](15) NULL,
	[NombreVisitante] [varchar](255) NOT NULL,
	[ApellidoVisitante] [varchar](255) NOT NULL,
	[GeneroVisitante] [varchar](1) NULL,
	[PermisoVisitante] [varchar](20) NOT NULL,
 CONSTRAINT [PKIdVisitante] PRIMARY KEY CLUSTERED 
(
	[IdVisitante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitantesPorEspacio]    Script Date: 22/09/2023 8:28:49 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitantesPorEspacio](
	[IdVisitantePorEspacio] [int] IDENTITY(1,1) NOT NULL,
	[IdEspacio] [int] NULL,
	[IdVisitante] [int] NULL,
 CONSTRAINT [PKIdVisitantePorEspacio] PRIMARY KEY CLUSTERED 
(
	[IdVisitantePorEspacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230922034714_Dbinicial', N'7.0.11')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f989ffc9-6969-40dd-a2f3-566f065b8950', N'alejandramejia@gmail.com', N'ALEJANDRAMEJIA@GMAIL.COM', N'alejandramejia@gmail.com', N'ALEJANDRAMEJIA@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAENW0y9TgO/BBoFiA6AzW1DDtLWOvqP/JxihVUZa4uCk2SgJeoevNZsspR/f9BeucVg==', N'YD4E43MAJ5NORSGOMLFJNAXQ46XAGX3G', N'c8157527-635e-4687-8261-6261e663248e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fb1ad0fb-35d5-4e20-9b3e-7a2fd2bf98dd', N'alejandramejia1256@gmail.com', N'ALEJANDRAMEJIA1256@GMAIL.COM', N'alejandramejia1256@gmail.com', N'ALEJANDRAMEJIA1256@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEEjlYixrknrBd4o8TReCWVcJZ2LUxPd5aiPtUfM5mmc7hQf0J45k2Z3Mx4CHQf88RQ==', N'3SEH4A2HOCZXA2LDAMVPK2CAWJCHZFT3', N'ef787947-bc14-44f8-91e8-9e2517e93945', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Parqueaderos] ON 

INSERT [dbo].[Parqueaderos] ([IdParqueadero], [NombreParqueadero], [TipoParqueadero], [EstadoParqueadero]) VALUES (1, N'S101', N'RESIDENTES', N'ACTIVO')
SET IDENTITY_INSERT [dbo].[Parqueaderos] OFF
GO
SET IDENTITY_INSERT [dbo].[Propietarios] ON 

INSERT [dbo].[Propietarios] ([IdPropietario], [TipoDocumentoPropietario], [NumeroDocumentoPropietario], [NombrePropietario], [ApellidoPropietario], [FechaNacimientoPropietario], [CorreoPropietario], [TelefonoPropietario], [EstadoPropietario]) VALUES (3, N'CC', N'1020105787', N'Alejandras', N'Aguirre', CAST(N'2004-12-21T23:08:00.000' AS DateTime), N'alejandra@gmail.com', N'3145633422', N'ACTIVO')
SET IDENTITY_INSERT [dbo].[Propietarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [IdRol], [TipoDocumento], [Documento], [Correo], [fecha_creacion], [Telefono], [Contrasena], [Estado]) VALUES (13, N'Alejandra', N'Aguirre', 1, N'CC', N'1020105787', N'alejandramejia@gmal.com', CAST(N'2023-09-19' AS Date), N'3145633422', NULL, N'ACTIVO')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [IdRol], [TipoDocumento], [Documento], [Correo], [fecha_creacion], [Telefono], [Contrasena], [Estado]) VALUES (16, N'Andrea', N'Soto', 3, N'CC', N'1234567890', N'andrea@gmail.com', CAST(N'2023-09-19' AS Date), N'3123457890', NULL, N'ACTIVO')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Espacios__585163C0E38CE302]    Script Date: 22/09/2023 8:28:49 a. m. ******/
ALTER TABLE [dbo].[Espacios] ADD UNIQUE NONCLUSTERED 
(
	[NombreEspacio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNNombreParqueadro]    Script Date: 22/09/2023 8:28:49 a. m. ******/
ALTER TABLE [dbo].[Parqueaderos] ADD  CONSTRAINT [UNNombreParqueadro] UNIQUE NONCLUSTERED 
(
	[NombreParqueadero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UCPlaca]    Script Date: 22/09/2023 8:28:49 a. m. ******/
ALTER TABLE [dbo].[Vehiculos] ADD  CONSTRAINT [UCPlaca] UNIQUE NONCLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Espacios] ADD  DEFAULT (NULL) FOR [Area]
GO
ALTER TABLE [dbo].[Espacios] ADD  DEFAULT (NULL) FOR [Capacidad]
GO
ALTER TABLE [dbo].[Espacios] ADD  DEFAULT ('ACTIVO') FOR [EstadoEspacio]
GO
ALTER TABLE [dbo].[Parqueaderos] ADD  DEFAULT ('ACTIVO') FOR [EstadoParqueadero]
GO
ALTER TABLE [dbo].[Propietarios] ADD  DEFAULT ('ACTIVO') FOR [EstadoPropietario]
GO
ALTER TABLE [dbo].[Residentes] ADD  DEFAULT ('PROPIETARIO') FOR [TipoResidente]
GO
ALTER TABLE [dbo].[Residentes] ADD  DEFAULT ((1)) FOR [ResidenciaActual]
GO
ALTER TABLE [dbo].[Residentes] ADD  DEFAULT (NULL) FOR [FechaFinResidencia]
GO
ALTER TABLE [dbo].[Residentes] ADD  DEFAULT ('ACTIVO') FOR [EstadoResidente]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ('Activo') FOR [Estado]
GO
ALTER TABLE [dbo].[Visitantes] ADD  DEFAULT ('OTRO') FOR [GeneroVisitante]
GO
ALTER TABLE [dbo].[Visitantes] ADD  DEFAULT ('ACTIVO') FOR [PermisoVisitante]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ParqueaderosDeEspacios]  WITH CHECK ADD  CONSTRAINT [FKIdEspacio] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[ParqueaderosDeEspacios] CHECK CONSTRAINT [FKIdEspacio]
GO
ALTER TABLE [dbo].[ParqueaderosDeEspacios]  WITH CHECK ADD  CONSTRAINT [FKIdParqueaderos] FOREIGN KEY([IdParqueadero])
REFERENCES [dbo].[Parqueaderos] ([IdParqueadero])
GO
ALTER TABLE [dbo].[ParqueaderosDeEspacios] CHECK CONSTRAINT [FKIdParqueaderos]
GO
ALTER TABLE [dbo].[PropietariosPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKEspacios3] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[PropietariosPorEspacio] CHECK CONSTRAINT [FKEspacios3]
GO
ALTER TABLE [dbo].[PropietariosPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKPropietarios3] FOREIGN KEY([IdPropietario])
REFERENCES [dbo].[Propietarios] ([IdPropietario])
GO
ALTER TABLE [dbo].[PropietariosPorEspacio] CHECK CONSTRAINT [FKPropietarios3]
GO
ALTER TABLE [dbo].[Reservas]  WITH CHECK ADD  CONSTRAINT [FKUsuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reservas] CHECK CONSTRAINT [FKUsuario]
GO
ALTER TABLE [dbo].[ReservasEspacios]  WITH CHECK ADD  CONSTRAINT [FKEspacio1] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[ReservasEspacios] CHECK CONSTRAINT [FKEspacio1]
GO
ALTER TABLE [dbo].[ReservasEspacios]  WITH CHECK ADD  CONSTRAINT [FKReserva1] FOREIGN KEY([IdReserva])
REFERENCES [dbo].[Reservas] ([IdReserva])
GO
ALTER TABLE [dbo].[ReservasEspacios] CHECK CONSTRAINT [FKReserva1]
GO
ALTER TABLE [dbo].[ReservasParqueadero]  WITH CHECK ADD  CONSTRAINT [FKParqueadero2] FOREIGN KEY([IdParqueadero])
REFERENCES [dbo].[Parqueaderos] ([IdParqueadero])
GO
ALTER TABLE [dbo].[ReservasParqueadero] CHECK CONSTRAINT [FKParqueadero2]
GO
ALTER TABLE [dbo].[ReservasParqueadero]  WITH CHECK ADD  CONSTRAINT [FKReserva2] FOREIGN KEY([IdReserva])
REFERENCES [dbo].[Reservas] ([IdReserva])
GO
ALTER TABLE [dbo].[ReservasParqueadero] CHECK CONSTRAINT [FKReserva2]
GO
ALTER TABLE [dbo].[ReservasParqueadero]  WITH CHECK ADD  CONSTRAINT [FKVehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculos] ([IdVehiculo])
GO
ALTER TABLE [dbo].[ReservasParqueadero] CHECK CONSTRAINT [FKVehiculo]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [FKEspacio] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [FKEspacio]
GO
ALTER TABLE [dbo].[VehiculosPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKEspacios2] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[VehiculosPorEspacio] CHECK CONSTRAINT [FKEspacios2]
GO
ALTER TABLE [dbo].[VehiculosPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKVehiculo2] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculos] ([IdVehiculo])
GO
ALTER TABLE [dbo].[VehiculosPorEspacio] CHECK CONSTRAINT [FKVehiculo2]
GO
ALTER TABLE [dbo].[VisitantesPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKEspacios1] FOREIGN KEY([IdEspacio])
REFERENCES [dbo].[Espacios] ([IdEspacio])
GO
ALTER TABLE [dbo].[VisitantesPorEspacio] CHECK CONSTRAINT [FKEspacios1]
GO
ALTER TABLE [dbo].[VisitantesPorEspacio]  WITH CHECK ADD  CONSTRAINT [FKVisitante1] FOREIGN KEY([IdVisitante])
REFERENCES [dbo].[Visitantes] ([IdVisitante])
GO
ALTER TABLE [dbo].[VisitantesPorEspacio] CHECK CONSTRAINT [FKVisitante1]
GO
ALTER TABLE [dbo].[Espacios]  WITH CHECK ADD  CONSTRAINT [CKArea] CHECK  (([Area]>(0)))
GO
ALTER TABLE [dbo].[Espacios] CHECK CONSTRAINT [CKArea]
GO
ALTER TABLE [dbo].[Espacios]  WITH CHECK ADD  CONSTRAINT [CKCapacidad] CHECK  (([Capacidad]>(0)))
GO
ALTER TABLE [dbo].[Espacios] CHECK CONSTRAINT [CKCapacidad]
GO
ALTER TABLE [dbo].[Parqueaderos]  WITH CHECK ADD  CONSTRAINT [CKEstadoParqueadero] CHECK  (([EstadoParqueadero]='INACTIVO' OR [EstadoParqueadero]='ACTIVO'))
GO
ALTER TABLE [dbo].[Parqueaderos] CHECK CONSTRAINT [CKEstadoParqueadero]
GO
ALTER TABLE [dbo].[Parqueaderos]  WITH CHECK ADD  CONSTRAINT [CKTipoParqueadero] CHECK  (([TipoParqueadero]='VISITANTES' OR [TipoParqueadero]='RESIDENTES'))
GO
ALTER TABLE [dbo].[Parqueaderos] CHECK CONSTRAINT [CKTipoParqueadero]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKApellidoPropietario] CHECK  ((NOT [ApellidoPropietario] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKApellidoPropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKCorreoPropietario] CHECK  (([CorreoPropietario] like '%[A-Za-z0-9]%@%[A-Za-z0-9]%.com'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKCorreoPropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKEstadoPropietario] CHECK  (([EstadoPropietario]='INACTIVO' OR [EstadoPropietario]='ACTIVO'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKEstadoPropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKNombrePropietario] CHECK  ((NOT [NombrePropietario] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKNombrePropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKNumeroDocumentoPropietario] CHECK  (([NumeroDocumentoPropietario] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKNumeroDocumentoPropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKTelefonoPropietario] CHECK  (([TelefonoPropietario] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKTelefonoPropietario]
GO
ALTER TABLE [dbo].[Propietarios]  WITH CHECK ADD  CONSTRAINT [CKTipoDocumentoPropietario] CHECK  ((NOT [TipoDocumentoPropietario] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Propietarios] CHECK CONSTRAINT [CKTipoDocumentoPropietario]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKApellidoResidente] CHECK  ((NOT [ApellidoResidente] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKApellidoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKCorreoResidente] CHECK  (([CorreoResidente] like '%[A-Za-z0-9]%@%[A-Za-z0-9]%.com'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKCorreoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKEstadoResidente] CHECK  (([EstadoResidente]='INACTIVO' OR [EstadoResidente]='ACTIVO'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKEstadoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKNombreResidente] CHECK  ((NOT [NombreResidente] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKNombreResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKNumeroDocumentoResidente] CHECK  (([NumeroDocumentoResidente] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKNumeroDocumentoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKTelefonoResidente] CHECK  (([TelefonoResidente] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKTelefonoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKTipoDocumentoResidente] CHECK  ((NOT [NumeroDocumentoResidente] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKTipoDocumentoResidente]
GO
ALTER TABLE [dbo].[Residentes]  WITH CHECK ADD  CONSTRAINT [CKTipoResidente] CHECK  (([TipoResidente]='ARRENDATARIO' OR [TipoResidente]='PROPIETARIO'))
GO
ALTER TABLE [dbo].[Residentes] CHECK CONSTRAINT [CKTipoResidente]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKApellido] CHECK  ((NOT [Apellido] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKApellido]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKContrasena] CHECK  (([Contrasena] like '%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]%%[A-Za-z0-9]'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKContrasena]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKCorreo] CHECK  (([Correo] like '%[A-Za-z0-9]%@%[A-Za-z0-9]%.com'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKCorreo]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKDocumento] CHECK  (([Documento] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKDocumento]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKNombre] CHECK  ((NOT [Nombre] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKNombre]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKTelefono] CHECK  (([Telefono] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKTelefono]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CHKTipo] CHECK  ((NOT [TipoDocumento] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CHKTipo]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [CKEstado] CHECK  (([Estado]='Inactivo' OR [Estado]='Activo'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [CKEstado]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKApellidoVisitante] CHECK  ((NOT [ApellidoVisitante] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKApellidoVisitante]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKGeneroVisitante] CHECK  (([GeneroVisitante]='OTRO' OR [GeneroVisitante]='M' OR [GeneroVisitante]='F'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKGeneroVisitante]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKNombreVisitante] CHECK  ((NOT [NombreVisitante] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKNombreVisitante]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKNumeroDocumentoVisitante] CHECK  (([NumeroDocumentoVisitante] like '[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]%[0-9]'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKNumeroDocumentoVisitante]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKPermisoVisitante] CHECK  (([PermisoVisitante]='NO PERMITIDO' OR [PermisoVisitante]='PERMITIDO'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKPermisoVisitante]
GO
ALTER TABLE [dbo].[Visitantes]  WITH CHECK ADD  CONSTRAINT [CKTipoDocumentoVisitante] CHECK  ((NOT [TipoDocumentoVisitante] like '%[^A-Za-z]%'))
GO
ALTER TABLE [dbo].[Visitantes] CHECK CONSTRAINT [CKTipoDocumentoVisitante]
GO
