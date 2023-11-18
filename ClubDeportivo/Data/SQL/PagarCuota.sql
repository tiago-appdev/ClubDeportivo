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
        UPDATE Cuotas c
        SET c.Pagada = 1
        WHERE c.Cuota_id IN (
            SELECT s.Cuota_id
            FROM Socios s
            WHERE s.Cliente_id IN (
                SELECT c.Cliente_id
                FROM Clientes c
                WHERE c.DNI = Dni
            )
        );
    ELSE
        UPDATE Cuotas c
        SET c.Pagada = 1
        WHERE c.Cuota_id IN (
            SELECT ns.Cuota_id
            FROM NoSocios ns
            WHERE ns.Cliente_id IN (
                SELECT c.Cliente_id
                FROM Clientes c
                WHERE c.DNI = Dni
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
