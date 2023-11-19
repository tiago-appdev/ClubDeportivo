using System.Drawing.Imaging;
using System.Drawing.Printing;
using iText.Kernel.Pdf;
using iText.Layout;


namespace ClubDeportivo
{
    public partial class FrmCredencialSocio : Form
    {
        public FrmCredencialSocio()
        {
            InitializeComponent();
        }
        private void CredencialSocio_Load(object sender, EventArgs e)
        {
            numSocio.Text = socio;
            string[] nameParts = nombre.Split(' ');

            string firstName = (nameParts.Length > 0) ? nameParts[0] : string.Empty;
            string lastName = (nameParts.Length > 1) ? nameParts[1] : string.Empty;

            string formattedName = $"{firstName}{Environment.NewLine}{lastName}";

            nombreCortoSocio.Text = formattedName.ToUpper();

            // autogenerar numero de tarjeta en base a datos de cliente
            string generatedNumber = GenerateCredentialNumber(dni, socio);
            nroTarjeta.Text = generatedNumber;
        }

        private string GenerateCredentialNumber(string dni, string socioNumber)
        {
            string year = DateTime.Now.Year.ToString().Substring(2);

            dni = dni.PadLeft(8, '0').Substring(0, 8);
            socioNumber = socioNumber.PadLeft(2, '0').Substring(0, 2);

            string generatedNumber = $"{dni}{socioNumber}{year}";

            return $"{generatedNumber.Substring(0, 4)} {generatedNumber.Substring(4, 4)} {generatedNumber.Substring(8, 4)}";
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
                saveFileDialog.FileName = "Carnet.pdf";

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

                }
                else
                {
                    MessageBox.Show("Operación cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmMenu menuPrincipal = new frmMenu();
                menuPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Bitmap ScreenshotDeFormulario(FrmCredencialSocio form)
        {
            Bitmap background = new Bitmap(form.Width, form.Height);

            using (Graphics g = Graphics.FromImage(background))
            {
                form.DrawToBitmap(background, new Rectangle(0, 0, form.Width, form.Height));
            }

            Point p = form.PointToScreen(Point.Empty);

            Bitmap target = new Bitmap(form.ClientSize.Width, form.ClientSize.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(background, 0, 0,
            new Rectangle(p.X - form.Location.X, p.Y - form.Location.Y,
                          target.Width, target.Height),
           GraphicsUnit.Pixel);


                g.DrawImage(form.pictureBox2.Image, form.pictureBox2.Location.X, form.pictureBox2.Location.Y, form.pictureBox2.Width, form.pictureBox2.Height);

                g.DrawString(form.label1.Text, form.label1.Font, Brushes.Black, form.label1.Location.X, form.label1.Location.Y);
                g.DrawString(form.nombreCortoSocio.Text, form.nombreCortoSocio.Font, Brushes.Black, form.nombreCortoSocio.Location.X, form.nombreCortoSocio.Location.Y);
                g.DrawString(form.numSocio.Text, form.numSocio.Font, Brushes.Black, form.numSocio.Location.X, form.numSocio.Location.Y);
                g.DrawString(form.label4.Text, form.label4.Font, Brushes.Black, form.label4.Location.X, form.label4.Location.Y);
                g.DrawString(form.label5.Text, form.label5.Font, Brushes.Black, form.label5.Location.X, form.label5.Location.Y);
                g.DrawString(form.nroTarjeta.Text, form.nroTarjeta.Font, Brushes.Black, form.nroTarjeta.Location.X, form.nroTarjeta.Location.Y);


            }

            background.Dispose();
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
