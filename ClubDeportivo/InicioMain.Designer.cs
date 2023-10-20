namespace ClubDeportivo
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            pictureInicio = new PictureBox();
            lblInicio = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureInicio).BeginInit();
            SuspendLayout();
            // 
            // pictureInicio
            // 
            pictureInicio.Image = (Image)resources.GetObject("pictureInicio.Image");
            pictureInicio.Location = new Point(51, 71);
            pictureInicio.Name = "pictureInicio";
            pictureInicio.Size = new Size(267, 294);
            pictureInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureInicio.TabIndex = 0;
            pictureInicio.TabStop = false;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInicio.Location = new Point(496, 71);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(197, 18);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "INGRESO AL SISTEMA";
            lblInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(443, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(288, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Tag = "";
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(443, 211);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(288, 23);
            txtPass.TabIndex = 3;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Location = new Point(548, 292);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 39);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 179, 179);
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(lblInicio);
            Controls.Add(pictureInicio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            ((System.ComponentModel.ISupportInitialize)pictureInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureInicio;
        private Label lblInicio;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
    }
}