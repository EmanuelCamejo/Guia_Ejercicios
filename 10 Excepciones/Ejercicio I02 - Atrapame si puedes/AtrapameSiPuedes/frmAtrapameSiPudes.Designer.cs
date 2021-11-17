
namespace AtrapameSiPuedes
{
    partial class frmAtrapameSiPuedes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.rtbCalculador = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(56, 58);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(100, 23);
            this.txtKilometros.TabIndex = 0;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(56, 107);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 23);
            this.txtLitros.TabIndex = 1;
            // 
            // rtbCalculador
            // 
            this.rtbCalculador.Enabled = false;
            this.rtbCalculador.Location = new System.Drawing.Point(178, 34);
            this.rtbCalculador.Name = "rtbCalculador";
            this.rtbCalculador.Size = new System.Drawing.Size(108, 146);
            this.rtbCalculador.TabIndex = 2;
            this.rtbCalculador.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(70, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(56, 40);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(64, 15);
            this.lblKilometros.TabIndex = 4;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(56, 89);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 5;
            this.lblLitros.Text = "Litros";
            // 
            // frmAtrapameSiPuedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 230);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtbCalculador);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtrapameSiPuedes";
            this.Text = "Calculador";
            this.Load += new System.EventHandler(this.frmAtrapameSiPuedes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.RichTextBox rtbCalculador;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblLitros;
    }
}

