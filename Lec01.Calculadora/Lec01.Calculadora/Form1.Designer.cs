namespace Lec01.Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.chboperacio = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(67, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Basica";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(221, 75);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(70, 82);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(114, 13);
            this.lblSub.TabIndex = 2;
            this.lblSub.Text = "Digite el primer numero";
            // 
            // chboperacio
            // 
            this.chboperacio.AutoSize = true;
            this.chboperacio.Location = new System.Drawing.Point(73, 123);
            this.chboperacio.Name = "chboperacio";
            this.chboperacio.Size = new System.Drawing.Size(53, 17);
            this.chboperacio.TabIndex = 3;
            this.chboperacio.Text = "Suma";
            this.chboperacio.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chboperacio);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lec01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.CheckBox chboperacio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

