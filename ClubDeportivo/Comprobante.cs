using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using iText.Kernel.Pdf;
using iText.Layout;

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
            numSocio.Text = socio;
            fecha.Text = fechaActual;
            tipoSocio.Text = tipo.ToUpper();
            formaPago.Text = formaDePago;
            montoPesos.Text = monto.ToString(CultureInfo.InvariantCulture);
            nombreSocio.Text = nombre.ToUpper();
            label7.Text = nroComprobante;
            label10.Text = "NRO. " + tipo.ToUpper();
            numSocio.Location = tipo == "Socio" ? new Point(400, 246) : new Point(448, 246);

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                buttonImprimir.Visible = false;

                var pd = new PrintDocument();
                pd.PrintPage += ImprimirForm1;

                var printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;
                printPreviewDialog.Document.PrinterSettings.PrintToFile = false;
                printPreviewDialog.ShowDialog();

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "Comprobante.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    var bmp = ScreenshotDeFormulario(this);

                    bmp.Save("temp.png", ImageFormat.Png);

                    using (var writer = new PdfWriter(filePath))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            var pageSize = new iText.Kernel.Geom.PageSize(bmp.Width, bmp.Height);
                            pdf.SetDefaultPageSize(pageSize);

                            var img = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("temp.png"));
                            document.Add(img);

                            document.Close();
                        }
                    }

                    File.Delete("temp.png");

                    MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Operación cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipo == "Socio")
                {
                    formularioDeCarnet.nombre = nombre;
                    formularioDeCarnet.socio = socio;
                    formularioDeCarnet.dni = dni;
                    formularioDeCarnet.Show();
                }
                else
                {
                    var menuPrincipal = new FrmMenu();
                    menuPrincipal.Show();
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Bitmap ScreenshotDeFormulario(Form window)
        {
            var b = new Bitmap(window.Width, window.Height);
            window.DrawToBitmap(b, new Rectangle(0, 0, window.Width, window.Height));

            var p = window.PointToScreen(Point.Empty);

            var target = new Bitmap(window.ClientSize.Width, window.ClientSize.Height);
            using (var g = Graphics.FromImage(target))
            {
                g.DrawImage(b, 0, 0,
                            new Rectangle(p.X - window.Location.X, p.Y - window.Location.Y,
                                          target.Width, target.Height),
                           GraphicsUnit.Pixel);
            }
            b.Dispose();
            return target;
        }


        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            try
            {
                var bmp = ScreenshotDeFormulario(this);

                e.Graphics?.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);

                bmp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
