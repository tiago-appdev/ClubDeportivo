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
    public partial class FrmComprobante : Form
    {
        public FrmComprobante()
        {
            InitializeComponent();
        }

        private void ComprobanteForm_Load(object sender, EventArgs e)
        {
            // Set the text properties of controls based on the variables
            socioLabel.Text = $"Socio: {socio}";
            typeLabel.Text = $"Tipo: {tipo}";
            formaPagoLabel.Text = $"Forma de Pago: {formaDePago}";
            montoLabel.Text = $"Monto: {monto:C}";
            dateLabel.Text = $"Fecha: {fecha_f.ToShortDateString()}";
        }
    }
}
