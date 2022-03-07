namespace BTLWINNhom12
{
	partial class QLPhieuNhapGUI
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_thoat = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_maphieu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_tim = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_all = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dataGridView1.Location = new System.Drawing.Point(61, 305);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1030, 232);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(261, 226);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(89, 37);
			this.btn_them.TabIndex = 1;
			this.btn_them.Text = "Nhập mới";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_thoat
			// 
			this.btn_thoat.Location = new System.Drawing.Point(424, 226);
			this.btn_thoat.Name = "btn_thoat";
			this.btn_thoat.Size = new System.Drawing.Size(89, 37);
			this.btn_thoat.TabIndex = 1;
			this.btn_thoat.Text = "Thoát";
			this.btn_thoat.UseVisualStyleBackColor = true;
			this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_maphieu);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btn_tim);
			this.groupBox1.Location = new System.Drawing.Point(738, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 161);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm phiếu nhập";
			// 
			// txt_maphieu
			// 
			this.txt_maphieu.Location = new System.Drawing.Point(43, 70);
			this.txt_maphieu.Name = "txt_maphieu";
			this.txt_maphieu.Size = new System.Drawing.Size(215, 22);
			this.txt_maphieu.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã phiếu";
			// 
			// btn_tim
			// 
			this.btn_tim.Location = new System.Drawing.Point(103, 107);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(89, 26);
			this.btn_tim.TabIndex = 1;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(263, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(546, 69);
			this.label2.TabIndex = 3;
			this.label2.Text = "Quản lý phiếu nhập";
			// 
			// btn_all
			// 
			this.btn_all.Location = new System.Drawing.Point(571, 226);
			this.btn_all.Name = "btn_all";
			this.btn_all.Size = new System.Drawing.Size(89, 37);
			this.btn_all.TabIndex = 1;
			this.btn_all.Text = "Xem tất cả";
			this.btn_all.UseVisualStyleBackColor = true;
			this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã hóa đơn ";
			this.Column1.Name = "Column1";
			this.Column1.Width = 120;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Ngày nhập";
			this.Column2.Name = "Column2";
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Mã nhân viên";
			this.Column3.Name = "Column3";
			this.Column3.Width = 120;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Mã NCC";
			this.Column4.Name = "Column4";
			this.Column4.Width = 120;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Chi tiết";
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column5.Width = 120;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Xóa";
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// QLPhieuNhapGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 562);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_all);
			this.Controls.Add(this.btn_thoat);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.dataGridView1);
			this.Name = "QLPhieuNhapGUI";
			this.Text = "QLPhieuNhapGUI";
			this.Load += new System.EventHandler(this.QLPhieuNhapGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_thoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_maphieu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_all;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewButtonColumn Column5;
		private System.Windows.Forms.DataGridViewButtonColumn Column6;
	}
}