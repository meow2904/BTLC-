namespace BTLWINNhom12.xuatGUI
{
    partial class FormXuat
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
            this.dgrGiohang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgrDssanpham = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMakh = new System.Windows.Forms.ComboBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateExport = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btXuat = new System.Windows.Forms.Button();
            this.btXemHD = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGiohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDssanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản phẩm hiện có";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giỏ hàng";
            // 
            // dgrGiohang
            // 
            this.dgrGiohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGiohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.chietkhau,
            this.Column5,
            this.Column12,
            this.Column6});
            this.dgrGiohang.Location = new System.Drawing.Point(35, 305);
            this.dgrGiohang.Name = "dgrGiohang";
            this.dgrGiohang.Size = new System.Drawing.Size(744, 223);
            this.dgrGiohang.TabIndex = 2;
            this.dgrGiohang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrGiohang_CellContentClick);
            this.dgrGiohang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrGiohang_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sp";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sp";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng mua";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // chietkhau
            // 
            this.chietkhau.HeaderText = "Chiết khấu";
            this.chietkhau.Name = "chietkhau";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "slco";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Xóa";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // dgrDssanpham
            // 
            this.dgrDssanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDssanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9,
            this.Column11});
            this.dgrDssanpham.Location = new System.Drawing.Point(35, 81);
            this.dgrDssanpham.Name = "dgrDssanpham";
            this.dgrDssanpham.Size = new System.Drawing.Size(648, 189);
            this.dgrDssanpham.TabIndex = 3;
            this.dgrDssanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDssanpham_CellClick_1);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã sp";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên sp";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 250;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Giá bán";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số lương có";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Hãng sản xuất";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMakh);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateExport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(784, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(97, 88);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(180, 20);
            this.txtManv.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nhân viên";
            // 
            // cbMakh
            // 
            this.cbMakh.FormattingEnabled = true;
            this.cbMakh.Location = new System.Drawing.Point(97, 186);
            this.cbMakh.Name = "cbMakh";
            this.cbMakh.Size = new System.Drawing.Size(100, 21);
            this.cbMakh.TabIndex = 9;
            this.cbMakh.SelectedIndexChanged += new System.EventHandler(this.cbMakh_SelectedIndexChanged);
            // 
            // txtTenkh
            // 
            this.txtTenkh.Enabled = false;
            this.txtTenkh.Location = new System.Drawing.Point(97, 220);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(180, 20);
            this.txtTenkh.TabIndex = 8;
            // 
            // txtTennv
            // 
            this.txtTennv.Enabled = false;
            this.txtTennv.Location = new System.Drawing.Point(97, 114);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(180, 20);
            this.txtTennv.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // dateExport
            // 
            this.dateExport.CustomFormat = "dd-MM-yyyy";
            this.dateExport.Enabled = false;
            this.dateExport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExport.Location = new System.Drawing.Point(97, 27);
            this.dateExport.Name = "dateExport";
            this.dateExport.Size = new System.Drawing.Size(103, 20);
            this.dateExport.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(803, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(806, 387);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(267, 20);
            this.txtTongtien.TabIndex = 13;
            // 
            // btXuat
            // 
            this.btXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btXuat.Location = new System.Drawing.Point(806, 441);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(75, 23);
            this.btXuat.TabIndex = 14;
            this.btXuat.Text = "Xuất HD";
            this.btXuat.UseVisualStyleBackColor = false;
            this.btXuat.Click += new System.EventHandler(this.btXuat_Click);
            // 
            // btXemHD
            // 
            this.btXemHD.Location = new System.Drawing.Point(903, 441);
            this.btXemHD.Name = "btXemHD";
            this.btXemHD.Size = new System.Drawing.Size(75, 23);
            this.btXemHD.TabIndex = 15;
            this.btXemHD.Text = "Xem HD";
            this.btXemHD.UseVisualStyleBackColor = true;
            this.btXemHD.Click += new System.EventHandler(this.btXemHD_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tìm sản phẩm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(132, 31);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(242, 20);
            this.txtTim.TabIndex = 18;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 545);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btXemHD);
            this.Controls.Add(this.btXuat);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrDssanpham);
            this.Controls.Add(this.dgrGiohang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormXuat";
            this.Text = "FormXuat";
            this.Load += new System.EventHandler(this.FormXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrGiohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDssanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrGiohang;
        private System.Windows.Forms.DataGridView dgrDssanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMakh;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btXuat;
        private System.Windows.Forms.Button btXemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn chietkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DateTimePicker dateExport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTim;
    }
}