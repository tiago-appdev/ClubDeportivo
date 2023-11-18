using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo
{
    partial class FrmPago
    {
        public FrmComprobante comprobante = new();
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

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button pagarButton;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox socioNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cuotaAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cardExpirationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cardCvvTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cuotasComboBox;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code


        #endregion

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            verificarSocioButton = new Button();
            pagarButton = new Button();
            volverButton = new Button();
            label1 = new Label();
            socioNumberTextBox = new TextBox();
            label2 = new Label();
            activityComboBox = new ComboBox();
            label3 = new Label();
            cuotaAmountTextBox = new TextBox();
            label4 = new Label();
            cardNumberTextBox = new TextBox();
            label5 = new Label();
            cardExpirationTextBox = new TextBox();
            label6 = new Label();
            cardCvvTextBox = new TextBox();
            label7 = new Label();
            cuotasComboBox = new ComboBox();

            label7.AutoSize = true;
            label7.Location = new Point(501, 170);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Cuotas:";

            cuotasComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cuotasComboBox.FormattingEnabled = true;
            cuotasComboBox.Items.AddRange(new object[] { "1", "3", "6" });
            cuotasComboBox.Location = new Point(641, 166);
            cuotasComboBox.Margin = new Padding(4, 3, 4, 3);
            cuotasComboBox.Name = "cuotasComboBox";
            cuotasComboBox.Size = new Size(60, 23);
            cuotasComboBox.TabIndex = 14;


            label4.Visible = false;
            cardNumberTextBox.Visible = false;
            label5.Visible = false;
            cardExpirationTextBox.Visible = false;
            label6.Visible = false;
            cardCvvTextBox.Visible = false;
            label7.Visible = false;
            cuotasComboBox.Visible = false;
            cuotasComboBox.SelectedIndex = 0;
            SuspendLayout();

            radioButton1.CheckedChanged += TextBox_TextChanged;
            cuotaAmountTextBox.TextChanged += TextBox_TextChanged;
            cardNumberTextBox.TextChanged += TextBox_TextChanged;
            cardExpirationTextBox.TextChanged += TextBox_TextChanged;
            cardCvvTextBox.TextChanged += TextBox_TextChanged;

            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(79, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Efectivo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(201, 170);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // verificarSocioButton
            // 
            verificarSocioButton.Location = new Point(328, 63);
            verificarSocioButton.Name = "verificarSocioButton";
            verificarSocioButton.Size = new Size(75, 23);
            verificarSocioButton.TabIndex = 12;
            verificarSocioButton.Text = "Verificar Socio";
            verificarSocioButton.Click += verificarSocioButton_Click;
            verificarSocioButton.UseVisualStyleBackColor = true;
            // 
            // pagarButton
            // 
            pagarButton.Enabled = false;
            pagarButton.Location = new Point(75, 215);
            pagarButton.Margin = new Padding(4, 3, 4, 3);
            pagarButton.Name = "pagarButton";
            pagarButton.Size = new Size(88, 27);
            pagarButton.TabIndex = 1;
            pagarButton.Text = "Pagar";
            pagarButton.Click += pagarButton_Click;
            pagarButton.UseVisualStyleBackColor = true;
            // 
            // volverButton
            // 
            volverButton.Location = new Point(201, 215);
            volverButton.Margin = new Padding(4, 3, 4, 3);
            volverButton.Name = "volverButton";
            volverButton.Size = new Size(88, 27);
            volverButton.TabIndex = 2;
            volverButton.Text = "Volver";
            volverButton.Click += volverButton_Click;
            volverButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Número de Socio:";
            // 
            // socioNumberTextBox
            // 
            socioNumberTextBox.Location = new Point(201, 63);
            socioNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            socioNumberTextBox.Name = "socioNumberTextBox";
            socioNumberTextBox.Size = new Size(116, 23);
            socioNumberTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Actividad:";
            label2.Visible = false;
            // 
            // activityComboBox
            // 
            activityComboBox.Visible = false;
            activityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityComboBox.FormattingEnabled = true;
            activityComboBox.Items.AddRange(new object[] { "Fútbol", "Natación", "Tenis" });
            activityComboBox.Location = new Point(201, 97);
            activityComboBox.Margin = new Padding(4, 3, 4, 3);
            activityComboBox.Name = "activityComboBox";
            activityComboBox.Size = new Size(140, 23);
            activityComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Monto Cuota:";
            // 
            // cuotaAmountTextBox
            // 
            cuotaAmountTextBox.Location = new Point(201, 132);
            cuotaAmountTextBox.Margin = new Padding(4, 3, 4, 3);
            cuotaAmountTextBox.Name = "cuotaAmountTextBox";
            cuotaAmountTextBox.ReadOnly = true;
            cuotaAmountTextBox.Size = new Size(116, 23);
            cuotaAmountTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Número Tarjeta:";
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(641, 66);
            cardNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(116, 23);
            cardNumberTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 104);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 7;
            label5.Text = "Fecha de Expiración:";
            // 
            // cardExpirationTextBox
            // 
            cardExpirationTextBox.Location = new Point(641, 101);
            cardExpirationTextBox.Margin = new Padding(4, 3, 4, 3);
            cardExpirationTextBox.Name = "cardExpirationTextBox";
            cardExpirationTextBox.Size = new Size(116, 23);
            cardExpirationTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 139);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 8;
            label6.Text = "CVV:";
            // 
            // cardCvvTextBox
            // 
            cardCvvTextBox.Location = new Point(641, 135);
            cardCvvTextBox.Margin = new Padding(4, 3, 4, 3);
            cardCvvTextBox.Name = "cardCvvTextBox";
            cardCvvTextBox.Size = new Size(116, 23);
            cardCvvTextBox.TabIndex = 9;
            // 
            // PagoCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 255, 199);
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(verificarSocioButton);
            Controls.Add(pagarButton);
            Controls.Add(volverButton);
            Controls.Add(label1);
            Controls.Add(socioNumberTextBox);
            Controls.Add(label2);
            Controls.Add(activityComboBox);
            Controls.Add(label3);
            Controls.Add(cuotaAmountTextBox);
            Controls.Add(label4);
            Controls.Add(cardNumberTextBox);
            Controls.Add(label5);
            Controls.Add(cardExpirationTextBox);
            Controls.Add(label6);
            Controls.Add(cardCvvTextBox);
            Controls.Add(label7);
            Controls.Add(cuotasComboBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PagoCuota";
            Text = "PagoCuota";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Chequear condiciones para habilitar o deshabilitar el boton de pago
            bool isCuotaAmountValid = !string.IsNullOrEmpty(cuotaAmountTextBox.Text);
            bool isFormaDePagoSelected = radioButton1.Checked || ((radioButton2.Checked && !string.IsNullOrEmpty(cardNumberTextBox.Text) && !string.IsNullOrEmpty(cardExpirationTextBox.Text) && !string.IsNullOrEmpty(cardCvvTextBox.Text)));

            pagarButton.Enabled = isCuotaAmountValid && isFormaDePagoSelected;
        }


        private void pagarButton_Click(object sender, EventArgs e)
        {

            try
            {
                Clientes clientesDb = new();
                bool? id = clientesDb.PagarCuota(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            comprobante.Show();
            this.Hide();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            frmMenu menuPrincipal = new() //Instanciamos el menu principal para mostrarlo.
            {
                rol = FrmInicio.Rol,
                usuario = FrmInicio.Usuario
            };
            menuPrincipal.Show(); //Se muestra el menu principal
            this.Hide(); // se oculta el formulario del login
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool isTarjetaSelected = radioButton2.Checked;
            label4.Visible = isTarjetaSelected;
            cardNumberTextBox.Visible = isTarjetaSelected;
            label5.Visible = isTarjetaSelected;
            cardExpirationTextBox.Visible = isTarjetaSelected;
            label6.Visible = isTarjetaSelected;
            cardCvvTextBox.Visible = isTarjetaSelected;
            label7.Visible = isTarjetaSelected;
            cuotasComboBox.Visible = isTarjetaSelected;
        }


        private void verificarSocioButton_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                if (socioNumberTextBox.Text == string.Empty)
                {
                    throw new Exception("Debe ingresar un número de socio");
                }
                sqlCon = Conexion.GetInstancia().CrearConexion();
                string comprobanteQuery = @"
SELECT
    CASE
        WHEN c.Tipo = 'Socio' THEN s.Numero_De_Socio
        WHEN c.Tipo = 'No Socio' THEN ns.Numero_De_NoSocio
        ELSE NULL
    END AS Numero_De_Socio,
    c.Nombre AS ClienteNombre,
    c.Apellido AS ClienteApellido,
    c.DNI AS ClienteDNI,
    c.Direccion AS ClienteDireccion,
    c.Telefono AS ClienteTelefono,
    c.Tipo AS TipoCliente,
    a.Nombre AS ActividadNombre,
    a.Precio AS ActividadPrecio,
    cu.FechaDeVencimiento AS CuotaFechaVencimiento,
    cu.Monto AS CuotaMonto,
    CASE
        WHEN c.Tipo = 'Socio' THEN 'Cuota Mensual'
        WHEN c.Tipo = 'No Socio' THEN 'Cuota por Actividad'
        ELSE 'Tipo no especificado'
    END AS Concepto
FROM
    Clientes c
LEFT JOIN Socios s ON c.Tipo = 'Socio' AND s.Cliente_id = c.Cliente_id
LEFT JOIN NoSocios ns ON c.Tipo = 'No Socio' AND ns.Cliente_id = c.Cliente_id
JOIN Cuotas cu ON COALESCE(s.Cuota_id, ns.Cuota_id) = cu.Cuota_id
LEFT JOIN Actividades a ON c.Tipo = 'No Socio' AND a.Numero_De_Actividad = cu.Cuota_id
WHERE
    c.Cliente_id = " + socioNumberTextBox.Text;
                MySqlCommand comando = new MySqlCommand(comprobanteQuery, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader.GetString(6) == "Socio")
                    {
                        cliente = new Socio(reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), new Cuota(reader.GetDecimal(10)), 0, reader.GetString(3));
                    }
                    else
                    {
                        cliente = new NoSocio(reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), new Cuota(reader.GetDecimal(8)), 0, reader.GetString(3));
                        label2.Visible = true;
                        activityComboBox.Visible = true;
                    }

                    comprobante.socio = reader.GetString(0);
                    comprobante.tipo = cliente.Tipo;
                    comprobante.formaDePago = radioButton1.Checked ? "Efectivo" : "Tarjeta";
                    comprobante.monto = cliente.Cuota.Monto;

                    cuotaAmountTextBox.Text = cliente.Cuota.Monto.ToString();


                }
                else
                {
                    MessageBox.Show("Número de socio inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

        }

        private Button verificarSocioButton;
    }
}
