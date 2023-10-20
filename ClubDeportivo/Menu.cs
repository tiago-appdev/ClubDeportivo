using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
