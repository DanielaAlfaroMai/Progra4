namespace Ejemplos.Enumerados
{
    partial class Enumerables
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
            this.lblagrega = new System.Windows.Forms.Label();
            this.txtAgrega = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.cmbSalida = new System.Windows.Forms.ComboBox();
            this.btnRefresca = new System.Windows.Forms.Button();
            this.btnRFLE = new System.Windows.Forms.Button();
            this.chbAgregafinal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblagrega
            // 
            this.lblagrega.AutoSize = true;
            this.lblagrega.Location = new System.Drawing.Point(41, 45);
            this.lblagrega.Name = "lblagrega";
            this.lblagrega.Size = new System.Drawing.Size(82, 13);
            this.lblagrega.TabIndex = 0;
            this.lblagrega.Text = "Texto a agregar";
            // 
            // txtAgrega
            // 
            this.txtAgrega.Location = new System.Drawing.Point(148, 42);
            this.txtAgrega.Name = "txtAgrega";
            this.txtAgrega.Size = new System.Drawing.Size(162, 20);
            this.txtAgrega.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(341, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(89, 124);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(120, 95);
            this.lb.TabIndex = 3;
            // 
            // cmbSalida
            // 
            this.cmbSalida.FormattingEnabled = true;
            this.cmbSalida.Location = new System.Drawing.Point(310, 124);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.Size = new System.Drawing.Size(121, 21);
            this.cmbSalida.TabIndex = 4;
            // 
            // btnRefresca
            // 
            this.btnRefresca.Location = new System.Drawing.Point(277, 95);
            this.btnRefresca.Name = "btnRefresca";
            this.btnRefresca.Size = new System.Drawing.Size(154, 23);
            this.btnRefresca.TabIndex = 5;
            this.btnRefresca.Text = "Refrescar Combox";
            this.btnRefresca.UseVisualStyleBackColor = true;
            this.btnRefresca.Click += new System.EventHandler(this.btnRefresca_Click);
            // 
            // btnRFLE
            // 
            this.btnRFLE.Location = new System.Drawing.Point(277, 69);
            this.btnRFLE.Name = "btnRFLE";
            this.btnRFLE.Size = new System.Drawing.Size(154, 23);
            this.btnRFLE.TabIndex = 6;
            this.btnRFLE.Text = "Refrestar Lista enlazada";
            this.btnRFLE.UseVisualStyleBackColor = true;
            this.btnRFLE.Click += new System.EventHandler(this.btnRFLE_Click);
            // 
            // chbAgregafinal
            // 
            this.chbAgregafinal.AutoSize = true;
            this.chbAgregafinal.Location = new System.Drawing.Point(277, 160);
            this.chbAgregafinal.Name = "chbAgregafinal";
            this.chbAgregafinal.Size = new System.Drawing.Size(96, 17);
            this.chbAgregafinal.TabIndex = 7;
            this.chbAgregafinal.Text = "Agregar al final";
            this.chbAgregafinal.UseVisualStyleBackColor = true;
            // 
            // Enumerables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chbAgregafinal);
            this.Controls.Add(this.btnRFLE);
            this.Controls.Add(this.btnRefresca);
            this.Controls.Add(this.cmbSalida);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAgrega);
            this.Controls.Add(this.lblagrega);
            this.Name = "Enumerables";
            this.Text = "Enumerables";
            this.Load += new System.EventHandler(this.Enumerables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagrega;
        private System.Windows.Forms.TextBox txtAgrega;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ComboBox cmbSalida;
        private System.Windows.Forms.Button btnRefresca;
        private System.Windows.Forms.Button btnRFLE;
        private System.Windows.Forms.CheckBox chbAgregafinal;
    }
}