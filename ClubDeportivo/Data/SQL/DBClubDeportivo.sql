DROP DATABASE IF EXISTS ClubDeportivo_tastewhose;

CREATE DATABASE ClubDeportivo_tastewhose;

USE ClubDeportivo_tastewhose;

DROP TABLE IF EXISTS `Actividades`;
CREATE TABLE `Actividades` (
  `Numero_De_Actividad` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  `Descripcion` text,
  PRIMARY KEY (`Numero_De_Actividad`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


DROP TABLE IF EXISTS `Clientes`;
CREATE TABLE `Clientes` (
  `Cliente_id` int NOT NULL AUTO_INCREMENT,
  `Apellido` varchar(255) NOT NULL,
  `Nombre` varchar(255) NOT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Activo` tinyint(1) NOT NULL DEFAULT '0',
  `Tipo` enum('Socio','No Socio') NOT NULL DEFAULT 'No Socio',
  `DNI` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Cliente_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Cuotas`;
CREATE TABLE `Cuotas` (
  `Cuota_id` int NOT NULL AUTO_INCREMENT,
  `FechaDeVencimiento` date NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `Pagada` tinyint(1) NOT NULL,
  PRIMARY KEY (`Cuota_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `NoSocios`;
CREATE TABLE `NoSocios` (
  `Numero_De_NoSocio` int NOT NULL AUTO_INCREMENT,
  `Cliente_id` int DEFAULT NULL,
  `Cuota_id` int DEFAULT NULL,
  PRIMARY KEY (`Numero_De_NoSocio`),
  UNIQUE KEY `Cliente_id` (`Cliente_id`),
  KEY `Cuota_id` (`Cuota_id`),
  CONSTRAINT `NoSocios_ibfk_1` FOREIGN KEY (`Cliente_id`) REFERENCES `Clientes` (`Cliente_id`),
  CONSTRAINT `NoSocios_ibfk_2` FOREIGN KEY (`Cuota_id`) REFERENCES `Cuotas` (`Cuota_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `Socios`;
CREATE TABLE `Socios` (
  `Numero_De_Socio` int NOT NULL AUTO_INCREMENT,
  `Cliente_id` int DEFAULT NULL,
  `Cuota_id` int NOT NULL,
  PRIMARY KEY (`Numero_De_Socio`),
  UNIQUE KEY `Cliente_id` (`Cliente_id`),
  KEY `Cuota_id` (`Cuota_id`),
  CONSTRAINT `Socios_ibfk_1` FOREIGN KEY (`Cliente_id`) REFERENCES `Clientes` (`Cliente_id`),
  CONSTRAINT `Socios_ibfk_2` FOREIGN KEY (`Cuota_id`) REFERENCES `Cuotas` (`Cuota_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
DROP TABLE IF EXISTS `Usuarios`;

CREATE TABLE `Usuarios` (
  `Usuario_id` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) NOT NULL,
  `PASSWORD` varchar(15) NOT NULL,
  `Is_admin` tinyint(1) NOT NULL,
  PRIMARY KEY (`Usuario_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
