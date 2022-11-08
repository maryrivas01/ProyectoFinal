CREATE DATABASE FarmaciaLaboratorio_DaVida;

USE FarmaciaLaboratorio_DaVida;

CREATE TABLE Medicamentos(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	efectosSecundarios VARCHAR(200) NOT NULL,
	marca VARCHAR(50) NOT NULL,
	precio FLOAT NOT NULL,
	stock INT NOT NULL
);

CREATE TABLE Usuarios(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombreUsuario VARCHAR(50) NOT NULL,
	password VARCHAR(200) NOT NULL
);

CREATE TABLE Doctores(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	apellido VARCHAR(100) NOT NULL,
	edad INT NOT NULL,
	genero VARCHAR(20),
	especialidad VARCHAR(100) NOT NULL,
	codigo VARCHAR(50) NOT NULL,
	contraMedico VARCHAR(200) NOT NULL,
);

CREATE TABLE Pacientes(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	apellido VARCHAR(100) NOT NULL,
	edad INT NOT NULL,
	genero VARCHAR(20),
	codigo VARCHAR(50) NOT NULL,
	contraPaciente VARCHAR(200) NOT NULL,
);

--- PROCEDIMIENTOS ALMACENADOS --- 

------------- MOSTRAR ------------ 
CREATE PROC MostrarMedicamentos
AS
SELECT * FROM Medicamentos;

----------- INSERTAR -------------
CREATE PROC CrearMedicamentos
@nombre VARCHAR(100),
@descrip VARCHAR(200),
@efectosSec VARCHAR(200),
@marca VARCHAR(50),
@precio FLOAT,
@stock INT
AS
INSERT Medicamentos VALUES (@nombre,@descrip, @efectosSec,@marca,@precio,@stock);

----------- ELIMINAR -------------
CREATE PROC EliminarMedicamentos
@id INT
AS
DELETE FROM Medicamentos WHERE id=@id

--------- EDITAR ---------
CREATE PROC EditarMedicamentos
@nombre VARCHAR(100),
@descrip VARCHAR(200),
@efectosSec VARCHAR(200),
@marca VARCHAR(50),
@precio FLOAT,
@stock INT,
@id INT
AS
UPDATE Medicamentos SET nombre=@nombre, descripcion=@descrip, efectosSecundarios=@efectosSec, marca=@marca, precio=@precio, stock=@stock WHERE id=@id;

SELECT * FROM Medicamentos;

SELECT * FROM Usuarios;

--- PROCEDIMIENTOS ALMACENADOS --- 

------------- MOSTRAR ------------ 
CREATE PROC MostrarDoctores
AS
SELECT * FROM Doctores;

----------- INSERTAR -------------
CREATE PROC CrearDoctores
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@especialidad VARCHAR(100),
@codigo VARCHAR(50),
@contraMedico VARCHAR(200)
AS
INSERT Doctores VALUES (@nombre,@apellido, @edad,@genero,@especialidad,@codigo,@contraMedico);

----------- ELIMINAR -------------
CREATE PROC EliminarDoctores
@id INT
AS
DELETE FROM Doctores WHERE id=@id

--------- EDITAR ---------
CREATE PROC EditarDoctores
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@especialidad VARCHAR(100),
@codigo VARCHAR(50),
@contraMedico VARCHAR(200),
@id INT
AS
UPDATE Doctores SET nombre=@nombre, apellido=@apellido, edad=@edad, genero=@genero, especialidad=@especialidad, codigo=@codigo, contraMedico=@contraMedico WHERE id=@id;


--- PROCEDIMIENTOS ALMACENADOS --- 

------------- MOSTRAR ------------ 
CREATE PROC MostrarPacientes
AS
SELECT nombre, apellido, edad, genero FROM Pacientes;

----------- INSERTAR -------------
CREATE PROC CrearPacientes
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50),
@contraPaciente VARCHAR(200)
AS
INSERT Pacientes VALUES (@nombre, @apellido, @edad, @genero, @codigo, @contraPaciente);

----------- ELIMINAR -------------
CREATE PROC EliminarPacientes
@id INT
AS
DELETE FROM Pacientes WHERE id=@id

--------- EDITAR ---------
CREATE PROC EditarPacientes
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50),
@contraPaciente VARCHAR(200),
@id INT
AS
UPDATE Pacientes SET nombre=@nombre, apellido=@apellido, edad=@edad, genero=@genero, codigo=@codigo, contraPaciente=@contraPaciente WHERE id=@id;


select * from Pacientes;

select * from Usuarios;

select * from Doctores;