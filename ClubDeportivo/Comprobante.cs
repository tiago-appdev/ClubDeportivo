using System.Drawing.Imaging;
using System.Drawing.Printing;
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
                buttonImprimir.Visible = false;

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = pd;
                printPreviewDialog.ShowDialog();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "Comprobante.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Bitmap bmp = ScreenshotDeFormulario(this);

                    bmp.Save("temp.png", ImageFormat.Png);

                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            Document document = new Document(pdf);

                            iText.Kernel.Geom.PageSize pageSize = new iText.Kernel.Geom.PageSize(bmp.Width, bmp.Height);
                            pdf.SetDefaultPageSize(pageSize);

                            iText.Layout.Element.Image img = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create("temp.png"));
                            document.Add(img);

                            document.Close();
                        }
                    }

                    File.Delete("temp.png");

                    MessageBox.Show("Operación existosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu menuPrincipal = new frmMenu();
                    menuPrincipal.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Operación cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Bitmap ScreenshotDeFormulario(Form window)
        {
            var b = new Bitmap(window.Width, window.Height);
            window.DrawToBitmap(b, new Rectangle(0, 0, window.Width, window.Height));

            Point p = window.PointToScreen(Point.Empty);

            Bitmap target = new Bitmap(window.ClientSize.Width, window.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(target))
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
                Bitmap bmp = ScreenshotDeFormulario(this);

                e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);

                bmp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
