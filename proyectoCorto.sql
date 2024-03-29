USE [master]
GO
/****** Object:  Database [proyectoCorto]    Script Date: 10/4/2019 6:54:26 p. m. ******/
CREATE DATABASE [proyectoCorto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectoCorto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\proyectoCorto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyectoCorto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\proyectoCorto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [proyectoCorto] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectoCorto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectoCorto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectoCorto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectoCorto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectoCorto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectoCorto] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectoCorto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectoCorto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectoCorto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectoCorto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectoCorto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectoCorto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectoCorto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectoCorto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectoCorto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectoCorto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyectoCorto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectoCorto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectoCorto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectoCorto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectoCorto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectoCorto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectoCorto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectoCorto] SET RECOVERY FULL 
GO
ALTER DATABASE [proyectoCorto] SET  MULTI_USER 
GO
ALTER DATABASE [proyectoCorto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectoCorto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectoCorto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectoCorto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyectoCorto] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyectoCorto', N'ON'
GO
ALTER DATABASE [proyectoCorto] SET QUERY_STORE = OFF
GO
USE [proyectoCorto]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [proyectoCorto]
GO
/****** Object:  Table [dbo].[carreras]    Script Date: 10/4/2019 6:54:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carreras](
	[id_carrera] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_carreras] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cursos]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cursos](
	[id_curso] [int] NOT NULL,
	[id_carrera] [int] NOT NULL,
	[id_horario] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[id_profesor] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[requisito] [nvarchar](50) NOT NULL,
	[id_sede] [int] NOT NULL,
	[costo] [int] NOT NULL,
	[creditos] [int] NOT NULL,
 CONSTRAINT [PK_cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id_cedula] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[celular] [int] NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[id_carrera] [int] NOT NULL,
 CONSTRAINT [PK_estudiantes] PRIMARY KEY CLUSTERED 
(
	[id_cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horarios]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horarios](
	[id_horario] [int] NOT NULL,
	[id_carrera] [int] NOT NULL,
	[dia] [nvarchar](50) NOT NULL,
	[hora] [nvarchar](50) NOT NULL,
	[id_sede] [int] NOT NULL,
 CONSTRAINT [PK_horarios] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[matricula]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[matricula](
	[id_matricula] [int] NOT NULL,
	[id_cedula] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[anno] [date] NOT NULL,
	[cuatrimestre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_matricula] PRIMARY KEY CLUSTERED 
(
	[id_matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notas]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notas](
	[id_nota] [int] NOT NULL,
	[id_matricula] [int] NOT NULL,
	[notas] [int] NOT NULL,
	[nota_final] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_notas] PRIMARY KEY CLUSTERED 
(
	[id_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[profesores]    Script Date: 10/4/2019 6:54:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profesores](
	[id_profesor] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK_profesores] PRIMARY KEY CLUSTERED 
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sede]    Script Date: 10/4/2019 6:54:29 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sede](
	[id_sede] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sede] PRIMARY KEY CLUSTERED 
(
	[id_sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (1, N'Informatica', N'Ingenieria')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (2, N'Electronica', N'Ingenieria')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (3, N'Mercadeo', N'Administracion')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (4, N'Finanzas', N'Administracion')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (5, N'Enfermeria', N'Salud')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (6, N'Medicina General', N'Salud')
INSERT [dbo].[carreras] ([id_carrera], [nombre], [descripcion]) VALUES (7, N'Odontologia', N'Salud Dental')
INSERT [dbo].[cursos] ([id_curso], [id_carrera], [id_horario], [nombre], [id_profesor], [descripcion], [requisito], [id_sede], [costo], [creditos]) VALUES (1, 1, 1, N'Informatica', 1, N'Java', N'No tiene', 1, 90000, 4)
INSERT [dbo].[cursos] ([id_curso], [id_carrera], [id_horario], [nombre], [id_profesor], [descripcion], [requisito], [id_sede], [costo], [creditos]) VALUES (2, 2, 2, N'Arquitectura', 2, N'Compuertas', N'No tiene', 2, 60000, 4)
INSERT [dbo].[cursos] ([id_curso], [id_carrera], [id_horario], [nombre], [id_profesor], [descripcion], [requisito], [id_sede], [costo], [creditos]) VALUES (3, 3, 3, N'Matematica', 3, N'Financiera', N'Matematica 1', 3, 60000, 5)
INSERT [dbo].[cursos] ([id_curso], [id_carrera], [id_horario], [nombre], [id_profesor], [descripcion], [requisito], [id_sede], [costo], [creditos]) VALUES (4, 1, 1, N'Emma', 1, N'C#', N'No tiene', 1, 75000, 3)
INSERT [dbo].[estudiantes] ([id_cedula], [nombre], [apellido], [direccion], [telefono], [celular], [correo], [id_carrera]) VALUES (11111111, N'Emma', N'Masis', N'Coronado', 11111111, 11111111, N'emmacr86@gmail.com', 1)
INSERT [dbo].[estudiantes] ([id_cedula], [nombre], [apellido], [direccion], [telefono], [celular], [correo], [id_carrera]) VALUES (22222222, N'Karol', N'Cerna', N'Desamparados', 22222222, 22222222, N'cerna@gmail.com', 2)
INSERT [dbo].[estudiantes] ([id_cedula], [nombre], [apellido], [direccion], [telefono], [celular], [correo], [id_carrera]) VALUES (33333333, N'Maria', N'Vindas', N'San Jose', 33333333, 33333333, N'maria@gmail.com', 3)
INSERT [dbo].[estudiantes] ([id_cedula], [nombre], [apellido], [direccion], [telefono], [celular], [correo], [id_carrera]) VALUES (44444444, N'Armando', N'Broncas', N'Heredia', 44444444, 44444444, N'broncas@gmail.com', 6)
INSERT [dbo].[horarios] ([id_horario], [id_carrera], [dia], [hora], [id_sede]) VALUES (1, 1, N'Lunes', N'8:00', 1)
INSERT [dbo].[horarios] ([id_horario], [id_carrera], [dia], [hora], [id_sede]) VALUES (2, 2, N'Martes', N'8:00', 2)
INSERT [dbo].[horarios] ([id_horario], [id_carrera], [dia], [hora], [id_sede]) VALUES (3, 3, N'Miercoles', N'10:00', 3)
INSERT [dbo].[matricula] ([id_matricula], [id_cedula], [id_curso], [anno], [cuatrimestre]) VALUES (1, 11111111, 1, CAST(N'2019-01-01' AS Date), N'I')
INSERT [dbo].[matricula] ([id_matricula], [id_cedula], [id_curso], [anno], [cuatrimestre]) VALUES (2, 22222222, 2, CAST(N'2019-01-03' AS Date), N'II')
INSERT [dbo].[matricula] ([id_matricula], [id_cedula], [id_curso], [anno], [cuatrimestre]) VALUES (3, 11111111, 2, CAST(N'2019-04-08' AS Date), N'IV')
INSERT [dbo].[notas] ([id_nota], [id_matricula], [notas], [nota_final], [status]) VALUES (1, 1, 90, 90, N'Aprobado')
INSERT [dbo].[notas] ([id_nota], [id_matricula], [notas], [nota_final], [status]) VALUES (2, 2, 75, 75, N'Aprobado')
INSERT [dbo].[notas] ([id_nota], [id_matricula], [notas], [nota_final], [status]) VALUES (3, 3, 50, 60, N'Reprobado')
INSERT [dbo].[profesores] ([id_profesor], [nombre], [apellido], [correo], [telefono]) VALUES (1, N'Luis', N'Navarro', N'navarro@gmail.com', 11111111)
INSERT [dbo].[profesores] ([id_profesor], [nombre], [apellido], [correo], [telefono]) VALUES (2, N'Henry', N'Leal', N'leal@gmail.com', 22222222)
INSERT [dbo].[profesores] ([id_profesor], [nombre], [apellido], [correo], [telefono]) VALUES (3, N'Roy', N'Calderon', N'calderon@gmail.com', 22222222)
INSERT [dbo].[profesores] ([id_profesor], [nombre], [apellido], [correo], [telefono]) VALUES (4, N'Eduardo', N'Sanabria', N'sanabria@gmail.com', 33333333)
INSERT [dbo].[sede] ([id_sede], [nombre], [descripcion], [direccion]) VALUES (1, N'Sede Aranjuez', N'San Jose', N'Aranjuez')
INSERT [dbo].[sede] ([id_sede], [nombre], [descripcion], [direccion]) VALUES (2, N'Sede Heredia', N'Heredia', N'Centro')
INSERT [dbo].[sede] ([id_sede], [nombre], [descripcion], [direccion]) VALUES (3, N'Sede LLorente', N'San Jose', N'Tibás')
INSERT [dbo].[sede] ([id_sede], [nombre], [descripcion], [direccion]) VALUES (4, N'Sede Puntarenas', N'Puntarenas', N'Centro')
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_carreras] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_carreras]
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_horarios] FOREIGN KEY([id_horario])
REFERENCES [dbo].[horarios] ([id_horario])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_horarios]
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_profesores] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[profesores] ([id_profesor])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_profesores]
GO
ALTER TABLE [dbo].[cursos]  WITH CHECK ADD  CONSTRAINT [FK_cursos_sede] FOREIGN KEY([id_sede])
REFERENCES [dbo].[sede] ([id_sede])
GO
ALTER TABLE [dbo].[cursos] CHECK CONSTRAINT [FK_cursos_sede]
GO
ALTER TABLE [dbo].[estudiantes]  WITH CHECK ADD  CONSTRAINT [FK_estudiantes_carreras] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[estudiantes] CHECK CONSTRAINT [FK_estudiantes_carreras]
GO
ALTER TABLE [dbo].[horarios]  WITH CHECK ADD  CONSTRAINT [FK_horarios_carreras] FOREIGN KEY([id_carrera])
REFERENCES [dbo].[carreras] ([id_carrera])
GO
ALTER TABLE [dbo].[horarios] CHECK CONSTRAINT [FK_horarios_carreras]
GO
ALTER TABLE [dbo].[horarios]  WITH CHECK ADD  CONSTRAINT [FK_horarios_sede] FOREIGN KEY([id_sede])
REFERENCES [dbo].[sede] ([id_sede])
GO
ALTER TABLE [dbo].[horarios] CHECK CONSTRAINT [FK_horarios_sede]
GO
ALTER TABLE [dbo].[matricula]  WITH CHECK ADD  CONSTRAINT [FK_matricula_cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO
ALTER TABLE [dbo].[matricula] CHECK CONSTRAINT [FK_matricula_cursos]
GO
ALTER TABLE [dbo].[matricula]  WITH CHECK ADD  CONSTRAINT [FK_matricula_cursos1] FOREIGN KEY([id_curso])
REFERENCES [dbo].[cursos] ([id_curso])
GO
ALTER TABLE [dbo].[matricula] CHECK CONSTRAINT [FK_matricula_cursos1]
GO
ALTER TABLE [dbo].[matricula]  WITH CHECK ADD  CONSTRAINT [FK_matricula_estudiantes1] FOREIGN KEY([id_cedula])
REFERENCES [dbo].[estudiantes] ([id_cedula])
GO
ALTER TABLE [dbo].[matricula] CHECK CONSTRAINT [FK_matricula_estudiantes1]
GO
ALTER TABLE [dbo].[notas]  WITH CHECK ADD  CONSTRAINT [FK_notas_matricula] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[matricula] ([id_matricula])
GO
ALTER TABLE [dbo].[notas] CHECK CONSTRAINT [FK_notas_matricula]
GO
USE [master]
GO
ALTER DATABASE [proyectoCorto] SET  READ_WRITE 
GO
