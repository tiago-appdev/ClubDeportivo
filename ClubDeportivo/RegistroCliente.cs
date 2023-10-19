using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDireccion.Text == "" || cmbTipo.Text == "" || txtNumero.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                int? id;
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Telefono = txtNumero.Text;
                string Direccion = txtDireccion.Text;
                string TipoCliente = cmbTipo.Text;
                E_Cliente cliente = new(Nombre, Apellido, Direccion, Telefono, TipoCliente);
                // instanciamos para usar el metodo dentro de clientelantes
                Clientes clientes = new();
                id = clientes.RegistrarCliente(cliente);

                if (id != null)
                {
                    if (id == 0)
                    {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almaceno con exito con el codigo Nro " + id, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                    }
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
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menuPrincipal = new() //Instanciamos el menu principal para mostrarlo.
            {
                rol = frmInicio.rol,
                usuario = frmInicio.usuario
            };
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }
    }
}

