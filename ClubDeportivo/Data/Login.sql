USE ClubDeportivo;

delimiter / 
CREATE PROCEDURE Login(IN Usu varchar(20), IN Pass varchar(15)) 
BEGIN
    SELECT
        Is_admin
    FROM
        Usuarios u
    WHERE
        Username = Usu
        AND PASSWORD = Pass;
END;

/ delimiter;