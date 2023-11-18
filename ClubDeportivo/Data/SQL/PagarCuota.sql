USE ClubDeportivo_tastewhose;

DROP PROCEDURE IF EXISTS PagarCuota;

DELIMITER /
CREATE PROCEDURE PagarCuota(
    IN Dni VARCHAR(15),
    IN Tip ENUM('Socio', 'No Socio'),
    OUT paid BOOLEAN
)
BEGIN

    IF Tip = 'Socio' THEN
        UPDATE Cuotas
        SET Pagada = 1
        WHERE Cuota_id IN (
            SELECT Cuota_id
            FROM Socios
            WHERE Cliente_id IN (
                SELECT Cliente_id
                FROM Clientes
                WHERE DNI = dni
            )
        );
    ELSE
        UPDATE Cuotas
        SET Pagada = 1
        WHERE Cuota_id IN (
            SELECT Cuota_id
            FROM NoSocios
            WHERE Cliente_id IN (
                SELECT Cliente_id
                FROM Clientes
                WHERE DNI = dni
            )
        );
    END IF;
    UPDATE Clientes
    SET Activo = 1
    WHERE DNI = dni;

    IF ROW_COUNT() > 0 THEN
        SET paid = TRUE;
    ELSE
        SET paid = FALSE;
    END IF;
END;
/
DELIMITER;
