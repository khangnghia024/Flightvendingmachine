namespace WindowsFormsApp1
{
    partial class Form1
    {
        
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checklistpayment = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(282, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight ticket Vendor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1:00 pm ",
            "2:00 pm ",
            "3:00 pm ",
            "4:00 pm ",
            "5:00 pm ",
            "6:00 pm ",
            "7:00 pm ",
            "8:00 pm ",
            "9:00 pm ",
            "10:00 pm ",
            "11:00 pm ",
            "12:00 pm ",
            "1:00 am ",
            "2:00 am ",
            "3:00 am ",
            "4:00 am ",
            "5:00 am ",
            "6:00 am ",
            "7:00 am ",
            "8:00 am ",
            "9:00 am ",
            "10:00am ",
            "11:00am ",
            "12:00am "});
            this.comboBox1.Location = new System.Drawing.Point(31, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Thành phố Hà Nội",
            "Thành phố Hồ Chí Minh",
            "Tỉnh An Giang",
            "Tỉnh Bà Rịa - Vũng Tàu",
            "Tỉnh Bạc Liêu",
            "Tỉnh Bắc Giang",
            "Tỉnh Bắc Kạn",
            "Tỉnh Bắc Ninh",
            "Tỉnh Bến Tre",
            "Tỉnh Bình Dương",
            "Tỉnh Bình Định",
            "Tỉnh Bình Phước",
            "Tỉnh Bình Thuận",
            "Tỉnh Cao Bằng",
            "Tỉnh Cà Mau",
            "Thành phố Cần Thơ",
            "Thành phố Hải Phòng",
            "Thành phố Đà Nẵng",
            "Tỉnh Gia Lai",
            "Tỉnh Hòa Bình",
            "Tỉnh Hà Giang",
            "Tỉnh Hà Nam",
            "Tỉnh Hà Tĩnh",
            "Tỉnh Hưng Yên",
            "Tỉnh Hải Dương",
            "Tỉnh Hậu Giang",
            "Tỉnh Điện Biên",
            "Tỉnh Đắk Lắk",
            "Tỉnh Đắk Nông",
            "Tỉnh Đồng Nai",
            "Tỉnh Đồng Tháp",
            "Tỉnh Khánh Hòa",
            "Tỉnh Kiên Giang",
            "Tỉnh Kon Tum",
            "Tỉnh Lai Châu",
            "Tỉnh Long An",
            "Tỉnh Lào Cai",
            "Tỉnh Lâm Đồng",
            "Tỉnh Lạng Sơn",
            "Tỉnh Nam Định",
            "Tỉnh Nghệ An",
            "Tỉnh Ninh Bình",
            "Tỉnh Ninh Thuận",
            "Tỉnh Phú Thọ",
            "Tỉnh Phú Yên",
            "Tỉnh Quảng Bình",
            "Tỉnh Quảng Nam",
            "Tỉnh Quảng Ngãi",
            "Tỉnh Quảng Ninh",
            "Tỉnh Quảng Trị",
            "Tỉnh Sóc Trăng",
            "Tỉnh Sơn La",
            "Tỉnh Thanh Hóa",
            "Tỉnh Thái Bình",
            "Tỉnh Thái Nguyên",
            "Tỉnh Thừa Thiên - Huế",
            "Tỉnh Tiền Giang",
            "Tỉnh Trà Vinh",
            "Tỉnh Tuyên Quang",
            "Tỉnh Tây Ninh",
            "Tỉnh Vĩnh Long",
            "Tỉnh Vĩnh Phúc",
            "Tỉnh Yên Bái"});
            this.comboBox2.Location = new System.Drawing.Point(31, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checklistpayment
            // 
            this.checklistpayment.FormattingEnabled = true;
            this.checklistpayment.Items.AddRange(new object[] {
            "QR PAYMENT",
            "CREDIT CARD"});
            this.checklistpayment.Location = new System.Drawing.Point(716, 316);
            this.checklistpayment.Name = "checklistpayment";
            this.checklistpayment.Size = new System.Drawing.Size(176, 72);
            this.checklistpayment.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 512);
            this.Controls.Add(this.checklistpayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checklistpayment;
    }
}

