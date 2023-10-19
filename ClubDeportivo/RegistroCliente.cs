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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {


            frmMenu menuPrincipal = new frmMenu(); //Instanciamos el menu principal para mostrarlo.
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login

        }
    }
}
