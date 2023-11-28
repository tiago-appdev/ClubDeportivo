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
                var nombre = txtNombre.Text;
                var apellido = txtApellido.Text;
                var telefono = txtNumero.Text;
                var direccion = txtDireccion.Text;
                var tipoCliente = cmbTipo.Text;
                var dni = txtDni.Text;

                Cliente cliente;

                // El cobro es distinto dependiendo del tipo de socio
                if (tipoCliente == "Socio")
                {
                    cliente = new Socio(nombre, apellido, direccion, telefono, new Cuota((decimal)500.00), dni);
                }
                else
                {
                    cliente = new NoSocio(nombre, apellido, direccion, telefono, new Cuota((decimal)250.00), dni);
                }

                try
                {
                    var id = cliente.RegistrarCliente(cliente);
                    MessageBox.Show("Se almaceno con exito con el numero de cliente: " + id, "AVISO",
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
            FrmMenu menuPrincipal = new(); //Instanciamos el menu principal para mostrarlo.

            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }

    }
}

