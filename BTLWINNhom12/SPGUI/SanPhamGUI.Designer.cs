namespace BTLWINNhom12
{
	partial class SanPhamGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_loaisp = new System.Windows.Forms.ComboBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hangsx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_thongso = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Location = new System.Drawing.Point(694, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(214, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm sản phẩm";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(81, 86);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(56, 19);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên sản phẩm";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(40, 53);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(142, 20);
            this.txt_tim.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(31, 267);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 253);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sản phẩm IC Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sản phẩm";
            // 
            // cb_loaisp
            // 
            this.cb_loaisp.FormattingEnabled = true;
            this.cb_loaisp.Location = new System.Drawing.Point(500, 198);
            this.cb_loaisp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_loaisp.Name = "cb_loaisp";
            this.cb_loaisp.Size = new System.Drawing.Size(146, 21);
            this.cb_loaisp.TabIndex = 7;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(251, 89);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(133, 20);
            this.txt_masp.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(251, 126);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(133, 20);
            this.txt_tensp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hãng sản xuất";
            // 
            // txt_hangsx
            // 
            this.txt_hangsx.Location = new System.Drawing.Point(251, 164);
            this.txt_hangsx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_hangsx.Name = "txt_hangsx";
            this.txt_hangsx.Size = new System.Drawing.Size(133, 20);
            this.txt_hangsx.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá nhập";
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(251, 198);
            this.txt_gianhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(133, 20);
            this.txt_gianhap.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông số";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(500, 89);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(146, 20);
            this.txt_giaban.TabIndex = 8;
            // 
            // txt_thongso
            // 
            this.txt_thongso.Location = new System.Drawing.Point(500, 126);
            this.txt_thongso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_thongso.Name = "txt_thongso";
            this.txt_thongso.Size = new System.Drawing.Size(146, 20);
            this.txt_thongso.TabIndex = 8;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(500, 164);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(146, 20);
            this.txt_sl.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mã loại";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(694, 232);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(62, 21);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(781, 232);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(62, 21);
            this.btn_load.TabIndex = 9;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hãng sản xuất";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá nhập";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thông số";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mã loại";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Sửa";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Xóa";
            this.Column10.Name = "Column10";
            this.Column10.Width = 50;
            // 
            // SanPhamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 544);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_hangsx);
            this.Controls.Add(this.txt_thongso);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.cb_loaisp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SanPhamGUI";
            this.Text = "SanPhamGUI";
            this.Activated += new System.EventHandler(this.SanPhamGUI_Activated);
            this.Load += new System.EventHandler(this.SanPhamGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_tim;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_loaisp;
		private System.Windows.Forms.TextBox txt_masp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_tensp;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_hangsx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_gianhap;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_giaban;
		private System.Windows.Forms.TextBox txt_thongso;
		private System.Windows.Forms.TextBox txt_sl;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
    }
}