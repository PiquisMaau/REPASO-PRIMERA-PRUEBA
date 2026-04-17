namespace SimuladorBancarioRepaso
{
    partial class OperacionBancaria
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
            this.buttonRETIRO = new System.Windows.Forms.Button();
            this.buttonDEPOSITO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRETIRO
            // 
            this.buttonRETIRO.Location = new System.Drawing.Point(96, 53);
            this.buttonRETIRO.Name = "buttonRETIRO";
            this.buttonRETIRO.Size = new System.Drawing.Size(194, 23);
            this.buttonRETIRO.TabIndex = 0;
            this.buttonRETIRO.Text = "RETIRAR DINERO";
            this.buttonRETIRO.UseVisualStyleBackColor = true;
            this.buttonRETIRO.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDEPOSITO
            // 
            this.buttonDEPOSITO.Location = new System.Drawing.Point(96, 105);
            this.buttonDEPOSITO.Name = "buttonDEPOSITO";
            this.buttonDEPOSITO.Size = new System.Drawing.Size(194, 23);
            this.buttonDEPOSITO.TabIndex = 1;
            this.buttonDEPOSITO.Text = "DEPOSITAR DINERO";
            this.buttonDEPOSITO.UseVisualStyleBackColor = true;
            this.buttonDEPOSITO.Click += new System.EventHandler(this.buttonDEPOSITO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qué desea hacer hoy?";
            // 
            // OperacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDEPOSITO);
            this.Controls.Add(this.buttonRETIRO);
            this.Name = "OperacionBancaria";
            this.Text = "OperacionBancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRETIRO;
        private System.Windows.Forms.Button buttonDEPOSITO;
        private System.Windows.Forms.Label label1;
    }
}