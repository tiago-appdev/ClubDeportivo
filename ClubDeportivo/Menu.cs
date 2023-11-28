using System.Data;
using ClubDeportivo.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + FrmInicio.Usuario + " " + "(" + FrmInicio.Rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // click en el boton de X para cerrar el formulario
            Application.Exit();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registro = new FrmRegistro();
            registro.Show();
            this.Hide();
        }
        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            var formularioDePago = new FrmPago();
            formularioDePago.Show();
            this.Hide();
        }
        private void btnListarMorosos_click(object sender, EventArgs e)
        {
            var formularioDeMorosos = new FrmLista();
            formularioDeMorosos.Show();
            this.Hide();
        }
        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            var formularioDeReimpresion = new FrmCarnet();
            formularioDeReimpresion.Show();
            this.Hide();
        }


    }
}
