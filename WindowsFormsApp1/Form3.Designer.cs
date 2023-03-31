namespace WindowsFormsApp1
{
    partial class qrpayment
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureQRBOX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "QR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureQRBOX
            // 
            this.pictureQRBOX.Location = new System.Drawing.Point(205, 12);
            this.pictureQRBOX.Name = "pictureQRBOX";
            this.pictureQRBOX.Size = new System.Drawing.Size(429, 367);
            this.pictureQRBOX.TabIndex = 1;
            this.pictureQRBOX.TabStop = false;
            this.pictureQRBOX.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // qrpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureQRBOX);
            this.Controls.Add(this.button1);
            this.Name = "qrpayment";
            this.Text = "qrpayment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureQRBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureQRBOX;
    }
}