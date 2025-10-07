CREATE DATABASE TicketMiniPTC;
GO

USE TicketMiniPTC;
GO

-- Tablas
CREATE TABLE Rol (
    idRol INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol VARCHAR(25) NOT NULL UNIQUE
);
GO

CREATE TABLE Usuarios (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS UNIQUE NOT NULL, 
    clave VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL, 
    estadoUsuario BIT NOT NULL DEFAULT 1,
    id_Rol INT NOT NULL,
    primerLogin BIT NOT NULL DEFAULT 1,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(20),
    fechaCreacion DATETIME DEFAULT GETDATE(),
    
    CONSTRAINT FK_Usuarios_Rol FOREIGN KEY (id_Rol) REFERENCES Rol(idRol)
);
GO

CREATE TABLE Categorias (
    idCategoria INT IDENTITY(1,1) PRIMARY KEY,
    nombre_Categoria NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(500),
    activo BIT DEFAULT 1
);
GO

CREATE TABLE Tickets (
    idTicket INT IDENTITY(1,1) PRIMARY KEY,
    titulo NVARCHAR(200) NOT NULL,
    descripcion NVARCHAR(MAX) NOT NULL,
    clienteid INT NOT NULL,
    idTecnico_Asignado INT NULL,
    idCategoria INT NOT NULL,
    estado NVARCHAR(20) DEFAULT 'Abierto' 
        CHECK (estado IN ('Abierto', 'En Progreso', 'En Espera', 'Resuelto', 'Cerrado')),
    prioridad NVARCHAR(20) DEFAULT 'Media' 
        CHECK (prioridad IN ('Baja', 'Media', 'Alta', 'Critica')),
    fechacreacion DATETIME DEFAULT GETDATE(),
    fechaactualizacion DATETIME DEFAULT GETDATE(),
    fechacierre DATETIME NULL,
    solucion NVARCHAR(MAX),
    
    CONSTRAINT FK_Tickets_Cliente FOREIGN KEY (clienteid) REFERENCES Usuarios(idUsuario),
    CONSTRAINT FK_Tickets_Tecnico FOREIGN KEY (idTecnico_Asignado) REFERENCES Usuarios(idUsuario),
    CONSTRAINT FK_Tickets_Categoria FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria)
);
GO

-- Inserciones
INSERT INTO Rol (nombreRol) VALUES 
('Administrador'),
('Tecnico'),
('Cliente');
GO

INSERT INTO Categorias (nombre_Categoria, descripcion) VALUES
('Hardware', 'Problemas relacionados con componentes físicos'),
('Software', 'Problemas con aplicaciones y programas'),
('Red', 'Problemas de conectividad y red'),
('Sistema Operativo', 'Problemas con Windows, Linux, etc.'),
('Base de Datos', 'Problemas con SQL Server, MySQL, etc.'),
('Seguridad', 'Problemas de acceso y permisos');
GO

INSERT INTO Usuarios (nombreUsuario, clave, estadoUsuario, id_Rol, primerLogin, nombre, apellido) 
VALUES 
('Admin', 'Admin123', 1, 1, 1, 'Administrador', 'Principal'),
('Tecnico1', 'Tecnico123', 1, 2, 1, 'Carlos', 'Rodríguez'),
('Cliente1', 'Cliente123', 1, 3, 1, 'María', 'González');
GO

-- Vistas
CREATE VIEW Vista_Usuarios_Completa AS
SELECT 
    u.idUsuario AS ID,
    r.nombreRol AS Rol,
    u.nombreUsuario AS Usuario,
    u.nombre AS Nombre,
    u.apellido AS Apellido,
    u.telefono AS Telefono,
    CASE 
        WHEN u.estadoUsuario = 1 THEN 'ACTIVO' 
        ELSE 'INACTIVO' 
    END AS Estado,
    u.fechaCreacion AS [Fecha Registro]
FROM Usuarios u
INNER JOIN Rol r ON u.id_Rol = r.idRol;
GO

CREATE VIEW Vista_Tickets_Completa AS
SELECT 
    t.idTicket AS ID,
    t.titulo AS Titulo,
    t.descripcion AS Descripcion,
    c.nombre + ' ' + c.apellido AS Cliente,
    tec.nombre + ' ' + tec.apellido AS Tecnico,
    cat.nombre_Categoria AS Categoria,
    t.estado AS Estado,
    t.prioridad AS Prioridad,
    t.fechacreacion AS [Fecha Creacion],
    t.fechaactualizacion AS [Ultima Actualizacion],
    t.fechacierre AS [Fecha Cierre],
    t.solucion AS Solucion
FROM Tickets t
INNER JOIN Usuarios c ON t.clienteid = c.idUsuario
LEFT JOIN Usuarios tec ON t.idTecnico_Asignado = tec.idUsuario
INNER JOIN Categorias cat ON t.idCategoria = cat.idCategoria;
GO

CREATE VIEW Vista_Tecnicos_Activos AS
SELECT 
    idUsuario AS ID,
    nombreUsuario AS Usuario,
    nombre + ' ' + apellido AS [Nombre Completo],
    telefono AS Telefono
FROM Usuarios 
WHERE id_Rol = 2 AND estadoUsuario = 1;
GO

CREATE VIEW Vista_Clientes_Activos AS
SELECT 
    idUsuario AS ID,
    nombreUsuario AS Usuario,
    nombre + ' ' + apellido AS [Nombre Completo],
    telefono AS Telefono
FROM Usuarios 
WHERE id_Rol = 3 AND estadoUsuario = 1;
GO

-- Consultas de verificación
SELECT * FROM Rol;
SELECT * FROM Usuarios;
SELECT * FROM Categorias;

SELECT * FROM Vista_Usuarios_Completa;
SELECT * FROM Vista_Tecnicos_Activos;
SELECT * FROM Vista_Clientes_Activos;
GO
