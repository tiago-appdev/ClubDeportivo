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
            numSocio.Text = socio.ToUpper();
            fecha.Text = fechaActual;
            tipoSocio.Text = tipo.ToUpper();
            formaPago.Text = formaDePago.ToUpper();
            montoPesos.Text = monto.ToString();
            nombreSocio.Text = nombre.ToUpper();
            label7.Text = "Nro. " + nroComprobante;

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;
                printPreviewDialog.ShowDialog();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf|All Files|*.*";
                saveFileDialog.Title = "Save Document";
                saveFileDialog.FileName = "Comprobante.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.PrinterSettings.PrintFileName = saveFileDialog.FileName;

                    pd.Print();

                    MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu menuPrincipal = new frmMenu();
                    menuPrincipal.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operación cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
