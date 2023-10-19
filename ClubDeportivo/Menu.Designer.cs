namespace ClubDeportivo
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            lblIngreso = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(73, 32);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "label1";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 32);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 179, 179);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTANA PRINCIPAL";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
    }
}