namespace BTLWINNhom12.xuatGUI
{
    partial class ChitietXuatGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrDsHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrChitietban = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.txtNgayxuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDsHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChitietban)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách đơn";
            // 
            // dgrDsHoaDon
            // 
            this.dgrDsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDsHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9});
            this.dgrDsHoaDon.Location = new System.Drawing.Point(12, 146);
            this.dgrDsHoaDon.Name = "dgrDsHoaDon";
            this.dgrDsHoaDon.Size = new System.Drawing.Size(450, 374);
            this.dgrDsHoaDon.TabIndex = 6;
            this.dgrDsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDsHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HD";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày xuất";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã NV";
            this.Column3.Name = "Column3";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Mã KH";
            this.Column9.Name = "Column9";
            // 
            // dgrChitietban
            // 
            this.dgrChitietban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrChitietban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10});
            this.dgrChitietban.Location = new System.Drawing.Point(23, 112);
            this.dgrChitietban.Name = "dgrChitietban";
            this.dgrChitietban.Size = new System.Drawing.Size(572, 300);
            this.dgrChitietban.TabIndex = 7;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã sp";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên sp";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá bán";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Chiết khấu";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Thành tiền";
            this.Column10.Name = "Column10";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(92, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(251, 20);
            this.txtTim.TabIndex = 8;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã HD";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(85, 47);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(182, 20);
            this.txtTenNV.TabIndex = 11;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(392, 19);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(203, 20);
            this.txtTenkh.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(392, 51);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(203, 20);
            this.txtDiachi.TabIndex = 13;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(392, 86);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(203, 20);
            this.txtSodienthoai.TabIndex = 14;
            // 
            // txtNgayxuat
            // 
            this.txtNgayxuat.Location = new System.Drawing.Point(85, 82);
            this.txtNgayxuat.Name = "txtNgayxuat";
            this.txtNgayxuat.Size = new System.Drawing.Size(182, 20);
            this.txtNgayxuat.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btDong);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgrChitietban);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgayxuat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSodienthoai);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Location = new System.Drawing.Point(485, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 508);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tổng tiền";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(510, 474);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 21;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(85, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(182, 20);
            this.txtMaHD.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã hóa đơn";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(480, 418);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(115, 20);
            this.txtTongtien.TabIndex = 19;
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChitietXuatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 541);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.dgrDsHoaDon);
            this.Controls.Add(this.label6);
            this.Name = "ChitietXuatGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChitietXuatGUI";
            this.Load += new System.EventHandler(this.ChitietXuatGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDsHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrChitietban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgrDsHoaDon;
        private System.Windows.Forms.DataGridView dgrChitietban;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.TextBox txtNgayxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label9;
    }
}