use master
DECLARE @dbname nvarchar(128)
SET @dbname = 'TP_WEB'

IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname 
OR name = @dbname)))
drop database TP_WEB

GO
use master
go
CREATE DATABASE TP_WEB
GO
USE TP_WEB
Go
CREATE TABLE Productos(
    Id BIGINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    Titulo VARCHAR(50) NOT NULL CHECK (LEN(Titulo) > 0),
    Descripcion VARCHAR(250) NOT NULL CHECK (LEN(Descripcion) > 0),
    URLImagen VARCHAR(1000) NOT NULL CHECK (LEN(URLImagen) > 0)
);

CREATE TABLE Clientes(
    Id BIGINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    DNI INT UNIQUE NOT NULL CHECK (DNI > 0),
    Nombre VARCHAR(50) NOT NULL CHECK (LEN(Nombre) > 0),
    Apellido VARCHAR(50) NOT NULL CHECK (LEN(Apellido) > 0),
    Email VARCHAR(100) NOT NULL CHECK (LEN(Email) > 0),
    Direccion VARCHAR(50) NOT NULL CHECK (LEN(Direccion) > 0),
    Ciudad VARCHAR(50) NOT NULL CHECK (LEN(Ciudad) > 0),
    CodigoPostal VARCHAR(8) NOT NULL CHECK (LEN(CodigoPostal) > 0),
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Vouchers(
    Id BIGINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    CodigoVoucher VARCHAR(32) UNIQUE DEFAULT CONVERT(VARCHAR(32), HashBytes('MD5', CONVERT(varchar, SYSDATETIME(), 121)), 2) CHECK (LEN(CodigoVoucher) = 32),
    Estado BIT NOT NULL DEFAULT 0 CHECK (Estado IN (1, 0)),
    IdCliente BIGINT DEFAULT NULL FOREIGN KEY REFERENCES Clientes(Id),
    IdProducto BIGINT DEFAULT NULL FOREIGN KEY REFERENCES Productos(Id),
    FechaRegistro DATETIME NULL DEFAULT NULL
);
-- esto agrega mil vouchers automaticamente. Que crack soy... de nada.
DECLARE @cnt INT = 0;
WHILE @cnt < 1000
BEGIN
   INSERT INTO TP_WEB.dbo.Vouchers (CodigoVoucher) VALUES (DEFAULT);
   SET @cnt = @cnt + 1;
   WAITFOR DELAY '00:00:00.002'
END;


select * from Productos
insert into Productos(Titulo, Descripcion, URLImagen) values('Excursión en Pingüinera - Ushuaia','Navegación por el Beagle y avistaje de pingüinos para dos personas','https://ushuaiaturismo.com/wp-content/uploads/2019/06/pinguinos-6.jpg')
insert into Productos(Titulo, Descripcion, URLImagen) values('Kayak y cena en Delta Tigre','Clase de kayak, recorrido por ríos internos del Delta y cena de 3 pasos para dos personas','https://sudeste-kayak.com.ar/wp-content/uploads/2018/07/medio-dia.jpg')
insert into Productos(Titulo, Descripcion, URLImagen) values('Escalada en roca en Sierra la Vigilancia Bs As','Trekking por las sierras, escalada y rapel con instructor para una persona','https://escaladauruguay.files.wordpress.com/2017/10/dsc05799.jpg?w=1200')


insert into Clientes(DNI,Nombre,Apellido,Direccion,Ciudad,CodigoPostal,Email,FechaRegistro)
values(35392047,'Daniela','Rubinstein','Ecuador 1642','Don Torcuato','1611','mrubinstein@gmail.com',GETDATE())

select * from Clientes
