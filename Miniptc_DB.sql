CREATE DATABASE SistemaTicketsMiniPTC;
GO

USE SistemaTicketsMiniPTC;
GO


create table Roles (
    idRol INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol VARCHAR(25) NOT NULL UNIQUE
);
GO
Insert into Roles Values ('Administrador'),('Técnico'),('Cliente')
go



cREATE TABLE Usuarios (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario NVARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL,
    clave NVARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
    idRol INT NOT NULL,
    FOREIGN KEY (idRol) REFERENCES Roles(idRol)
);
GO


create table Clientes (
    idCliente INT PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(20),
    FOREIGN KEY (idCliente) REFERENCES Usuarios(idUsuario)
);
GO


create table  Tecnicos (
    idTecnico INT PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(20),
    especialidad NVARCHAR(100),
    FOREIGN KEY (idTecnico) REFERENCES Usuarios(idUsuario)
);
GO


CREATE TABLE Categorias (
    idCategoria INT IDENTITY(1,1) PRIMARY KEY,
    nombreCategoria NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(500),
    activo BIT DEFAULT 1
);
GO


create table  Tickets (
    idTicket INT IDENTITY(1,1) PRIMARY KEY,
    titulo NVARCHAR(200) NOT NULL,
    descripcion NVARCHAR(MAX) NOT NULL,
    idCliente INT NOT NULL,
    idTecnico INT NULL,
    idCategoria INT NOT NULL,
    estado NVARCHAR(20) DEFAULT 'Abierto' CHECK (estado IN ('Abierto', 'En Progreso', 'En Espera', 'Resuelto', 'Cerrado')),
    prioridad NVARCHAR(20) DEFAULT 'Media' CHECK (prioridad IN ('Baja', 'Media', 'Alta', 'Crítica')),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaActualizacion DATETIME DEFAULT GETDATE(),
    fechaCierre DATETIME NULL,
    solucion NVARCHAR(MAX),
    FOREIGN KEY (idCliente) REFERENCES Clientes(idCliente),
    FOREIGN KEY (idTecnico) REFERENCES Tecnicos(idTecnico),
    FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria)
);
GO


CREATE TABLE HistorialTicket (
    idHistorial INT IDENTITY(1,1) PRIMARY KEY,
    idTicket INT NOT NULL,
    estadoAnterior NVARCHAR(20),
    estadoNuevo NVARCHAR(20),
    fechaCambio DATETIME DEFAULT GETDATE(),
    comentario NVARCHAR(MAX),
    FOREIGN KEY (idTicket) REFERENCES Tickets(idTicket)
);
GO 

CREATE TABLE Acciones (
    idAccion INT IDENTITY(1,1) PRIMARY KEY,
    nombreAccion NVARCHAR(100) NOT NULL UNIQUE,
    descripcion NVARCHAR(300)
);

CREATE TABLE RegistroActividades (
    idActividad INT IDENTITY(1,1) PRIMARY KEY,
    idUsuario INT NOT NULL,
    idAccion INT NOT NULL,
    detalle NVARCHAR(300), -- opcional para agregar contexto
    fecha DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario),
    FOREIGN KEY (idAccion) REFERENCES Acciones(idAccion)
);

