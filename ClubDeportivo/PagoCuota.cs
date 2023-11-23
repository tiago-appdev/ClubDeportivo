using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using ClubDeportivo.Data;

namespace ClubDeportivo
{
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Chequear condiciones para habilitar o deshabilitar el boton de pago
            var isCuotaAmountValid = !string.IsNullOrEmpty(cuotaAmountTextBox.Text);
            var isFormaDePagoSelected = radioButton1.Checked || ((radioButton2.Checked && !string.IsNullOrEmpty(cardNumberTextBox.Text) && !string.IsNullOrEmpty(cardExpirationTextBox.Text) && !string.IsNullOrEmpty(cardCvvTextBox.Text)));
            var isActivitySelected = activityComboBox.SelectedIndex != -1 || (cliente != null && cliente.Tipo != "No Socio");
            pagarButton.Enabled = isCuotaAmountValid && isFormaDePagoSelected && isActivitySelected;
        }


        private void pagarButton_Click(object sender, EventArgs e)
        {
            comprobante.fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            comprobante.formaDePago = radioButton1.Checked ? "EFECTIVO" : "TARJETA";


            try
            {
                Clientes clientesDb = new();
                clientesDb.PagarCuota(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            comprobante.Show();
            this.Hide();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            FrmMenu menuPrincipal = new(); //Instanciamos el menu principal para mostrarlo.
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var isTarjetaSelected = radioButton2.Checked;
            label4.Visible = isTarjetaSelected;
            cardNumberTextBox.Visible = isTarjetaSelected;
            label5.Visible = isTarjetaSelected;
            cardExpirationTextBox.Visible = isTarjetaSelected;
            label6.Visible = isTarjetaSelected;
            cardCvvTextBox.Visible = isTarjetaSelected;
            label7.Visible = isTarjetaSelected;
            cuotasComboBox.Visible = isTarjetaSelected;
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
                    if (reader.GetBoolean(12))
                    {
                        MessageBox.Show("No tiene cuotas impagas", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (reader.GetString(6) == "Socio")
                    {
                        cliente = new Socio(reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), new Cuota(reader.GetDecimal(10)), reader.GetString(3));
                    }
                    else
                    {
                        cliente = new NoSocio(reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), new Cuota(reader.GetDecimal(8)), reader.GetString(3));
                        label2.Visible = true;
                        cuotaAmountTextBox.Location = new Point(cuotaAmountTextBox.Location.X, cuotaAmountTextBox.Location.Y + 35);
                        label3.Location = new Point(label3.Location.X, label3.Location.Y + 35);
                        radioButton1.Location = new Point(radioButton1.Location.X, radioButton1.Location.Y + 35);
                        radioButton2.Location = new Point(radioButton2.Location.X, radioButton2.Location.Y + 35);
                        volverButton.Location = new Point(volverButton.Location.X, volverButton.Location.Y + 35);
                        pagarButton.Location = new Point(pagarButton.Location.X, pagarButton.Location.Y + 35);
                        activityComboBox.Visible = true;
                    }

                    comprobante.socio = reader.GetString(0);
                    comprobante.tipo = cliente.Tipo;
                    if (cliente.Cuota == null) return;
                    comprobante.monto = cliente.Cuota.Monto;
                    comprobante.nombre = cliente.Nombre + " " + cliente.Apellido;
                    comprobante.nroComprobante = reader.GetString(11);
                    comprobante.dni = cliente.Dni;

                    cuotaAmountTextBox.Text = cliente.Cuota.Monto.ToString(CultureInfo.InvariantCulture);
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
