namespace ClubDeportivo
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDireccion.Text == "" || cmbTipo.Text == "" || txtNumero.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtNumero.Text;
                string direccion = txtDireccion.Text;
                string tipoCliente = cmbTipo.Text;
                string dni = txtDni.Text;

                Cliente cliente;

                // El cobro es distinto dependiendo del tipo de socio
                if (tipoCliente == "Socio")
                {
                    cliente = new Socio(nombre, apellido, direccion, telefono, new Cuota((decimal)500.00), 0, dni);
                }
                else
                {
                    cliente = new NoSocio(nombre, apellido, direccion, telefono, new Cuota((decimal)250.00), 0, dni);
                }

                try
                {
                    int? id = cliente.RegistrarCliente(cliente);
                    MessageBox.Show("Se almaceno con exito con el codigo Nro" + id, "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNumero.Text = "";
            cmbTipo.Text = "";
            txtDni.Text = "";
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menuPrincipal = new() //Instanciamos el menu principal para mostrarlo.
            {
                rol = FrmInicio.Rol,
                usuario = FrmInicio.Usuario
            };
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

