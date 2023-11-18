USE ClubDeportivo_tastewhose;

DROP PROCEDURE IF EXISTS RegistrarCliente;

DELIMITER / CREATE PROCEDURE RegistrarCliente(
    IN Nom VARCHAR(255),
    IN Ape VARCHAR(255),
    IN Tel VARCHAR(15),
    IN Dni VARCHAR(15),
    IN Dir VARCHAR(255),
    IN Mon DECIMAL(10, 2),
    IN Tip ENUM('Socio', 'No Socio'),
    OUT id INT
) BEGIN DECLARE existe INT DEFAULT 0;

SELECT
    COUNT(*) INTO existe
FROM
    Clientes c
WHERE
    c.DNI = Dni;

SELECT existe; 

SET
    id = 0;

IF existe = 0 THEN
INSERT INTO
    Clientes (Apellido, Direccion, Nombre, Telefono, Tipo, DNI)
VALUES
    (Ape, Dir, Nom, Tel, Tip, Dni);

SET
    id = LAST_INSERT_ID();

IF Tip = 'Socio' THEN
INSERT INTO
    Cuotas (FechaDeVencimiento, Monto, Pagada)
VALUES
    (DATE_ADD(CURDATE(), INTERVAL 1 MONTH), Mon, 0);

INSERT INTO
    Socios (Cliente_id, Cuota_id)
VALUES
    (id, LAST_INSERT_ID());


ELSE
INSERT INTO
    Cuotas (FechaDeVencimiento, Monto, Pagada)
VALUES
    (DATE_ADD(CURDATE(), INTERVAL 1 DAY), Mon, 0);

INSERT INTO
    NoSocios (Cliente_id, Cuota_id)
VALUES
    (id, LAST_INSERT_ID());

END IF;

END IF;

END;

/ DELIMITER;