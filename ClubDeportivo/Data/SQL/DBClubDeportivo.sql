DROP DATABASE IF EXISTS ClubDeportivo_tastewhose;

CREATE DATABASE ClubDeportivo_tastewhose;

USE ClubDeportivo_tastewhose;

CREATE TABLE Usuarios (
    Usuario_id INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(20) NOT NULL,
    PASSWORD VARCHAR(15) NOT NULL,
    Is_admin BOOLEAN NOT NULL
);

CREATE TABLE Cuotas (
    Cuota_id INT PRIMARY KEY AUTO_INCREMENT,
    FechaDeVencimiento DATE NOT NULL,
    Monto DECIMAL(10, 2) NOT NULL,
    Pagada BOOLEAN NOT NULL
);

CREATE TABLE Clientes (
    Cliente_id INT PRIMARY KEY AUTO_INCREMENT,
    Apellido VARCHAR(255) NOT NULL,
    Nombre VARCHAR(255) NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(15) NOT NULL,
    Activo BOOLEAN DEFAULT 0 NOT NULL,
    Tipo ENUM('Socio', 'No Socio') NOT NULL
);

CREATE TABLE Socios (
    Numero_De_Socio INT PRIMARY KEY AUTO_INCREMENT,
    Cliente_id INT UNIQUE,
    Cuota_id INT NOT NULL,
    FOREIGN KEY (Cliente_id) REFERENCES Clientes(Cliente_id),
    FOREIGN KEY (Cuota_id) REFERENCES Cuotas(Cuota_id)
);

CREATE TABLE NoSocios (
    Numero_De_NoSocio INT PRIMARY KEY AUTO_INCREMENT,
    Cliente_id INT UNIQUE,
    Cuota_id INT,
    FOREIGN KEY (Cliente_id) REFERENCES Clientes(Cliente_id),
    FOREIGN KEY (Cuota_id) REFERENCES Cuotas(Cuota_id)
);

CREATE TABLE Actividades (
    Numero_De_Actividad INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(255) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Descripcion TEXT
);

INSERT INTO
    Actividades (Nombre, Descripcion, precio)
VALUES
    ('Activity 1', 'Description for Activity 1', 500),
    ('Activity 2', 'Description for Activity 2', 200);

INSERT INTO
    Usuarios (Username, PASSWORD, is_admin)
VALUES
    ('admin1', 'admin1', TRUE),
    ('admin2', 'admin2', TRUE),
    ('user1', 'user1', FALSE);
