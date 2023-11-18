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
            btnRegistrar = new Button();
            btnPagarCuota = new Button();
            btnListar = new Button();
            btnNN2 = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(73, 32);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(34, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "USER";
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
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(73, 136);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(231, 48);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "REGISTRAR CLIENTE";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(513, 136);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(231, 48);
            btnPagarCuota.TabIndex = 3;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(73, 265);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(231, 48);
            btnListar.TabIndex = 4;
            btnListar.Text = "LISTAR CLIENTES MOROSOS";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListarMorosos_click;
            // 
            // btnNN2
            // 
            btnNN2.Location = new Point(513, 265);
            btnNN2.Name = "btnNN2";
            btnNN2.Size = new Size(231, 48);
            btnNN2.TabIndex = 5;
            btnNN2.Text = "NN";
            btnNN2.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 179, 179);
            ClientSize = new Size(800, 450);
            Controls.Add(btnNN2);
            Controls.Add(btnListar);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnRegistrar);
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
        private Button btnRegistrar;
        private Button btnPagarCuota;
        private Button btnListar;
        private Button btnNN2;
    }
}