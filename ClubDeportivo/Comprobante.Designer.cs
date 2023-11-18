

namespace ClubDeportivo
{
    partial class FrmComprobante
    {
        private System.Windows.Forms.Label titleLabel;

        private void InitializeComponent()
        {
            titleLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(261, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(155, 26);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Comprobante";
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 431);
            panel1.TabIndex = 5;
            // 
            // FrmComprobante
            // 
            ClientSize = new Size(684, 461);
            Controls.Add(panel1);
            Name = "FrmComprobante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        public string socio;
        public string tipo;
        public string formaDePago;
        private string? actividad;
        public Decimal monto;
        public DateTime fecha_f = DateTime.Now;
        private Panel panel1;
    }
}
