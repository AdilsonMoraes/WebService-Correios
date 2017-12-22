namespace correios
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
            this.btnConsultaCep = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaCep
            // 
            this.btnConsultaCep.Location = new System.Drawing.Point(52, 52);
            this.btnConsultaCep.Name = "btnConsultaCep";
            this.btnConsultaCep.Size = new System.Drawing.Size(82, 35);
            this.btnConsultaCep.TabIndex = 0;
            this.btnConsultaCep.Text = "Consultar Cep";
            this.btnConsultaCep.UseVisualStyleBackColor = true;
            this.btnConsultaCep.Click += new System.EventHandler(this.btnConsultaCep_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(52, 26);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(170, 20);
            this.txtCEP.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(55, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(167, 143);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "aaaa";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(140, 52);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 35);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnConsultaCep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaCep;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnLimpar;
    }
}

