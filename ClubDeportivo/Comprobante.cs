using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ClubDeportivo
{
    public partial class FrmComprobante : Form
    {
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void ComprobanteForm_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            //pd.PrintPage += new PrintPageEventHandler();
            pd.Print();

            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu menuPrincipal = new frmMenu();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
