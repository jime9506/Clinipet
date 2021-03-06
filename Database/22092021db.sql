USE [Clinipet1]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [nvarchar](50) NOT NULL,
	[FechaContratacion] [nvarchar](50) NOT NULL,
	[TipoContrato] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[perNombre] [nvarchar](50) NOT NULL,
	[perCorreo] [nvarchar](50) NOT NULL,
	[perNit] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[IdMascota] [int] IDENTITY(1,1) NOT NULL,
	[Emfermedades] [nvarchar](50) NOT NULL,
	[Vacunas] [nvarchar](50) NOT NULL,
	[Peso] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[IdMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[IdMascota] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
	[NombreMascota] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Raza] [nvarchar](50) NOT NULL,
	[Edad] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
	[Acudiente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[IdMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[perIdentificacion] [nvarchar](15) NOT NULL,
	[perNombres] [nvarchar](50) NOT NULL,
	[perApellidos] [nvarchar](50) NOT NULL,
	[perGenero] [nvarchar](12) NOT NULL,
	[perCorreo] [nvarchar](50) NOT NULL,
	[perFechaNacimiento] [date] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/09/2021 9:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdPersona] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Id], [Cargo], [FechaContratacion], [TipoContrato]) VALUES (1, N'Doctor', N'12-06-2021:12:00:00', N'Indefinido')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([IdEmpresa], [perNombre], [perCorreo], [perNit]) VALUES (1, N'Veterinaria los gaticos a', N'veterinarialosgaticos@yahoo.com', N'12345678911')
INSERT [dbo].[Empresa] ([IdEmpresa], [perNombre], [perCorreo], [perNit]) VALUES (2, N'Perritos y gaticos ', N'perritosygaticos@gmail.com', N'123456780')
INSERT [dbo].[Empresa] ([IdEmpresa], [perNombre], [perCorreo], [perNit]) VALUES (1002, N'aa', N'dd', N'ff')
INSERT [dbo].[Empresa] ([IdEmpresa], [perNombre], [perCorreo], [perNit]) VALUES (1003, N'aa', N'aa', N'1')
SET IDENTITY_INSERT [dbo].[Empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoriaClinica] ON 

INSERT [dbo].[HistoriaClinica] ([IdMascota], [Emfermedades], [Vacunas], [Peso]) VALUES (1, N'Brucelosis', N'Rabiayyagggqq', CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[HistoriaClinica] ([IdMascota], [Emfermedades], [Vacunas], [Peso]) VALUES (2, N'rabia', N'ju', CAST(6 AS Decimal(18, 0)))
INSERT [dbo].[HistoriaClinica] ([IdMascota], [Emfermedades], [Vacunas], [Peso]) VALUES (3, N'A', N'S', CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[HistoriaClinica] ([IdMascota], [Emfermedades], [Vacunas], [Peso]) VALUES (4, N'aa', N'kk', CAST(1 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[HistoriaClinica] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([IdMascota], [Categoria], [NombreMascota], [Telefono], [Raza], [Edad], [Sexo], [Acudiente]) VALUES (1, N'Felino', N'Ribuk', 5552345, N'Criollo', N'3', N'Masculino', N'Luis')
INSERT [dbo].[Mascota] ([IdMascota], [Categoria], [NombreMascota], [Telefono], [Raza], [Edad], [Sexo], [Acudiente]) VALUES (2, N'qq', N'oo', 111, N'ji', N'2', N'kk', N'ii')
SET IDENTITY_INSERT [dbo].[Mascota] OFF
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2002, N'uuuu', N'HJKJ', N'JKJ', N'HKJ', N'KJKJ', CAST(N'2021-09-15' AS Date))
INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2004, N'123', N'julia', N'hernandez', N'fememnino', N'amenis@hotmail.com', CAST(N'2021-09-20' AS Date))
INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2007, N'JJ', N'LL', N'LL', N'JJJ', N'IIII', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2008, N'ju', N'lol', N'aaa', N'uju', N'mooo', CAST(N'2021-09-02' AS Date))
INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2009, N'jJ', N'k', N'jjj', N'ooo', N'@gmail.com', CAST(N'2021-09-16' AS Date))
INSERT [dbo].[Personas] ([IdPersona], [perIdentificacion], [perNombres], [perApellidos], [perGenero], [perCorreo], [perFechaNacimiento]) VALUES (2010, N'ww', N'jj', N'mm', N'kk', N'lll', CAST(N'2021-09-09' AS Date))
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (1, N'1')
INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (2, N'Administrador')
INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (1004, N'jajajaaa')
INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (1005, N'q')
INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (1006, N'Visitante')
INSERT [dbo].[Roles] ([IdRol], [Rol]) VALUES (1007, N'gato')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Email], [Password], [IdRol], [IdPersona]) VALUES (1, N'camilo.1@yahoo.com', N'12345', 1, 2002)
INSERT [dbo].[Usuario] ([IdUsuario], [Email], [Password], [IdRol], [IdPersona]) VALUES (2, N'yina@gmail.com', N'12345', 2, 2002)
INSERT [dbo].[Usuario] ([IdUsuario], [Email], [Password], [IdRol], [IdPersona]) VALUES (3, N'yy', N'88888', 2, 2002)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
/****** Object:  Index [IX_Empresa]    Script Date: 22/09/2021 9:05:14 ******/
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [IX_Empresa] UNIQUE NONCLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Empresa_1]    Script Date: 22/09/2021 9:05:14 ******/
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [IX_Empresa_1] UNIQUE NONCLUSTERED 
(
	[perNit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Personas]    Script Date: 22/09/2021 9:05:14 ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [IX_Personas] UNIQUE NONCLUSTERED 
(
	[perCorreo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Personas_1]    Script Date: 22/09/2021 9:05:14 ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [IX_Personas_1] UNIQUE NONCLUSTERED 
(
	[perCorreo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
