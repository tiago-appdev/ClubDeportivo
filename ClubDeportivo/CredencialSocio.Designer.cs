namespace ClubDeportivo
{
    partial class FrmCredencialSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCredencialSocio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nombreCortoSocio = new Label();
            numSocio = new Label();
            label4 = new Label();
            label5 = new Label();
            nroTarjeta = new Label();
            pictureBox2 = new PictureBox();
            buttonImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(248, 242, 228);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(425, 88);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 1;
            label1.Text = "CREDENCIAL SOCIO\r";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreCortoSocio
            // 
            nombreCortoSocio.AutoSize = true;
            nombreCortoSocio.BackColor = Color.FromArgb(248, 242, 228);
            nombreCortoSocio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            nombreCortoSocio.Location = new Point(399, 153);
            nombreCortoSocio.Name = "nombreCortoSocio";
            nombreCortoSocio.Size = new Size(0, 45);
            nombreCortoSocio.TabIndex = 2;
            // 
            // numSocio
            // 
            numSocio.AutoSize = true;
            numSocio.BackColor = Color.FromArgb(248, 242, 228);
            numSocio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            numSocio.Location = new Point(548, 206);
            numSocio.Name = "numSocio";
            numSocio.Size = new Size(0, 37);
            numSocio.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(248, 242, 228);
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(425, 216);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 4;
            label4.Text = "SOCIO NRO.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(248, 242, 228);
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(187, 269);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 5;
            label5.Text = "TARJETA";
            // 
            // nroTarjeta
            // 
            nroTarjeta.AutoSize = true;
            nroTarjeta.BackColor = Color.FromArgb(248, 242, 228);
            nroTarjeta.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            nroTarjeta.Location = new Point(203, 299);
            nroTarjeta.Name = "nroTarjeta";
            nroTarjeta.Size = new Size(408, 72);
            nroTarjeta.TabIndex = 6;
            nroTarjeta.Text = "0123 4567 8901";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(248, 242, 228);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(137, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(189, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImprimir.Location = new Point(620, 408);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(93, 30);
            buttonImprimir.TabIndex = 12;
            buttonImprimir.Text = "IMPRIMIR";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += buttonImprimir_Click;
            // 
            // FrmCredencialSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 179, 179);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonImprimir);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(nroTarjeta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numSocio);
            Controls.Add(nombreCortoSocio);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCredencialSocio";
            Text = "CredencialSocio";
            Load += CredencialSocio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label nombreCortoSocio;
        private Label numSocio;
        private Label label4;
        private Label label5;
        private Label nroTarjeta;
        public String socio;
        public String nombre;
        private PictureBox pictureBox2;
        private Button buttonImprimir;
    }
}