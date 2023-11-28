using System.Data;
using ClubDeportivo.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }


        private void volverMainMenuButton_Click(object sender, EventArgs e)
        {
            FrmMenu menuPrincipal = new FrmMenu();
            menuPrincipal.Show();
            this.Hide();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            try
            {
                var sqlCon = Conexion.GetInstancia().CrearConexion();

                const string query = @"
SELECT
    CONCAT(c.Nombre, ' ', c.Apellido) AS ClienteNombre,
    c.DNI AS DniCliente,
    c.Direccion AS ClienteDireccion,
    cu.FechaDeVencimiento AS CuotaFechaVencimiento,
    cu.Monto AS CuotaMonto,
    CASE
        WHEN c.Tipo = 'Socio' THEN 'Cuota Mensual'
        WHEN c.Tipo = 'No Socio' THEN 'Cuota por Actividad'
        ELSE 'Tipo no especificado'
    END AS Concepto
FROM
    Clientes c
    JOIN Cuotas cu ON (
        (c.Tipo = 'Socio' AND EXISTS (SELECT 1 FROM Socios s WHERE s.Cliente_id = c.Cliente_id AND s.Cuota_id = cu.Cuota_id))
        OR
        (c.Tipo = 'No Socio' AND EXISTS (SELECT 1 FROM NoSocios ns WHERE ns.Cliente_id = c.Cliente_id AND ns.Cuota_id = cu.Cuota_id))
    )
WHERE
    cu.FechaDeVencimiento < CURDATE() AND cu.Pagada = 0;";

                var cmd = new MySqlCommand(query, sqlCon);
                var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();

                sqlCon.Open();
                da.Fill(dt);
                sqlCon.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay clientes morosos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.dataGridViewCuotasPendientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
