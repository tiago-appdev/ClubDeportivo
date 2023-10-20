namespace ClubDeportivo
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            pictureRegistro = new PictureBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            cmbTipo = new ComboBox();
            txtNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTitle = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureRegistro).BeginInit();
            SuspendLayout();
            // 
            // pictureRegistro
            // 
            pictureRegistro.Image = (Image)resources.GetObject("pictureRegistro.Image");
            pictureRegistro.Location = new Point(12, 81);
            pictureRegistro.Name = "pictureRegistro";
            pictureRegistro.Size = new Size(218, 266);
            pictureRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureRegistro.TabIndex = 0;
            pictureRegistro.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(440, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(440, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(259, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(440, 220);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(259, 23);
            txtDireccion.TabIndex = 3;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Socio", "No Socio" });
            cmbTipo.Location = new Point(334, 286);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(97, 23);
            cmbTipo.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(582, 286);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(160, 23);
            txtNumero.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 104);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(334, 166);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 7;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(334, 221);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 8;
            label3.Text = "DIRECCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 289);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 9;
            label4.Text = "TIPO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(512, 287);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 10;
            label5.Text = "NÚMERO";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.Location = new Point(440, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 25);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "REGISTRO DE CLIENTE";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(334, 381);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(512, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(667, 381);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 255, 199);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(cmbTipo);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(pictureRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE CLIENTE (SOCIO / NO SOCIO)";
            ((System.ComponentModel.ISupportInitialize)pictureRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureRegistro;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private ComboBox cmbTipo;
        private TextBox txtNumero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTitle;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}