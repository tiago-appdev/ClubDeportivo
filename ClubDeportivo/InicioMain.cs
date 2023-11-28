using ClubDeportivo.Data;

namespace ClubDeportivo
{
    public partial class FrmInicio : Form
    {
        public static string? Usuario { get; private set; }
        public static string? Rol { get; private set; }

        public FrmInicio()
        {
            InitializeComponent();
            this.FormClosing += FrmInicio_FormClosing;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == @"USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = @"USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text != @"CONTRASEÑA") return;
            txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
        }


        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = @"CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios dato = new(); // variable que contiene todas las caracteristicas de la clase
            var tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text); // es la que recibe los datos desde el formulario
            if (tablaLogin.Rows.Count > 0)
            {
                FrmInicio.Rol = Convert.ToInt32(tablaLogin.Rows[0][0]) == 1 ? "ADMINISTRATOR" : "USER";
                FrmInicio.Usuario = Convert.ToString(txtUsuario.Text).ToUpper();
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show(@"Ingreso exitoso", @"Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Instanciamos el menu principal para mostrarlo.
                FrmMenu menuPrincipal = new();
                menuPrincipal.Show(); //Se muestra el menu principal
                this.Hide(); // se oculta el formulario del login
            }
            else
            {
                MessageBox.Show(@"Usuario y/o password incorrecto", @"Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
