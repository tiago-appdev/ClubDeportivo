namespace ClubDeportivo
{
    partial class FrmLista
    {
        public System.Windows.Forms.DataGridView dataGridViewCuotasPendientes;
        private System.Windows.Forms.Button volverMainMenuButton;

        private void InitializeComponent()
        {
            volverMainMenuButton = new Button();
            dataGridViewCuotasPendientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasPendientes).BeginInit();
            SuspendLayout();
            // 
            // volverMainMenuButton
            // 
            volverMainMenuButton.Location = new Point(372, 447);
            volverMainMenuButton.Name = "volverMainMenuButton";
            volverMainMenuButton.Size = new Size(88, 27);
            volverMainMenuButton.TabIndex = 3;
            volverMainMenuButton.Text = "VOLVER";
            volverMainMenuButton.UseVisualStyleBackColor = true;
            volverMainMenuButton.Click += volverMainMenuButton_Click;
            // 
            // dataGridViewCuotasPendientes
            // 
            dataGridViewCuotasPendientes.AllowUserToAddRows = false;
            dataGridViewCuotasPendientes.AllowUserToDeleteRows = false;
            dataGridViewCuotasPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuotasPendientes.Location = new Point(40, 12);
            dataGridViewCuotasPendientes.Name = "dataGridViewCuotasPendientes";
            dataGridViewCuotasPendientes.ReadOnly = true;
            dataGridViewCuotasPendientes.Size = new Size(776, 426);
            dataGridViewCuotasPendientes.TabIndex = 0;
            // 
            // FrmLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 486);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            Controls.Add(dataGridViewCuotasPendientes);
            Controls.Add(volverMainMenuButton);
            Name = "FrmLista";
            Text = "Cuotas Pendientes";
            Load += CuotasPendientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotasPendientes).EndInit();
            ResumeLayout(false);
        }

        private void CuotasPendientesForm_Load(object sender, EventArgs e)
        {

        }

        private void volverMainMenuButton_Click(object sender, EventArgs e)
        {
            FrmMenu menuPrincipal = new FrmMenu();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
