USE ClubDeportivo;

DELIMITER / CREATE PROCEDURE RegistrarCliente(
    IN Nom VARCHAR(255),
    IN Ape VARCHAR(255),
    IN Tel VARCHAR(15),
    IN Dir VARCHAR(255),
    IN Tip ENUM('Socio', 'No Socio'),
    OUT id INT
) BEGIN DECLARE existe INT DEFAULT 0;

SELECT
    COUNT(*) INTO existe
FROM
    Clientes
WHERE
    Nombre = Nom
    AND Apellido = Ape
    AND Direccion = Dir;

IF existe = 0 THEN
INSERT INTO
    Clientes (
        Apellido,
        Direccion,
        Nombre,
        Telefono,
        Tipo_cliente
    )
VALUES
    (Ape, Dir, Nom, Tel, Tip);

SET
    id = LAST_INSERT_ID();

IF Tip = 'Socio' THEN
INSERT INTO
    Cuotas (FechaDeVencimiento, Monto, Pagada)
VALUES
    (DATE_ADD(CURDATE(), INTERVAL 1 MONTH), 500, 0);

INSERT INTO
    Socios (Cliente_id, Cuota_id)
VALUES
    (id, LAST_INSERT_ID());

ELSE
INSERT INTO
    Cuotas (FechaDeVencimiento, Monto, Pagada)
VALUES
    (DATE_ADD(CURDATE(), INTERVAL 1 DAY), 500, 0);
INSERT INTO
    NoSocios (Cliente_id, Cuota_id)
VALUES
    (id, LAST_INSERT_ID());

END IF;

ELSE
SET
    id = 0;

END IF;

END;

/ DELIMITER;