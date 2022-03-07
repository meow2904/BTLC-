namespace BTLWINNhom12
{
    partial class KhachHangEditGUI
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
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMakh
            // 
            this.txtMakh.Enabled = false;
            this.txtMakh.Location = new System.Drawing.Point(295, 79);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(268, 20);
            this.txtMakh.TabIndex = 0;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(295, 125);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(268, 20);
            this.txtTenkh.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(295, 263);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(268, 20);
            this.txtDiachi.TabIndex = 3;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(295, 309);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(268, 20);
            this.txtSodienthoai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaysinh.Location = new System.Drawing.Point(295, 168);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(268, 20);
            this.dateNgaysinh.TabIndex = 12;
            this.dateNgaysinh.ValueChanged += new System.EventHandler(this.dateNgaysinh_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(295, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 25);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(79, 10);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(6, 10);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // btCapnhat
            // 
            this.btCapnhat.Location = new System.Drawing.Point(295, 358);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btCapnhat.TabIndex = 14;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(488, 358);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 15;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sửa thông tin";
            // 
            // KhachHangEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.txtMakh);
            this.Name = "KhachHangEditGUI";
            this.Text = "KhachHangEditGUI";
            this.Load += new System.EventHandler(this.KhachHangEditGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Label label7;
    }
}