namespace Lec01.Calculadora
{
    partial class frmCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalc));
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(14, 6);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(79, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Primer Numero:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(12, 34);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(93, 13);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Segundo Numero:";
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.cmbOperaciones.Location = new System.Drawing.Point(162, 59);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(156, 21);
            this.cmbOperaciones.TabIndex = 4;
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(162, 88);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(156, 31);
            this.btnOperacion.TabIndex = 5;
            this.btnOperacion.Text = "Realizar operacion";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(162, 3);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(156, 20);
            this.txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(162, 31);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(156, 20);
            this.txtNum2.TabIndex = 7;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(12, 62);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(131, 13);
            this.lblOp.TabIndex = 8;
            this.lblOp.Text = "Seleccione una operacion";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(162, 127);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(156, 20);
            this.txtResult.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 127);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Resultado";
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 153);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}

