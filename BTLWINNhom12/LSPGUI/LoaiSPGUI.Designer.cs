namespace BTLWINNhom12
{
	partial class LoaiSPGUI
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
			this.txt_maloai = new System.Windows.Forms.TextBox();
			this.txt_tenloai = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_tim = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_tim = new System.Windows.Forms.TextBox();
			this.btn_hienthi = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã loại";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(164, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên loại";
			// 
			// txt_maloai
			// 
			this.txt_maloai.Location = new System.Drawing.Point(311, 92);
			this.txt_maloai.Name = "txt_maloai";
			this.txt_maloai.Size = new System.Drawing.Size(211, 22);
			this.txt_maloai.TabIndex = 1;
			// 
			// txt_tenloai
			// 
			this.txt_tenloai.Location = new System.Drawing.Point(311, 151);
			this.txt_tenloai.Name = "txt_tenloai";
			this.txt_tenloai.Size = new System.Drawing.Size(211, 22);
			this.txt_tenloai.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(167, 275);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(600, 150);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã loại";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Tên loại";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Xóa";
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Sửa";
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(330, 215);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 30);
			this.btn_them.TabIndex = 3;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_tim
			// 
			this.btn_tim.Location = new System.Drawing.Point(692, 167);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(75, 30);
			this.btn_tim.TabIndex = 3;
			this.btn_tim.Text = "Tìm";
			this.btn_tim.UseVisualStyleBackColor = true;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(689, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên loại";
			// 
			// txt_tim
			// 
			this.txt_tim.Location = new System.Drawing.Point(631, 122);
			this.txt_tim.Name = "txt_tim";
			this.txt_tim.Size = new System.Drawing.Size(211, 22);
			this.txt_tim.TabIndex = 1;
			// 
			// btn_hienthi
			// 
			this.btn_hienthi.Location = new System.Drawing.Point(541, 215);
			this.btn_hienthi.Name = "btn_hienthi";
			this.btn_hienthi.Size = new System.Drawing.Size(75, 30);
			this.btn_hienthi.TabIndex = 4;
			this.btn_hienthi.Text = "Hiển thị";
			this.btn_hienthi.UseVisualStyleBackColor = true;
			this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(216, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(522, 55);
			this.label4.TabIndex = 5;
			this.label4.Text = "Quản lý loại sản phẩm";
			// 
			// LoaiSPGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 459);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_hienthi);
			this.Controls.Add(this.btn_tim);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_tim);
			this.Controls.Add(this.txt_tenloai);
			this.Controls.Add(this.txt_maloai);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "LoaiSPGUI";
			this.Text = "LoaiSPGUI";
			this.Activated += new System.EventHandler(this.LoaiSPGUI_Activated);
			this.Load += new System.EventHandler(this.LoaiSPGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_maloai;
		private System.Windows.Forms.TextBox txt_tenloai;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewButtonColumn Column3;
		private System.Windows.Forms.DataGridViewButtonColumn Column4;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_tim;
		private System.Windows.Forms.Button btn_hienthi;
		private System.Windows.Forms.Label label4;
	}
}