namespace BTLWINNhom12.tkGUI
{
    partial class TaikhoanGUI
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
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.dgrTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quyền truy cập";
            // 
            // txtMatk
            // 
            this.txtMatk.Location = new System.Drawing.Point(236, 25);
            this.txtMatk.Name = "txtMatk";
            this.txtMatk.Size = new System.Drawing.Size(224, 20);
            this.txtMatk.TabIndex = 5;
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(236, 71);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(224, 20);
            this.txtTentk.TabIndex = 6;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(236, 117);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(224, 20);
            this.txtMatkhau.TabIndex = 7;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(236, 206);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(224, 21);
            this.cbManv.TabIndex = 9;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(518, 115);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(610, 115);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // dgrTaiKhoan
            // 
            this.dgrTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dgrTaiKhoan.Location = new System.Drawing.Point(83, 233);
            this.dgrTaiKhoan.Name = "dgrTaiKhoan";
            this.dgrTaiKhoan.Size = new System.Drawing.Size(650, 205);
            this.dgrTaiKhoan.TabIndex = 12;
            this.dgrTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTaiKhoan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã TK";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên TK";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quyền truy cập";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã NV";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sửa";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Xóa";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "admin",
            "nvban",
            "nvnhap"});
            this.cbQuyen.Location = new System.Drawing.Point(236, 160);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(224, 21);
            this.cbQuyen.TabIndex = 13;
            // 
            // TaikhoanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbQuyen);
            this.Controls.Add(this.dgrTaiKhoan);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cbManv);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.txtMatk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaikhoanGUI";
            this.Text = "TaikhoanGUI";
            this.Activated += new System.EventHandler(this.TaikhoanGUI_Activated);
            this.Load += new System.EventHandler(this.TaikhoanGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTaiKhoan)).EndInit();
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
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridView dgrTaiKhoan;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}