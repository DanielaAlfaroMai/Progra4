namespace frmConvertirGrados
{
    partial class FrmConvertirGrados
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
            this.lblNumeroFahrenheit = new System.Windows.Forms.Label();
            this.lblNumeroCelsius = new System.Windows.Forms.Label();
            this.txtNumeroCelcius = new System.Windows.Forms.TextBox();
            this.txtNumeroFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertirCelciusEnFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertirFahrenhietEnCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroFahrenheit
            // 
            this.lblNumeroFahrenheit.AutoSize = true;
            this.lblNumeroFahrenheit.Location = new System.Drawing.Point(8, 66);
            this.lblNumeroFahrenheit.Name = "lblNumeroFahrenheit";
            this.lblNumeroFahrenheit.Size = new System.Drawing.Size(150, 13);
            this.lblNumeroFahrenheit.TabIndex = 0;
            this.lblNumeroFahrenheit.Text = "Numero de grados Fahrenheit:";
            // 
            // lblNumeroCelsius
            // 
            this.lblNumeroCelsius.AutoSize = true;
            this.lblNumeroCelsius.Location = new System.Drawing.Point(8, 21);
            this.lblNumeroCelsius.Name = "lblNumeroCelsius";
            this.lblNumeroCelsius.Size = new System.Drawing.Size(133, 13);
            this.lblNumeroCelsius.TabIndex = 1;
            this.lblNumeroCelsius.Text = "Numero de grados Celsius:";
            // 
            // txtNumeroCelcius
            // 
            this.txtNumeroCelcius.Location = new System.Drawing.Point(185, 21);
            this.txtNumeroCelcius.Name = "txtNumeroCelcius";
            this.txtNumeroCelcius.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroCelcius.TabIndex = 2;
            // 
            // txtNumeroFahrenheit
            // 
            this.txtNumeroFahrenheit.Location = new System.Drawing.Point(185, 66);
            this.txtNumeroFahrenheit.Name = "txtNumeroFahrenheit";
            this.txtNumeroFahrenheit.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroFahrenheit.TabIndex = 3;
            // 
            // btnConvertirCelciusEnFahrenheit
            // 
            this.btnConvertirCelciusEnFahrenheit.Location = new System.Drawing.Point(72, 110);
            this.btnConvertirCelciusEnFahrenheit.Name = "btnConvertirCelciusEnFahrenheit";
            this.btnConvertirCelciusEnFahrenheit.Size = new System.Drawing.Size(167, 23);
            this.btnConvertirCelciusEnFahrenheit.TabIndex = 4;
            this.btnConvertirCelciusEnFahrenheit.Text = "Celcius a Fahrenheit";
            this.btnConvertirCelciusEnFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirCelciusEnFahrenheit.Click += new System.EventHandler(this.btnConvertirCelciusEnFahrenheit_Click);
            // 
            // btnConvertirFahrenhietEnCelsius
            // 
            this.btnConvertirFahrenhietEnCelsius.Location = new System.Drawing.Point(72, 155);
            this.btnConvertirFahrenhietEnCelsius.Name = "btnConvertirFahrenhietEnCelsius";
            this.btnConvertirFahrenhietEnCelsius.Size = new System.Drawing.Size(167, 23);
            this.btnConvertirFahrenhietEnCelsius.TabIndex = 5;
            this.btnConvertirFahrenhietEnCelsius.Text = "Fahrenheit a Celcius";
            this.btnConvertirFahrenhietEnCelsius.UseVisualStyleBackColor = true;
            this.btnConvertirFahrenhietEnCelsius.Click += new System.EventHandler(this.btnConvertirFahrenhietEnCelsius_Click);
            // 
            // FrmConvertirGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.btnConvertirFahrenhietEnCelsius);
            this.Controls.Add(this.btnConvertirCelciusEnFahrenheit);
            this.Controls.Add(this.txtNumeroFahrenheit);
            this.Controls.Add(this.txtNumeroCelcius);
            this.Controls.Add(this.lblNumeroCelsius);
            this.Controls.Add(this.lblNumeroFahrenheit);
            this.Name = "FrmConvertirGrados";
            this.Text = "Grados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroFahrenheit;
        private System.Windows.Forms.Label lblNumeroCelsius;
        private System.Windows.Forms.TextBox txtNumeroCelcius;
        private System.Windows.Forms.TextBox txtNumeroFahrenheit;
        private System.Windows.Forms.Button btnConvertirCelciusEnFahrenheit;
        private System.Windows.Forms.Button btnConvertirFahrenhietEnCelsius;
    }
}

