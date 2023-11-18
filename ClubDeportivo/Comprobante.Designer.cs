

namespace ClubDeportivo
{
    partial class FrmComprobante
    {
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox socioInfoGroupBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label socioLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label formaPagoLabel;
        private System.Windows.Forms.Label montoLabel;

        private void InitializeComponent()
        {
            titleLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            socioInfoGroupBox = new System.Windows.Forms.GroupBox();
            socioLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            formaPagoLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();

            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(100, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(150, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Comprobante";

            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(50, 70);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(120, 15);
            companyLabel.TabIndex = 1;
            companyLabel.Text = "Club Deportivo";

            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(300, 70);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(80, 15);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date: [Date]";

            // 
            // socioInfoGroupBox
            // 
            socioInfoGroupBox.Controls.Add(socioLabel);
            socioInfoGroupBox.Controls.Add(typeLabel);
            socioInfoGroupBox.Controls.Add(nameLabel);
            socioInfoGroupBox.Controls.Add(dniLabel);
            socioInfoGroupBox.Controls.Add(formaPagoLabel);
            socioInfoGroupBox.Controls.Add(montoLabel);
            socioInfoGroupBox.Location = new System.Drawing.Point(50, 120);
            socioInfoGroupBox.Name = "socioInfoGroupBox";
            socioInfoGroupBox.Size = new System.Drawing.Size(500, 200);
            socioInfoGroupBox.TabIndex = 3;
            socioInfoGroupBox.TabStop = false;
            socioInfoGroupBox.Text = "Información del Socio";

            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(20, 30);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(80, 15);
            typeLabel.TabIndex = 0;

            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(80, 15);
            nameLabel.TabIndex = 1;

            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(20, 110);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(70, 15);
            dniLabel.TabIndex = 2;

            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(20, 150);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(120, 15);
            formaPagoLabel.TabIndex = 3;

            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(20, 190);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(80, 15);
            montoLabel.TabIndex = 4;

            Controls.Add(titleLabel);
            Controls.Add(companyLabel);
            Controls.Add(dateLabel);
            Controls.Add(socioInfoGroupBox);

        }

        public string socio;
        public string tipo;
        public string formaDePago;
        private string? actividad;
        public Decimal monto;
        public DateTime fecha_f = DateTime.Now;

    }
}
