using MySql.Data.MySqlClient;
using System.Data;
using ClubDeportivo.Data;

namespace ClubDeportivo
{
    public partial class FrmCarnet : Form
    {
        public FrmCarnet()
        {
            InitializeComponent();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            FrmMenu menuPrincipal = new(); //Instanciamos el menu principal para mostrarlo.
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }

        private void verificarSocioButton_Click(object sender, EventArgs e)
        {
            var sqlCon = new MySqlConnection();
            try
            {
                if (socioNumberTextBox.Text == string.Empty)
                {
                    throw new Exception("Debe ingresar un número de socio");
                }
                sqlCon = Conexion.GetInstancia().CrearConexion();
                var comprobanteQuery = @"
SELECT
    CASE
        WHEN c.Tipo = 'Socio' THEN s.Numero_De_Socio
        WHEN c.Tipo = 'No Socio' THEN ns.Numero_De_NoSocio
        ELSE NULL
    END AS Numero_De_Socio,
    c.Nombre AS ClienteNombre,
    c.Apellido AS ClienteApellido,
    c.DNI AS ClienteDNI,
    c.Direccion AS ClienteDireccion,
    c.Telefono AS ClienteTelefono,
    c.Tipo AS TipoCliente,
    a.Nombre AS ActividadNombre,
    a.Precio AS ActividadPrecio,
    cu.FechaDeVencimiento AS CuotaFechaVencimiento,
    cu.Monto AS CuotaMonto,
    cu.Cuota_id,
    cu.Pagada,
    c.Activo,
    CASE
        WHEN c.Tipo = 'Socio' THEN 'Cuota Mensual'
        WHEN c.Tipo = 'No Socio' THEN 'Cuota por Actividad'
        ELSE 'Tipo no especificado'
    END AS Concepto
FROM
    Clientes c
LEFT JOIN Socios s ON c.Tipo = 'Socio' AND s.Cliente_id = c.Cliente_id
LEFT JOIN NoSocios ns ON c.Tipo = 'No Socio' AND ns.Cliente_id = c.Cliente_id
JOIN Cuotas cu ON COALESCE(s.Cuota_id, ns.Cuota_id) = cu.Cuota_id
LEFT JOIN Actividades a ON c.Tipo = 'No Socio' AND a.Numero_De_Actividad = cu.Cuota_id
WHERE
    c.Cliente_id = " + socioNumberTextBox.Text;
                var comando = new MySqlCommand(comprobanteQuery, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                var reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!reader.GetBoolean(13))
                    {
                        MessageBox.Show("El cliente está dado de baja", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (reader.GetString(6) == "Socio")
                    {
                        cliente = new Socio(reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), new Cuota(reader.GetDecimal(10)), reader.GetString(3));
                    }
                    else
                    {
                        MessageBox.Show("El numero no coincide con un socio", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    formularioDeCarnet.socio = reader.GetString(0);
                    formularioDeCarnet.nombre = cliente.Nombre + " " + cliente.Apellido;
                    formularioDeCarnet.dni = cliente.Dni;

                    formularioDeCarnet.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Número de socio inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }
    }
}
