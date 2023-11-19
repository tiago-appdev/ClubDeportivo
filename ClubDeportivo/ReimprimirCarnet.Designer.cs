
namespace ClubDeportivo
{
    partial class FrmCarnet
    {
        public FrmCredencialSocio formularioDeCarnet = new();
        public Cliente cliente;
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

        private Button verificarSocioButton;

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox socioNumberTextBox;
       

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code


        #endregion

        private void InitializeComponent()
        {
            verificarSocioButton = new Button();
            volverButton = new Button();
            label1 = new Label();
            socioNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // verificarSocioButton
            // 
            verificarSocioButton.Location = new Point(328, 63);
            verificarSocioButton.Name = "verificarSocioButton";
            verificarSocioButton.Size = new Size(75, 23);
            verificarSocioButton.TabIndex = 12;
            verificarSocioButton.Text = "Buscar Socio";
            verificarSocioButton.UseVisualStyleBackColor = true;
            verificarSocioButton.Click += verificarSocioButton_Click;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(201, 215 - 35);
            volverButton.Margin = new Padding(4, 3, 4, 3);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(88, 27);
            volverButton.TabIndex = 2;
            volverButton.Text = "Volver";
            volverButton.UseVisualStyleBackColor = true;
            volverButton.Click += volverButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Número de Cliente:";
            // 
            // socioNumberTextBox
            // 
            socioNumberTextBox.Location = new Point(201, 63);
            socioNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            socioNumberTextBox.Name = "socioNumberTextBox";
            socioNumberTextBox.Size = new Size(116, 23);
            socioNumberTextBox.TabIndex = 4;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 255, 199);
            ClientSize = new Size(800, 450);
            Controls.Add(verificarSocioButton);
            Controls.Add(volverButton);
            Controls.Add(label1);
            Controls.Add(socioNumberTextBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReimprimirCarnet";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
