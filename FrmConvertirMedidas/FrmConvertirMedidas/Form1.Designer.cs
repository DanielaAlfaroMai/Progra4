namespace FrmConvertirMedidas
{
    partial class FrmConvertirMedidas
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
            this.lblNumeroPulgadas = new System.Windows.Forms.Label();
            this.lblNumeroCentimentros = new System.Windows.Forms.Label();
            this.txtNumeroPulgadas = new System.Windows.Forms.TextBox();
            this.txtNumeroCentimetros = new System.Windows.Forms.TextBox();
            this.btnConvertirPulgadasEnCentimetros = new System.Windows.Forms.Button();
            this.btnConvertirCentimetrosEnPulgadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroPulgadas
            // 
            this.lblNumeroPulgadas.AutoSize = true;
            this.lblNumeroPulgadas.Location = new System.Drawing.Point(12, 24);
            this.lblNumeroPulgadas.Name = "lblNumeroPulgadas";
            this.lblNumeroPulgadas.Size = new System.Drawing.Size(108, 13);
            this.lblNumeroPulgadas.TabIndex = 0;
            this.lblNumeroPulgadas.Text = "Numero de pulgadas:";
            // 
            // lblNumeroCentimentros
            // 
            this.lblNumeroCentimentros.AutoSize = true;
            this.lblNumeroCentimentros.Location = new System.Drawing.Point(12, 73);
            this.lblNumeroCentimentros.Name = "lblNumeroCentimentros";
            this.lblNumeroCentimentros.Size = new System.Drawing.Size(120, 13);
            this.lblNumeroCentimentros.TabIndex = 1;
            this.lblNumeroCentimentros.Text = "Numero de Centimetros:";
            // 
            // txtNumeroPulgadas
            // 
            this.txtNumeroPulgadas.Location = new System.Drawing.Point(137, 21);
            this.txtNumeroPulgadas.Name = "txtNumeroPulgadas";
            this.txtNumeroPulgadas.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroPulgadas.TabIndex = 2;
            // 
            // txtNumeroCentimetros
            // 
            this.txtNumeroCentimetros.Location = new System.Drawing.Point(137, 70);
            this.txtNumeroCentimetros.Name = "txtNumeroCentimetros";
            this.txtNumeroCentimetros.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroCentimetros.TabIndex = 3;
            // 
            // btnConvertirPulgadasEnCentimetros
            // 
            this.btnConvertirPulgadasEnCentimetros.Location = new System.Drawing.Point(52, 118);
            this.btnConvertirPulgadasEnCentimetros.Name = "btnConvertirPulgadasEnCentimetros";
            this.btnConvertirPulgadasEnCentimetros.Size = new System.Drawing.Size(181, 23);
            this.btnConvertirPulgadasEnCentimetros.TabIndex = 4;
            this.btnConvertirPulgadasEnCentimetros.Text = " Pulgadas a Centimetros";
            this.btnConvertirPulgadasEnCentimetros.UseVisualStyleBackColor = true;
            this.btnConvertirPulgadasEnCentimetros.Click += new System.EventHandler(this.btnConvertirPulgadasEnCentimetros_Click);
            // 
            // btnConvertirCentimetrosEnPulgadas
            // 
            this.btnConvertirCentimetrosEnPulgadas.Location = new System.Drawing.Point(52, 147);
            this.btnConvertirCentimetrosEnPulgadas.Name = "btnConvertirCentimetrosEnPulgadas";
            this.btnConvertirCentimetrosEnPulgadas.Size = new System.Drawing.Size(181, 23);
            this.btnConvertirCentimetrosEnPulgadas.TabIndex = 5;
            this.btnConvertirCentimetrosEnPulgadas.Text = "Centimetro a Pulgadas";
            this.btnConvertirCentimetrosEnPulgadas.UseVisualStyleBackColor = true;
            this.btnConvertirCentimetrosEnPulgadas.Click += new System.EventHandler(this.btnConvertirCentimetrosEnPulgadas_Click);
            // 
            // FrmConvertirMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 182);
            this.Controls.Add(this.btnConvertirCentimetrosEnPulgadas);
            this.Controls.Add(this.btnConvertirPulgadasEnCentimetros);
            this.Controls.Add(this.txtNumeroCentimetros);
            this.Controls.Add(this.txtNumeroPulgadas);
            this.Controls.Add(this.lblNumeroCentimentros);
            this.Controls.Add(this.lblNumeroPulgadas);
            this.Name = "FrmConvertirMedidas";
            this.Text = "Convertir Medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroPulgadas;
        private System.Windows.Forms.Label lblNumeroCentimentros;
        private System.Windows.Forms.TextBox txtNumeroPulgadas;
        private System.Windows.Forms.TextBox txtNumeroCentimetros;
        private System.Windows.Forms.Button btnConvertirPulgadasEnCentimetros;
        private System.Windows.Forms.Button btnConvertirCentimetrosEnPulgadas;
    }
}

