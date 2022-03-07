namespace BTLWINNhom12.tkGUI
{
    partial class TaikhoanEditGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatk = new System.Windows.Forms.TextBox();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtMatk
            // 
            this.txtMatk.Location = new System.Drawing.Point(199, 44);
            this.txtMatk.Name = "txtMatk";
            this.txtMatk.Size = new System.Drawing.Size(217, 20);
            this.txtMatk.TabIndex = 5;
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(199, 86);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(217, 20);
            this.txtTentk.TabIndex = 6;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(199, 125);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(217, 20);
            this.txtMatkhau.TabIndex = 7;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(199, 196);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(217, 20);
            this.txtManv.TabIndex = 8;
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "admin",
            "nvban",
            "nvnhap"});
            this.cbQuyen.Location = new System.Drawing.Point(199, 156);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(217, 21);
            this.cbQuyen.TabIndex = 9;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(199, 245);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btCapNhat.TabIndex = 10;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(294, 244);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // TaikhoanEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 350);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.txtMatk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaikhoanEditGUI";
            this.Text = "TaikhoanEditGUI";
            this.Load += new System.EventHandler(this.TaikhoanEditGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatk;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btDong;
    }
}